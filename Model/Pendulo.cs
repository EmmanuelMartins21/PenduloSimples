using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenduloSimples.Model
{
    public class Pendulo
    {
        [Key]
        public int PenduloId { get; }

        public float? Massa { get; set; }
        public float ComprimentoFio { get; set; }
    }
}
