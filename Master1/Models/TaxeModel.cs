using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Master1.Models
{
    public class TaxeModel
    {
        [Key]
        public int NrCrt { get; set; }
        public float Impozit { get; set; }
        public float Cas { get; set; }
        public float Somaj { get; set; }
        public float Sanatate { get; set; }
        public float Avans { get; set; }
        public float Retineri { get; set; }
        public float RestPlata { get; set; }
    }
}