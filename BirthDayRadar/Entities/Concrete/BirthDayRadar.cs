using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class BirthDayRadar : IEntity
    {

        public int Id { get; set; }
        public string Telephone { get; set; }
        public DateTime Date { get; set; }
        public int NewAge { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Note { get; set; }
        public string Job { get; set; }

    }
}
