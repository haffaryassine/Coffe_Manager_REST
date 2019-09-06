using Cofe_Manager_.Data_acces;
using Cofe_Manager_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cofe_Manager_.Services
{
    public class BadgeDepot
    {

        public static int InsertBadge(int badge)
        {
            Cofe_Manager_.Data_acces.B_machinecafeEntities ctx = new B_machinecafeEntities();
            T_badge bdg = new T_badge();
            bdg.id_badge = badge;           
            ctx.T_badge.Add(bdg);
            return ctx.SaveChanges();  
        }

        public static int GetBadge(int badge)
        {
            Cofe_Manager_.Data_acces.B_machinecafeEntities ctx = new B_machinecafeEntities();
            T_badge bdg = ctx.T_badge.Where(s => s.id_badge == badge).FirstOrDefault<T_badge>();
            if (bdg == null) return 0;           
            else return bdg.id_badge;
        }


    }
}