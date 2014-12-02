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
    public partial class Registreren : Form
    {
        Controller controller;
        User registrerenUser;

        public Registreren()
        {
            InitializeComponent();
            controller = new Controller();
            txtGebruikersnaamRegistreren.Focus();
        }
        
        #region properties
        public string Gebruikersnaam
        {
            get { return txtGebruikersnaamRegistreren.Text; }
        }
        public string Wachtwoord
        {
            get { return txtWachtwoordRegistreren.Text; }
        }
        public User RegistrerenUser
        {
            get { return registrerenUser; }
        }
        #endregion

        #region events
        private void btnRegistreren_Click(object sender, EventArgs e)
        {
            try
            {
                actieRegistreren();
            }
            catch (SqlException)
            {
                MessageBox.Show("Geen verbinding met de databank!", "SQL-Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAnnulerenRegistreren_Click(object sender, EventArgs e)
        {
            actieAnnuleren();
        }
        private void txtGebruikersnaamRegistreren_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txtWachtwoordRegistreren.Focus();
            if (e.KeyChar == (char)Keys.Escape)
                actieAnnuleren();
        }
        private void txtWachtwoordRegistreren_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txtWachtwoordRegistreren2.Focus();
            if (e.KeyChar == (char)Keys.Escape)
                actieAnnuleren();
        }
        private void txtWachtwoordRegistreren2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                actieRegistreren();
            if (e.KeyChar == (char)Keys.Escape)
                actieAnnuleren();
        }

        #endregion

        #region methods
        private bool checkDuplicatieGebruikersnaam()
        {
            return controller.checkDuplicatieGebruikersnaam(Gebruikersnaam);
        }
        private void actieRegistreren()
        {
            if(txtWachtwoordRegistreren.Text == txtWachtwoordRegistreren2.Text)
            {
                if (txtWachtwoordRegistreren.Text.Length >= 6 && txtWachtwoordRegistreren.Text.Length <= 25)
                {
                    if (checkDuplicatieGebruikersnaam())
                    {
                        controller.addUser(Gebruikersnaam, Wachtwoord);
                        DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                    else
                    {
                        errorPassword.Clear();
                        errorDuplicatie.SetError(txtGebruikersnaamRegistreren, "Gebruikersnaam bestaat reeds. Probeer opnieuw");
                        txtWachtwoordRegistreren.Clear();
                        txtWachtwoordRegistreren2.Clear();
                    }
                }
                else
                {
                    errorDuplicatie.Clear();
                    errorPassword.Clear();
                    errorPassword.SetError(txtWachtwoordRegistreren, "Gebruik een wachtwoord van minimaal 6 tekens en maximaal 25 tekens");
                    txtWachtwoordRegistreren.Clear();
                    txtWachtwoordRegistreren2.Clear();
                }
            }
            else
            {
                errorDuplicatie.Clear();
                errorPassword.Clear();
                errorPassword.SetError(txtWachtwoordRegistreren2, "Wachtwoorden komen niet overeen! Probeer opnieuw");
                txtWachtwoordRegistreren.Clear();
                txtWachtwoordRegistreren2.Clear();
            }
        }
        private void actieAnnuleren()
        {
            Close();
        }
        #endregion

        
    }
}