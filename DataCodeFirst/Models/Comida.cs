using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCodeFirst.Models
{
    public class Comida
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public double Precio { get; set; }
        public int TiempoPreparacionMin { get; set; }
        public bool EsVegetariano { get; set; }
    }
}
