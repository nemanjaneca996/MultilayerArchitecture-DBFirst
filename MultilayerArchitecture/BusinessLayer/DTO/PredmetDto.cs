using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayerArchitecture.BusinessLayer.DTO
{
    public class PredmetDto : BaseDto
    {
        public short idPredmet { get; set; }
        public string predmetNaziv { get; set; }
    }
}
