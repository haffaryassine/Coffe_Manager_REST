using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cofe_Manager_.Helper
{
    public class Util
    {

        public static Int32  Get_new_id_badge()

        {
            DateTime aDate = DateTime.Now;
            Random Rnd = new Random();
            String Id_badge = Rnd.Next(100, 999).ToString() + aDate.ToString("MMddyy");
            return Int32.Parse(Id_badge);
        }

    }
}