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
    public partial class Aanmaken : Form
    {
        Controller controller;
        User organisator;

        public Aanmaken(User org)
        {
            controller = new Controller();
            organisator = org;
            InitializeComponent();
            txtOrganisator.Text = org.UserName;
        }

        #region events
        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }
        private void btnAanmaken_Click(object sender, EventArgs e)
        {
            if (Controleergegevens())
            {
                try
                {
                    Event evt = MaakEventObject();
                    controller.NieuwEvent(evt);
                    MessageBox.Show("Event: " + evt.EventName + " aangemaakt!");
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                catch (SqlException)
                {
                    MessageBox.Show("Geen verbinding met de databank!", "SQL-Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        #endregion events

        #region methods
        private bool Controleergegevens()
        {
            bool oke = true;
            int max;
            if (txtMax.Text == "" || !Int32.TryParse(txtMax.Text, out max))
            {
                errorProvider1.SetError(txtMax, "Maximum aantal deelnemers moet een geheel getal zijn");
                oke = false;
            }
            else
                errorProvider1.SetError(txtMax, "");

            if (txtNaam.Text == "")
            {
                errorProvider1.SetError(txtNaam, "Naam moet ingevuld zijn");
                oke = false;
            }
            else
                errorProvider1.SetError(txtNaam, "");

            return oke;
        }
        private Event MaakEventObject()
        {
            int eventnr = 0;
            string eventnaam = txtNaam.Text;
            DateTime eventdate = dateTimePicker1.Value.Date;
            int subscriptions = 0;
            int maxsubscriptions = Int32.Parse(txtMax.Text);
            int org = organisator.UserID;

            Event e = new Event(eventnr, subscriptions, maxsubscriptions, eventnaam, eventdate, org);
            return e;
        }
        #endregion methods
    }
}
