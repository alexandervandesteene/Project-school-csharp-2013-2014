using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CSGroep03_2013_2014_.Model;

namespace CSGroep03_2013_2014_
{
    public partial class RapportInfo : Form
    {
        public RapportInfo()
        {
            InitializeComponent();
        }

        private void RapportInfo_Load(object sender, EventArgs e)
        {
            try
            {
                this.eventsListTableAdapter.Fill(this.cSGroep03DataSet.EventsList);
                this.reportViewer1.RefreshReport();
            }
            catch (SqlException)
            {
                MessageBox.Show("Geen verbinding met de databank!", "SQL-Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
