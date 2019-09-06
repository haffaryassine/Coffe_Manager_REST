using Cofe_Manager_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Cofe_Manager_.Services;
using Cofe_Manager_.Data_acces;
namespace Cofe_Manager_.Controllers
{ 
    public class Cofe_Controller : ApiController
    {

        private BoissonDepot Boissondepot;

        public Cofe_Controller()
        {
            this.Boissondepot = new BoissonDepot();
        }

        public List<Boisson> Get()
        { 
            return Boissondepot.GetAllBoissons();  
        }
        [AcceptVerbs("GET", "POST")]
        public Selection addSelection(int id_badge, int id_boisson, Boolean mug,int qte_sucre)
        {          
            Selection s = new Selection();
            s.Id_badge = id_badge;            
            s.Id_boisson = id_boisson;
            s.Mug = mug;
            s.Qte_sucre = qte_sucre;           
            return SelectionDepot.Insert(s);
        }


        [AcceptVerbs("GET", "POST")]
        public Selection Get_Last_selection(int id_badge)
        {
            return SelectionDepot.Get_Last_selection(id_badge);
        }



        [AcceptVerbs("GET", "POST")]
        public int Insert_Badge(int id_badge)
        {
            return BadgeDepot.InsertBadge(id_badge);
        }

        [AcceptVerbs("GET", "POST")]
        public int GetBadge(int id_badge)
        {
            return BadgeDepot.GetBadge(id_badge);
        }


    }

}
