using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BandCentral.Models
{
    public class SearchViewModel
    {
        private BCEntities context = new BCEntities();
        private string UserID;
            public SearchViewModel(string UserID)
        {
            this.UserID = UserID;
        }

        public void AddBand(string bandName)
        {
            Band band = context.Bands.Add(new Band { BandName = bandName });
            context.SaveChanges();
            context.AspNetUsers.Where(u => u.Id == UserID).FirstOrDefault().Bands.Add(band);
            context.SaveChanges();
        }

        
    }
}