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
    public partial class Inloggen : Form
    {
        Controller controller;
        User ingelogdeUser;

        public Inloggen()
        {
            InitializeComponent();
            controller = new Controller();
            txtGebruikersnaam.Focus();
        }

        #region properties
        public string Gebruikersnaam
        {
            get { return txtGebruikersnaam.Text; }
        }
        private string Wachtwoord
        {
            get { return txtWachtwoord.Text; }
        }
        public User IngelogdeUser
        {
            get { return ingelogdeUser; }
        }
        #endregion properties

        #region events
        private void btnInloggen_Click(object sender, EventArgs e)
        {
            try
            {
                actieInloggen();
            }
            catch (SqlException)
            {
                MessageBox.Show("Geen verbinding met de databank!", "SQL-Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            actieAnnuleren();
        }
        private void txtGebruikersnaam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txtWachtwoord.Focus();
            if (e.KeyChar == (char)Keys.Escape)
                actieAnnuleren();
        }
        private void txtWachtwoord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                actieInloggen();
            if (e.KeyChar == (char)Keys.Escape)
                actieAnnuleren();
        }
        #endregion events

        #region methods
        private bool checkGebruikersnaamEnWachtwoord()
        {
            return controller.checkGebruikersnaamEnWachtwoord(Gebruikersnaam,Wachtwoord);
        }
        private void actieInloggen()
        {
            if (checkGebruikersnaamEnWachtwoord())
            {
                ingelogdeUser = controller.getUser(Gebruikersnaam, Wachtwoord);
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                error.SetError(txtGebruikersnaam, "Gebruikersnaam en/of wachtwoord is/zijn verkeerd.Probeer opnieuw");
                txtWachtwoord.Clear();
            }
        }
        private void actieAnnuleren()
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        #endregion methods
    }
}
