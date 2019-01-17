using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using RestSharp;
using DataProvider.dtos;

namespace DataProvider
{
    public class JobInfoProvider
    {
        private const string privateKey = "v1.r07986d1d9639be4073a5846e57021946df82634ab8348fdfc71fb0d5d620f59ed40b41d3.ba5749b1010c650324cd835cf67ad426036e0734";
        private const string apiUrl = "https://api.superjob.ua/2.0/";
        private RestClient client = new RestClient(apiUrl);
        private int region = 110; //Kiev = 110, Kharkiv=121, Lviv = 114

        public List<Vacancy> GetVacancies()
        {
            var vacancies = new List<Vacancy>();

            int page = 0;
            bool hasMore = true;
            do
            {
                var request = new RestRequest($"vacancies?o={region}&page={page}&count=100&period=1", Method.GET);
                request.AddHeader("X-Api-App-Id", privateKey);

                var response = client.Execute<ListResponse<Vacancy>>(request);
                hasMore = response.Data.More;

                vacancies.AddRange(response.Data.Objects);
                page++;
            }
            while (hasMore);

            return vacancies.OrderByDescending(x => x.PaymentFrom).ToList();
        }

        public List<IGrouping<string, Catalogue>> GroupByCatalogs(List<Vacancy> vacancies)
        {
            var dict = new Dictionary<int, List<Vacancy>>();
            var catalogues = new List<Catalogue>();
            vacancies.ForEach(vacancy =>
            {
                catalogues.AddRange(vacancy.Catalogues.ToList());
            });

            return catalogues.GroupBy(x => x.Title).OrderByDescending(x => x.Count()).ToList();
        }

        public List<Client> GetBigestClients(List<Vacancy> vacancies)
        {

            return vacancies.Select(x => x.Client).GroupBy(x => x.Id).Select(x => x.First()).OrderByDescending(y => y.VacancyCount).ToList();
        }

        public class ListResponse<T>
        {
            public List<T> Objects { get; set; }

            public int Total { get; set; }

            public bool More { get; set; }
        }
    }
}
