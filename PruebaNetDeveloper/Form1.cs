using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaNetDeveloper
{
    public partial class Form1 : Form
    {

        CompaniesService companiesService;
        SyncRegistriesService syncRegistriesService;
        DateTime? startFilterDate;
        DateTime? endFilterDate;
        List<string> locationsList;

        public Form1()
        {
            InitializeComponent();

            companiesService = new CompaniesService();
            syncRegistriesService = new SyncRegistriesService();

            dgvCompaniesList.DataSource = companiesService.GetAllCompanies();
            dgvCompaniesList.Refresh();

            this.mcFilterCalendar.BoldedDates = syncRegistriesService.GetAllSyncRegistries().Select(sr => sr.Date).ToArray();

            this.locationsList = new List<string>() { string.Empty };
            this.locationsList.AddRange(companiesService.GetLocations().ToList());
            this.cbLocations.DataSource = this.locationsList;
            this.cbLocations.Refresh();
        }

        public void ApplyFilters()
        {
            var companiesList = companiesService.GetAllCompanies();
            if(startFilterDate.HasValue && endFilterDate.HasValue)
            {
                var companiesByDate = companiesService.GetCompaniesByDate(startFilterDate.Value, endFilterDate.Value);
                companiesList = companiesList.Where(c => companiesByDate.Select(s => s.Name).Contains(c.Name)).ToList();
            }

            if(!string.IsNullOrEmpty(tbNameObjectFilter.Text))
            {
                var companiesByName = companiesService.GetCompaniesByNameOrSocialObject(tbNameObjectFilter.Text);
                companiesList = companiesList.Where(c => companiesByName.Select(s => s.Name).Contains(c.Name)).ToList();
            }

            if (!string.IsNullOrEmpty(cbLocations.SelectedValue.ToString()))
            {
                var companiesByLocation = companiesService.GetCompaniesByLocation(cbLocations.SelectedValue.ToString());
                companiesList = companiesList.Where(c => companiesByLocation.Select(s => s.Name).Contains(c.Name)).ToList();
            }

            dgvCompaniesList.DataSource = companiesList;
            dgvCompaniesList.Refresh();
        }

        public void ClearFilters()
        {
            mcFilterCalendar.SelectionRange = new SelectionRange(DateTime.Today, DateTime.Today);
            startFilterDate = null;
            endFilterDate = null;
            tbNameObjectFilter.Text = string.Empty;
            cbLocations.SelectedIndex = 0;
            ApplyFilters();
        }

        private void mcFilterCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            startFilterDate = e.Start.Date;
            endFilterDate = e.End.Date;
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

        private void cbLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void btnDownloadInfo_Click(object sender, EventArgs e)
        {
            lblDownloadLog.Text = "Downloading";

            var downloadingDate = mcFilterCalendar.SelectionRange.Start.Date;

            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            webClient.DownloadFileAsync(new Uri(string.Format(ConfigurationManager.AppSettings["BORMEUrl"], downloadingDate.Year, downloadingDate.Month, downloadingDate.Day)),
                Path.Combine(ConfigurationManager.AppSettings["DownloadedPDFRoute"], "\\" + downloadingDate.ToShortDateString()));
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            lblDownloadLog.Text = string.Format("Downloading {0} %", e.ProgressPercentage);
            pbDownload.Value = e.ProgressPercentage;
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            lblDownloadLog.Text = "Completed";
        }
    }

    public class CompanyListItem
    {
        public DateTime Date { get; set; }

        public string Name { get; set; }

        public string SocialObject { get; set; }
    }
}
