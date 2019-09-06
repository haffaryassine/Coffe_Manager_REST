using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cofe_Manager_.Models;
using Cofe_Manager_.Data_acces;

namespace Cofe_Manager_.Services
{

    public class BoissonDepot
    {

        public List<Boisson> GetAllBoissons()
        {
            Cofe_Manager_.Data_acces.B_machinecafeEntities ctx = new B_machinecafeEntities();
            T_boisson[] tb=  ctx.T_boisson.ToArray();
            List<Boisson> tbs = new List<Boisson>();
            for (int i = 0; i < tb.Length; i++)
            {
                Boisson b = new Boisson();
                b.Id = tb[i].id_boisson;
                b.Libelle = tb[i].libelle_b;
                b.Qte_sucre_recommander = tb[i].Qte_sucre_recommandation.Value;
                tbs.Add(b);
            }

            return tbs;
        }
       

    }
}