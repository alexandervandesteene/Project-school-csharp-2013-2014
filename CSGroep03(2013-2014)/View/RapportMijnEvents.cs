using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace CSGroep03_2013_2014_
{
    public partial class RapportMijnEvents : Form
    {
        User gebruiker;
        ReportParameter user;

        public RapportMijnEvents(User gebruiker)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;
            setTabs();
            user = new ReportParameter("Gebruiker", gebruiker.UserName);
        }

        #region events
        private void reportViewer1_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.SetParameters(user);
            this.eventsListTableAdapter.FillByGebruikersnaam(this.cSGroep03DataSet.EventsList, gebruiker.UserName);
            this.reportViewer1.RefreshReport();
        }
        private void reportViewer2_Load(object sender, EventArgs e)
        {
            reportViewer2.LocalReport.SetParameters(user);
            this.eventOrganisatorTableAdapter.Fill(this.cSGroep03DataSet.EventOrganisator, gebruiker.UserName);
            this.reportViewer2.RefreshReport();
        }
        #endregion events

        #region methods
        private void setTabs()
        {
            tabVolgen.Text = "Events die " + gebruiker.UserName + " volgt";
            tabOrganiseren.Text = "Events die " + gebruiker.UserName + " organiseert";
        }
        #endregion methods
        

        

    }
}
