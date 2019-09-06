using Cofe_Manager_.Data_acces;
using Cofe_Manager_.Helper;
using Cofe_Manager_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cofe_Manager_.Services
{
    public class SelectionDepot
    {
        public static Selection Insert(Selection s)
        {
            Cofe_Manager_.Data_acces.B_machinecafeEntities ctx = new B_machinecafeEntities();          
            if (s.Id_badge == 0)
            {
                s.Id_badge = Util.Get_new_id_badge();
                BadgeDepot.InsertBadge(s.Id_badge);
            } 

            T_selection ss = new T_selection();
            ss.id_badge = s.Id_badge;
            ss.id_boisson = s.Id_boisson;
            ss.mug = s.Mug;
            ss.qte_sucre = s.Qte_sucre;
            ctx.T_selection.Add(ss);
            ctx.SaveChanges();
            s.Id = ss.id_selection;
            return s;
        }

        public static Selection Get_Last_selection(int Id_badge)
        {
            Cofe_Manager_.Data_acces.B_machinecafeEntities ctx = new B_machinecafeEntities();
            Selection NSelec = new Selection();
            try
            {
                T_selection Selec = (from c in ctx.T_selection where c.id_badge == Id_badge orderby c.id_selection descending select c).First();
                NSelec.Id = Selec.id_selection;
                NSelec.Id_badge = Selec.id_badge.Value;
                NSelec.Id_boisson = Selec.id_boisson.Value;
                NSelec.Mug = Selec.mug.Value;
                NSelec.Qte_sucre = Selec.qte_sucre.Value;

            }
            catch (Exception)
            {
                return null;
            }


            return NSelec;

        }

    }
}