using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cofe_Manager_.Models
{
    public class Boisson
    {
        public int Id { get; set; }
        public String Libelle { get; set; }
        public int Qte_sucre_recommander { get; set; }
    }
}