using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaNetDeveloper
{
    public partial class Form1 : Form
    {

        CompaniesService companiesService;
        SyncRegistriesService syncRegistriesService;

        public Form1()
        {
            InitializeComponent();

            companiesService = new CompaniesService();
            syncRegistriesService = new SyncRegistriesService();

            dgvCompaniesList.DataSource = companiesService.GetAllCompanies();
            dgvCompaniesList.Refresh();

            this.mcFilterCalendar.BoldedDates = syncRegistriesService.GetAllSyncRegistries().Select(sr => sr.Date).ToArray();
        }

        private void mcFilterCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            ApplyFilters();
        }

        public void ApplyFilters()
        {
            var companiesList = companiesService.GetAllCompanies();
            if(mcFilterCalendar.SelectionRange != null)
            {
                companiesList = companiesList.Intersect(companiesService.GetCompaniesByDate(mcFilterCalendar.SelectionRange.Start, mcFilterCalendar.SelectionRange.Start).AsEnumerable()).ToList();
            }

            if(!string.IsNullOrEmpty(tbNameObjectFilter.Text))
            {
                companiesList = companiesList.Intersect(companiesService.GetCompaniesByNameOrSocialObject(tbNameObjectFilter.Text).AsEnumerable()).ToList();
            }

            dgvCompaniesList.DataSource = companiesList;
            dgvCompaniesList.Refresh();
        }

        public void ClearFilters()
        {
            mcFilterCalendar.SelectionRange = null;
            tbNameObjectFilter.Text = string.Empty;
            ApplyFilters();
        }

        private void tbNameObjectFilter_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            ClearFilters();
        }
    }

    public class CompanyListItem
    {
        public DateTime Date { get; set; }

        public string Name { get; set; }

        public string SocialObject { get; set; }
    }
}
