using DataAccess;
using System;
using System.Collections.Generic;

namespace Domain
{
    public class SyncRegistriesService : IDisposable
    {
        private DataBaseContext dbContext { get; set; }

        public SyncRegistriesService()
        {
            this.dbContext = DataBaseContext.GetInstance();
        }

        public ICollection<SyncRegistry> GetAllSyncRegistries()
        {
            return this.dbContext.GetAllSyncRegistries();
        }

        public void Dispose()
        {
            ((IDisposable)dbContext).Dispose();
        }
    }
}
