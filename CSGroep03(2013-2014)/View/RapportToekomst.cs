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
    public partial class RapportToekomst : Form
    {
        public RapportToekomst()
        {
            InitializeComponent();
        }

        private void RapportToekomst_Load(object sender, EventArgs e)
        {

            ReportParameter datum = new ReportParameter("Datum", DateTime.Today.Date.ToShortDateString());
            this.reportViewer1.LocalReport.SetParameters(datum);
            this.eventsListTableAdapter.FillByToekomstigeEnVrijEvents(this.cSGroep03DataSet.EventsList);
            this.reportViewer1.RefreshReport();
        }
    }
}
