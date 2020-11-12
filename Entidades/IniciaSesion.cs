using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class IniciaSesion
    {

        public String username { get; set; }

        public String clave { get; set; }

        public int id { get; set; }



        public IniciaSesion()
        {
            username = string.Empty;
            clave = string.Empty;
            id = 0;
        }


 //Se elimino recurso que no servía 



    }
}
