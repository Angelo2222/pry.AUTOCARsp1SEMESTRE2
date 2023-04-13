using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace pry.AUTOCARsp1SEMESTRE2
{
    internal class clsRepuestos
    {
        // propiedades
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string marca { get; set; }
        public int precio { get; set; }
        public string Origen { get; set; }

        //metodosd
        public string Consultar()
        {
            return "Código: " + codigo + "\nNombre: " + nombre + "\nMarca: " + marca + "\nPrecio: " + precio + "\nOrigen: " + Origen;
        }
    }
}
