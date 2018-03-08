using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Master1.Models
{
    public class SalariatModel
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NrCrt { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Functie { get; set; }
        public float SalarNegociat { get; set; }
        public float SalarRealizat { get; set; }
        public int Vechime { get; set; }
        public float Spor { get; set; }
        public float PremiiBrute { get; set; }
        public float Compensatie { get; set; }
        public float TotalBrut { get; set; }
        public float BrutImpozabil { get; set; }
    }
}