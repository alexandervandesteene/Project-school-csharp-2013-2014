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
    public partial class Beginscherm : Form
    {
        string gebruikersnaam = "";
        User ingelogdeUser;
        Controller controller;
        Keuze keuze;

        #region Constructor
        public Beginscherm()
        {
            InitializeComponent();
            btnUitschrijven.Hide();
            btnInschrijven.Hide();
            controller = new Controller();
            keuze = Keuze.vrij;
            try
            {
                VulListboxVrij();
                pnlStatus.Show();
            }
            catch (SqlException)
            {
                this.Close();
                MessageBox.Show("Geen verbinding met de databank!", "SQL-Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //lbxEvents.Items.Add("-----------------------Kan geen Events ophalen uit de databank ----------------------");
            }
        }
        #endregion 

        #region events
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void registrerenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Registreren registratie = new Registreren();
                registratie.ShowDialog();
            }
            catch (SqlException)
            {
                MessageBox.Show("Geen verbinding met de databank!", "SQL-Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void inloggenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Inloggen inloggen = new Inloggen();
                if (inloggen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ingelogdeUser = inloggen.IngelogdeUser;
                    gebruikersnaam = ingelogdeUser.UserName;
                    Text += string.Format(" - gebruiker: {0}", ingelogdeUser.UserName);
                    inloggenToolStripMenuItem.Enabled = false;
                    uitloggenToolStripMenuItem.Enabled = true;
                    aanmakenToolStripMenuItem.Enabled = true;
                    mijnEventsToolStripMenuItem.Enabled = true;
                    mijnEventsToolStripMenuItemRapport.Enabled = true;
                    registrerenToolStripMenuItem.Enabled = false;
                    wachtwoordToolStripMenuItem.Enabled = true;
                    if (rndToekomst.Checked == true)
                    {
                        btnInschrijven.Show();
                        btnUitschrijven.Show();
                        btnInschrijven.Enabled = false;
                        btnUitschrijven.Enabled = false;
                    }
                    if (rndToekomst.Checked == true && rndNietVolzet.Checked == true && lbxEvents.SelectedIndex != -1)
                    {
                        List<Event> userEvents = controller.leesMijnEvents(ingelogdeUser);
                        btnInschrijven.Enabled = true;
                        btnUitschrijven.Enabled = true;
                        if (userEvents.Contains(lbxEvents.SelectedItem))
                            btnInschrijven.Enabled = false;
                        else
                            btnUitschrijven.Enabled = false;
                    }
                    if (rndToekomst.Checked == true && rndVolzet.Checked == true)
                        btnInschrijven.Hide();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Geen verbinding met de databank!", "SQL-Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void aanmakenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aanmaken aanmaken = new Aanmaken(ingelogdeUser);
            if (aanmaken.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (rndNietVolzet.Checked == true)
                    VulListboxVrij();
                if (rndVolzet.Checked == true)
                    VulListoxVolzet();
                if (rndVerleden.Checked == true)
                    VulListboxVerleden();
            }
        }
        private void uitloggenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text = "IT events";
            btnInschrijven.Hide();
            btnUitschrijven.Hide();
            gebruikersnaam = "";
            inloggenToolStripMenuItem.Enabled = true;
            uitloggenToolStripMenuItem.Enabled = false;
            aanmakenToolStripMenuItem.Enabled = false;
            mijnEventsToolStripMenuItem.Enabled = false;
            mijnEventsToolStripMenuItemRapport.Enabled = false;
            registrerenToolStripMenuItem.Enabled = true;
            wachtwoordToolStripMenuItem.Enabled = false;
        }
        private void mijnEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gebruikersnaam != "")
            {
                MijnEvents mijnEvenementen = new MijnEvents(ingelogdeUser);
                mijnEvenementen.ShowDialog();
            }
        }
        private void statischeInformatieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RapportInfo form = new RapportInfo();
            form.ShowDialog();
        }
        private void mijnEventsToolStripMenuRapport_Click(object sender, EventArgs e)
        {
            RapportMijnEvents form = new RapportMijnEvents(ingelogdeUser);
            form.ShowDialog();
        }
        private void toekomstigeEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RapportToekomst form = new RapportToekomst();
            form.ShowDialog();
        }
        private void wachtwoordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WachtwoordWijzigen form = new WachtwoordWijzigen(ingelogdeUser);
            form.ShowDialog();
        }

        private void rndToekomst_CheckedChanged(object sender, EventArgs e)
        {
            lbxEvents.Items.Clear(); //duplicate code??
            btnInschrijven.Enabled = false;
            btnUitschrijven.Enabled = false;
            try
            {
                if (rndNietVolzet.Checked == true)
                    VulListboxVrij();
                else
                    VulListoxVolzet();
            }
            catch (SqlException)
            {
                MessageBox.Show("Geen verbinding met de databank!", "SQL-Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbxEvents.Items.Add("-----------------------Kan geen Events ophalen uit de databank ----------------------");
            }
            finally
            {
                if (gebruikersnaam != "" && rndToekomst.Checked == true)
                {
                    if (rndVolzet.Checked == true)
                        btnInschrijven.Hide();
                    else
                        btnInschrijven.Show();
                    btnUitschrijven.Show();
                    pnlStatus.Show();
                }
                if (gebruikersnaam != "" && rndToekomst.Checked == false)
                {
                    btnInschrijven.Hide();
                    btnUitschrijven.Hide();
                    pnlStatus.Hide();
                }
                if (gebruikersnaam == "" && rndToekomst.Checked == true)
                    pnlStatus.Show();
                if (gebruikersnaam == "" && rndToekomst.Checked == false)
                    pnlStatus.Hide();
            }

        }
        private void rndVolzet_CheckedChanged(object sender, EventArgs e)
        {
            keuze = Keuze.volzet;
            lbxEvents.Items.Clear();
            btnInschrijven.Enabled = false;
            btnUitschrijven.Enabled = false;
            btnInschrijven.Hide();
            try
            {
                VulListoxVolzet();
                keuze = Keuze.volzet;
                if (rndVolzet.Checked == true)
                {
                    keuze = Keuze.volzet;
                    VulListoxVolzet();
                }
                else
                {
                    lbxEvents.Items.Clear();
                    keuze = Keuze.niets;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Geen verbinding met de databank!", "SQL-Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbxEvents.Items.Add("-----------------------Kan geen Events ophalen uit de databank ----------------------");
            }
        }
        private void rndVerleden_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rndVerleden.Checked == true)
                {
                    VulListboxVerleden();
                    keuze = Keuze.verleden;
                }
                else
                {
                    lbxEvents.Items.Clear();
                    keuze = Keuze.niets;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Geen verbinding met de databank!", "SQL-Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbxEvents.Items.Add("-----------------------Kan geen Events ophalen uit de databank ----------------------");
            }
        }
        private void rndNietVolzet_CheckedChanged(object sender, EventArgs e)
        {
            btnInschrijven.Enabled = false;
            btnUitschrijven.Enabled = false;
            if (gebruikersnaam != "")
            {
                btnInschrijven.Show();
                btnUitschrijven.Show();
            }

            lbxEvents.Items.Clear();
            try
            {
                if (rndNietVolzet.Checked == true)
                {
                    VulListboxVrij();
                    keuze = Keuze.vrij;
                }
                else
                {
                    lbxEvents.Items.Clear();
                    keuze = Keuze.niets;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Geen verbinding met de databank!", "SQL-Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbxEvents.Items.Add("-----------------------Kan geen Events ophalen uit de databank ----------------------");
            }
        }

        private void lbxEvents_DoubleClick(object sender, EventArgs e)
        {
            Info info;
            if (gebruikersnaam != "")
                info = new Info(((Event)lbxEvents.SelectedItem), ingelogdeUser, keuze);
            else
                info = new Info(((Event)lbxEvents.SelectedItem), gebruikersnaam, keuze);

            if (info.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbxEvents.Items.Clear();
                btnUitschrijven.Enabled = false;
                btnInschrijven.Enabled = false;
                try
                {
                    if (rndNietVolzet.Checked == true)
                        VulListboxVrij();
                    if (rndVolzet.Checked == true)
                        VulListoxVolzet();
                    if (rndVerleden.Checked == true)
                        VulListboxVerleden();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Geen verbinding met de databank!", "SQL-Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lbxEvents.Items.Add("-----------------------Kan geen Events ophalen uit de databank ----------------------");
                }
            }
        }
        private void lbxEvents_Click(object sender, EventArgs e)
        {
            try
            {
                if (gebruikersnaam != "")
                {
                    List<Event> userEvents = controller.leesMijnEvents(ingelogdeUser);
                    btnUitschrijven.Enabled = true;
                    btnInschrijven.Enabled = true;
                    if (userEvents.Contains(lbxEvents.SelectedItem))
                    {
                        btnUitschrijven.Enabled = true;
                        btnInschrijven.Enabled = false;
                    }
                    else
                    {
                        btnUitschrijven.Enabled = false;
                        btnInschrijven.Enabled = true;
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Geen verbinding met de databank!", "SQL-Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbxEvents.Items.Add("-----------------------Kan geen Events ophalen uit de databank ----------------------");
            }
        }
        
        private void btnInschrijven_Click(object sender, EventArgs e)
        {
            try
            {
                SchrijfIn();
            }
            catch (SqlException)
            {
                MessageBox.Show("Geen verbinding met de databank!", "SQL-Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbxEvents.Items.Add("-----------------------Kan geen Events ophalen uit de databank ----------------------");
            }
            
        }
        private void btnUitschrijven_Click(object sender, EventArgs e)
        {
            try
            {
                SchrijfUit();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Geen verbinding met de databank!", "SQL-Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbxEvents.Items.Add("-----------------------Kan geen Events ophalen uit de databank ----------------------");
            }
        }

        #endregion events

        #region methods
        private void VulListboxVerleden()
        {

            List<Event> lijstevents = controller.leesEventsverleden();
            lbxEvents.Items.Clear();
            for (int i = 0; i < lijstevents.Count; i++)
                lbxEvents.Items.Add(lijstevents[i]);
        }
        private void VulListboxVrij()
        {
            List<Event> lijstevents = controller.leesEventsToekomstvrij();
            lbxEvents.Items.Clear();
            for (int i = 0; i < lijstevents.Count; i++)
                lbxEvents.Items.Add(lijstevents[i]);
        }
        private void VulListoxVolzet()
        {
            List<Event> lijstevents = controller.leesEventsToekomstVolzet();
            lbxEvents.Items.Clear();
            for (int i = 0; i < lijstevents.Count; i++)
                lbxEvents.Items.Add(lijstevents[i]);
        }

        private void SchrijfUit()
        {
            Event evt = (Event)lbxEvents.SelectedItem;
            controller.VerwijderEventFromUser(evt, ingelogdeUser);
            controller.VerminderAantalInschrijvingen(evt);
            if (rndNietVolzet.Checked == true)
                VulListboxVrij();
            else
                VulListoxVolzet();
            
            btnUitschrijven.Enabled = false;
        }
        private void SchrijfIn()
        {
            Event evt = (Event)lbxEvents.SelectedItem;
            evt = GetLatestInfoEvent(evt);
            if (AlreadySubscribed(ingelogdeUser, evt))
                MessageBox.Show("Je bent al ingeschreven voor dit Event!", "Dubbele inschrijving!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                if (IsEventFull(evt))
                    MessageBox.Show("Helaas! Dit event is ondertussen volzet!", "Event volzet!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    controller.Inschrijven(ingelogdeUser, evt);
                    controller.VermeerderAantalInschrijvingen(evt);
                }
            }
            btnInschrijven.Enabled = false;
            VulListboxVrij();
        }

        private bool AlreadySubscribed(User ingelogdeUser, Event evt)
        {
            return controller.AlreadySubscribed(ingelogdeUser, evt);
        }
        private bool IsEventFull(Event evt)
        {
            if (evt.Subscriptions >= evt.Maxsubscriptions)
                return true;
            else
                return false;
        }
        private Event GetLatestInfoEvent(Event evt)
        {
            return controller.GetLatestInfoEvent(evt);
        }

        #endregion methods

        
    }
}
