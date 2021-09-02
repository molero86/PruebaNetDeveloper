using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;

namespace DataAccess
{
    public class DataBaseContext : IDisposable
    {
        string currDirectory;
        string companiesFilePath;
        string registriesFilePath;

        private DataBaseContext()
        {
            //Read all files or create it
            currDirectory = Directory.GetCurrentDirectory();
            companiesFilePath = Path.Combine(currDirectory, ConfigurationManager.AppSettings["CompaniesFileName"]);
            registriesFilePath = Path.Combine(currDirectory, ConfigurationManager.AppSettings["RegistriesFileName"]);

            LoadData();

        }

        ~DataBaseContext()
        {
            SaveData();
        }

        private void LoadData()
        {
            if(File.Exists(companiesFilePath))
            {
                StreamReader sr = new StreamReader(companiesFilePath);

                string line;
                _companies = new List<Company>();

                while((line = sr.ReadLine()) != null)
                {
                    _companies.Add(new Company(line));
                }

                sr.Close();

            }
            if(File.Exists(registriesFilePath))
            {
                StreamReader sr = new StreamReader(registriesFilePath);

                string line;
                _registries = new List<SyncRegistry>();

                while ((line = sr.ReadLine()) != null)
                {
                    _registries.Add(new SyncRegistry(line));
                }

                sr.Close();
            }
        }

        private void SaveData()
        {
            if (_companies != null && _companies.Any())
            {
                if (!Directory.Exists(companiesFilePath))
                {
                    var directory = Directory.CreateDirectory(string.Join("\\",companiesFilePath.Replace("/","\\").Split("\\").SkipLast(1)));
                }

                StreamWriter sw = new StreamWriter(companiesFilePath, false);

                foreach (var company in _companies)
                {
                    sw.WriteLine(company.ToString());
                }

                sw.Flush();
                sw.Close();
            }
            if (_registries != null && _registries.Any())
            {
                if (!Directory.Exists(registriesFilePath))
                {
                    var directory = Directory.CreateDirectory(string.Join("\\", registriesFilePath.Replace("/", "\\").Split("\\").SkipLast(1)));
                }

                StreamWriter sw = new StreamWriter(registriesFilePath, false);

                foreach (var registry in _registries)
                {
                    sw.WriteLine(registry.ToString());
                }

                sw.Flush();
                sw.Close();
            }
        }

        private static DataBaseContext _instance;
        public static DataBaseContext GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DataBaseContext();
            }
            return _instance;
        }

        private List<Company> _companies { get; set; }
        private List<SyncRegistry> _registries { get; set; }
        private List<string> _locations { get; set; }

        #region Methods

        #region Companies

        public ICollection<Company> GetAllCompanies()
        {
            //TODO(R): Change mookup data
            if (_companies == null)
            {
                _companies = new List<Company>()
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

            return _companies;
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

        #endregion

        #region Registries
        
        public ICollection<SyncRegistry> GetAllSyncRegistries()
        {
            //TODO(R): Quitar mookup data
            if (_registries == null)
            {
                _registries = new List<SyncRegistry>()
                {
                    new SyncRegistry()
                    {
                        Date = DateTime.Today.AddDays(-3),
                        Text = "Leon"
                    },
                    new SyncRegistry()
                    {
                        Date = DateTime.Today.AddDays(-3),
                        Text = "Asturias"
                    },
                    new SyncRegistry()
                    {
                        Date = DateTime.Today.AddDays(-2),
                        Text = "Leon"
                    },
                    new SyncRegistry()
                    {
                        Date = DateTime.Today.AddDays(-1),
                        Text = "Galicia"
                    },
                };
            }
            return _registries;
        }

        #endregion

        #endregion

        public void Dispose()
        {
            SaveData();

            //((IDisposable)_instance).Dispose();
        }
    }
}
