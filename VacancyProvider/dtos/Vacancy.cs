using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider.dtos
{
    public class Vacancy
    {
        public int Id { get; set; }

        public int IdClient { get; set; }

        public string Profession { get; set; }

        public int PaymentFrom { get; set; }

        public DateTime DatePublished { get; set; }

        public List<Catalogue> Catalogues { get; set; }

        public Client Client { get; set; }
    }
}
