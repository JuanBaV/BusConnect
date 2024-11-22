using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Avisos
    {
        public string titulo { get; set; }

        public string descripcion { get; set; }
        public DateTime inicio { get; set; }
        public DateTime fin { get; set; }
        public int linea { get; set; }
    }
}
