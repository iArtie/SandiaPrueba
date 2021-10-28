using ExamenParcial.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcial
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ActivoFijo
    {
        [JsonProperty]
        public int Id { get; set; }
        [JsonProperty]
        public string CodigoActivo { get; set; }
        [JsonProperty]
        public string NombreActivo { get; set; }
        [JsonProperty]
        public string Descripcion { get; set; }
        [JsonProperty]
        public decimal ValorActivo { get; set; }
        [JsonProperty]
        public DateTime FechaAdquisicion { get; set; }
        [JsonProperty]
        public TipoActivoFijo TipoActivoFijo { get; set; }
        
    }
}
