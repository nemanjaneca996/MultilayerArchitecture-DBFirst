using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayerArchitecture.BusinessLayer.DTO
{
    public class StudentIspitDto : BaseDto
    {
        public int idStudent { get; set; }
        public short idPredmet { get; set; }
        public string predmetNaziv { get; set; }
        public string indeksCalc { get; set; }
        public string imePrezime { get; set; }
        public byte? ocena { get; set; }
        public DateTime? ispitDatum { get; set; }
    }
}
