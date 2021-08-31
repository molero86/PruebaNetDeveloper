using DataAccess;
using System.Collections.Generic;

namespace Domain
{
    public class SyncRegistriesService
    {
        private DataBaseContext dbContext { get; set; }

        public SyncRegistriesService()
        {
            this.dbContext = new DataBaseContext();
        }

        public ICollection<SyncRegistry> GetAllSyncRegistries()
        {
            return this.dbContext.GetAllSyncRegistries();
        }
    }
}
