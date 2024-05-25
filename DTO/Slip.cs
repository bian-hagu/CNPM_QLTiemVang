using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemVang.DTO
{
    class Slip
    {

        private string iD;
        public string ID { get => iD; set => iD=value; }

        private DateTime date;
        public DateTime Date { get => date; set => date=value; }

        private string product;
    }
}
