using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class CompaniesService
    {
        private DataBaseContext dbContext { get; set; }

        public CompaniesService()
        {
            this.dbContext = new DataBaseContext();        
        }

        public ICollection<Company> GetAllCompanies()
        {
            return this.dbContext.GetAllCompanies();
        }

        public ICollection<Company> GetCompaniesByDate(DateTime start, DateTime end)
        {
            return dbContext.GetCompaniesByDate(start, end);
        }

        public ICollection<Company> GetCompaniesByNameOrSocialObject(string searchText)
        {
            return dbContext.GetCompaniesByNameOrSocialObject(searchText);
        }

        public ICollection<Company> GetCompaniesByLocation(string location)
        {
            return dbContext.GetCompaniesByLocation(location);
        }

        public ICollection<string> GetLocations()
        {
            return dbContext.GetAllCompanies().Select(c => c.Location).Distinct().ToList();
        }

    }
}
