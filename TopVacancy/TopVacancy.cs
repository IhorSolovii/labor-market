using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataProvider;
using DataProvider.dtos;

namespace TopVacancy
{
    public partial class TopVacancy : Form
    {
        private JobInfoProvider jobInfoProvider = new JobInfoProvider();
        private List<Vacancy> vacancies = new List<Vacancy>();
        private List<IGrouping<string, Catalogue>> catalogues = new List<IGrouping<string, Catalogue>>();
        private List<Client> clients = new List<Client>();

        public TopVacancy()
        {
            vacancies.AddRange(jobInfoProvider.GetVacancies());
            catalogues.AddRange(jobInfoProvider.GroupByCatalogs(vacancies));
            clients.AddRange(jobInfoProvider.GetBigestClients(vacancies));

            InitializeComponent();

            CreateVacanciesListView();
            CreateCatalogueListView();
            CreateClientsListView();
        }

        private void CreateVacanciesListView()
        {
            vacanciesListView.View = View.Details;
            vacanciesListView.GridLines = true;
            vacanciesListView.FullRowSelect = true;

            vacanciesListView.Columns.Add("Title", 670);
            vacanciesListView.Columns.Add("Salary", 63);

            var rows = vacancies.Take(20)
                                .Select(i => new ListViewItem(new string[] { i.Profession, i.PaymentFrom.ToString() }))
                                .ToArray();

            vacanciesListView.Items.AddRange(rows);
        }

        private void CreateCatalogueListView()
        {
            cataloguesListView.View = View.Details;
            cataloguesListView.GridLines = true;
            cataloguesListView.FullRowSelect = true;

            cataloguesListView.Columns.Add("Category Name", 640);
            cataloguesListView.Columns.Add("Vacancies Count", 93, HorizontalAlignment.Center);

            var rows = catalogues.Select(i => new ListViewItem(new string[] { i.Key, i.Count().ToString() }))
                                 .ToArray();

            cataloguesListView.Items.AddRange(rows);
        }

        private void CreateClientsListView()
        {
            clientsListView.View = View.Details;
            clientsListView.GridLines = true;
            clientsListView.FullRowSelect = true;

            clientsListView.Columns.Add("Employer Name", 623);
            clientsListView.Columns.Add("Vacancies Count", 93, HorizontalAlignment.Center);

            var rows = clients.Select(i => new ListViewItem(new string[] { i.Title, i.VacancyCount.ToString() }))
                              .ToArray();

            clientsListView.Items.AddRange(rows);
        }
    }
}
