using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class DataBaseContext
    {

        public ICollection<Company> GetAllCompanies()
        {
            //TODO(R): Change mookup data
            return new List<Company>()
            {
                new Company()
                {
                    Date = DateTime.Today.AddDays(-3),
                    Name = "Company1",
                    SocialObject = "SocialObject1",
                    Location = "Leon"
                },
                new Company()
                {
                    Date = DateTime.Today.AddDays(-2),
                    Name = "Company2",
                    SocialObject = "SocialObject2",
                    Location = "Asturias"
                },
                new Company()
                {
                    Date = DateTime.Today.AddDays(-1),
                    Name = "Company3",
                    SocialObject = "SocialObject3",
                    Location = "Galicia"
                },
            };
        }

        public ICollection<Company> GetCompaniesByDate(DateTime start, DateTime end)
        {
            return GetAllCompanies().Where(c => c.Date.Date >= start.Date && c.Date.Date <= end.Date).ToList();
        }

        public ICollection<Company> GetCompaniesByNameOrSocialObject(string searchText)
        {
            var lowerSearchText = searchText.ToLower();
            return GetAllCompanies().Where(c => c.Name.ToLower().Contains(lowerSearchText) ||
                                                c.SocialObject.ToLower().Contains(lowerSearchText))
                                    .ToList();
        }

        public ICollection<Company> GetCompaniesByLocation(string location)
        {
            var lowerLocation = location.ToLower();
            return GetAllCompanies().Where(c => c.Location.ToLower() == lowerLocation).ToList();
        }

        public ICollection<SyncRegistry> GetAllSyncRegistries()
        {
            return new List<SyncRegistry>()
            { 
                new SyncRegistry()
                {
                    Date = DateTime.Today.AddDays(-3),
                    Text = "Albacete"
                },
                new SyncRegistry()
                {
                    Date = DateTime.Today.AddDays(-3),
                    Text = "Cuenca"
                },
                new SyncRegistry()
                {
                    Date = DateTime.Today.AddDays(-2),
                    Text = "Albacete"
                },
                new SyncRegistry()
                {
                    Date = DateTime.Today.AddDays(-1),
                    Text = "Cuenca"
                },
            };
        }
    }
}
