using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cofe_Manager_.Models
{
    public class Selection
    {

        public int Id { get; set; }
        public int Qte_sucre { get; set; }
        public int Id_boisson { get; set; }
        public int Id_badge { get; set; }       
        public Boolean Mug { get; set; }

    }
}