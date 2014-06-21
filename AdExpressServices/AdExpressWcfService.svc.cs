using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using AdExpressServices.DataContext;
using AdExpressServices.Models;

namespace AdExpressServices
{
    public class AddExpressWcfService : IAdExpressWcfService
    {


        public Ad AddAd(string title, string version)
        {
            using (var context = new AdExpressDBContext())
            {
                var ad = context.Ads.Add(new Ad { Title = title, Version = version });
                context.SaveChanges();
                return ad;
            }
        }

        public Ad[] GetAllAdsList()
        {
            using (var context = new AdExpressDBContext())
            {
                var query = (from a in context.Ads
                    orderby a.Title
                    select a).ToArray();

                return query;
            }

        }

        public Ad SaveAd(Ad ad)
        {
            using (var context = new AdExpressDBContext())
            {
                context.Set<Ad>().AddOrUpdate(ad); 
                context.SaveChanges();
                return ad;
            }
        }

        public void RemoveAd(Ad ad)
        {
            using (var context = new AdExpressDBContext())
            {
                var p = context.Ads.SingleOrDefault(x => x.ID == ad.ID);
                if (p == null)
                    return;
                context.Set<Ad>().Remove(p);
                context.SaveChanges();
            }

        }


        public Ad FindAd(int? id)
        {
            using (var context = new AdExpressDBContext())
            {
                return context.Ads.SingleOrDefault(ad => ad.ID == id);
            }

        }

        public Newspaper AddNewspaper(string name, string category)
        {
            using (var context = new AdExpressDBContext())
            {
                var newspaper = context.Newspapers.Add(new Newspaper {Name = name, Category = category});
                context.SaveChanges();
                return newspaper;
            }
        }

        public Newspaper[] GetAllNewspapers()
        {
            using (var context = new AdExpressDBContext())
            {
                Newspaper[] query = (from a in context.Newspapers
                    orderby a.Name
                    select a).ToArray();

                return query;

            }
        }

        public Newspaper FindNewspaper(int? id)
        {
            using (var context = new AdExpressDBContext())
            {
                return context.Newspapers.SingleOrDefault(n => n.ID == id);
            }

        }

        public Newspaper SaveNewspaper(Newspaper newspaper)
        {
            using (var context = new AdExpressDBContext())
            {
                context.Entry(newspaper).State = EntityState.Modified;
                context.SaveChanges();
                return newspaper;
            }

        }

        public void RemoveNewspaper(Newspaper newspaper)
        {
            using (var context = new AdExpressDBContext())
            {
                var p = context.Newspapers.SingleOrDefault(x => x.ID == newspaper.ID);
                if (p == null)
                    return;
                context.Newspapers.Remove(p);
                context.SaveChanges();
            }

        }

        public Association AddAssociation(DateTime startDateTime, DateTime endDateTime, int adID, int newspaperID)
        {
            var ad = FindAd(adID);
            var newspaper = FindNewspaper(newspaperID);
            if (ad == null || newspaper == null)
                return null;
            using (var context = new AdExpressDBContext())
            {
                var association =
                    context.Associations.Add(new Association
                    {
                        AdId = adID,
                        StartDateTime = startDateTime,
                        EndDateTime = endDateTime,
                        NewspaperId = newspaperID
                    });
                context.SaveChanges();
                return association;
            }
        }

        public Association[] GetAllAssociations()
        {
            using (var context = new AdExpressDBContext())
            {
                var query = (from a in context.Associations
                    orderby a.NewspaperId 
                    select a).ToArray();
                return query;
            }
        }

        public Association FindAssociation(int? id)
        {
            using (var context = new AdExpressDBContext())
            {
                return context.Associations.SingleOrDefault(ad => ad.ID == id);
            }
        }

        public Association SaveAssociation(Association association)
        {
            using (var context = new AdExpressDBContext())
            {
                context.Entry(association).State = EntityState.Modified;
                context.SaveChanges();
                return association;
            }
        }

        public void RemoveAssociation(Association  association)
        {
            using (var context = new AdExpressDBContext())
            {
                var p = context.Associations.SingleOrDefault(x => x.ID == association.ID);
                if (p == null)
                    return;
                context.Associations.Remove(p);
                context.SaveChanges();
            }

        }
    }


}

