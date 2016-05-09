using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BandCentral.Models
{
    public class FavoritesViewModel
    {
        //private static BCEntities context = new BCEntities();
        public List<Band> Favorites;
        public FavoritesViewModel(string userID)
        {
            Favorites = new BCEntities().AspNetUsers.Where(u => u.Id == userID).FirstOrDefault().Bands.ToList();
        }
    }
}