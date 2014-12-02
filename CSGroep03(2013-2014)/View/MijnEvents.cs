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

namespace CSGroep03_2013_2014_
{
    public partial class MijnEvents : Form
    {
        User ingelogdeUser;
        Controller controller;

        public MijnEvents(User user)
        {
            ingelogdeUser = user;
            controller = new Controller();
            InitializeComponent();
            Text = string.Format(" Events van {0}", ingelogdeUser.UserName);
            try
            {
                VulListBoxMijnEvents();
            }
            catch (SqlException)
            {
                MessageBox.Show("Geen verbinding met de databank!", "SQL-Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region events
        private void lbxMyEvents_DoubleClick(object sender, EventArgs e)
        {
            Info info = new Info(((Event)lbxMyEvents.SelectedItem), ingelogdeUser, Keuze.volzet);
            info.ShowDialog();
            VulListBoxMijnEvents();
        }
        private void lbxMyEvents_Click(object sender, EventArgs e)
        {
            btnVerwijder.Enabled = true;
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            try
            {
                SchrijfUit();
                VulListBoxMijnEvents();
            }
            catch (SqlException)
            {
                MessageBox.Show("Geen verbinding met de databank!", "SQL-Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnVerwijder.Enabled = false;
            }
        }
        #endregion events

        #region methods
        private void VulListBoxMijnEvents()
        {
            List<Event> lijstevents = controller.leesMijnEvents(ingelogdeUser);
            lbxMyEvents.Items.Clear();
            for (int i = 0; i < lijstevents.Count; i++)
                lbxMyEvents.Items.Add(lijstevents[i]);
        }
        private void SchrijfUit()
        {
            Event evt = (Event)lbxMyEvents.SelectedItem;
            controller.VerwijderEventFromUser(evt, ingelogdeUser);
            controller.VermeerderAantalInschrijvingen(evt);
        }
        #endregion methods

    }
}
