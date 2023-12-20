using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    internal class TblServiciosMICI
    {
        [Key]
        public int id_servicio { get; set; }

        public string Nombre { get; set; }
        public int Anio { get; set; }
        public string URL { get; set; }
        public int Estado { get; set; }
        public int Trimestre { get; set; }
        public string Layer { get; set; }
        public int IdLayer { get; set; }
        public string RutaRaster { get; set; }

    }
}
