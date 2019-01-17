using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyProvider.dtos;

namespace DataProvider.dtos
{
    public class Catalogue
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Key { get; set; }

        public List<Position> positions { get; set; }
    }
}
