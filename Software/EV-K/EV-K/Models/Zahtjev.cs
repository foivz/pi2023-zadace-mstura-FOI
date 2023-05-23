using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EV_K.Models {
    public class Zahtjev {
        public int Id { get; set; }
        public string Tip { get; set; }
        public string Date { get; set; }
        public string Razlog { get; set; }
    }
}
