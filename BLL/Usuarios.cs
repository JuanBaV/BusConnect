using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Usuarios
    {
        public string ID { get; set; }

        public string Contraseña { get; set; }

        public int Role { get; set; }

        public byte[] imagen { get; set; }

        public int cod { get; set; }
    }
}
