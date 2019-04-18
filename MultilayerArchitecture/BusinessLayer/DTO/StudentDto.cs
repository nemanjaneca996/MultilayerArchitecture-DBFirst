using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayerArchitecture.BusinessLayer.DTO
{
    public class StudentDto : BaseDto
    {
        public int idStudent { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public int indeksBroj { get; set; }
        public int indeksGodina { get; set; }
        public string indeksCalc { get; set; }
        public string imePrezime { get; set; }
    }
}
