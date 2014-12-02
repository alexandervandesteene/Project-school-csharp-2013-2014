namespace CSGroep03_2013_2014_
{
    partial class Beginscherm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuBeginscherm = new System.Windows.Forms.MenuStrip();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toekomstigeEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statischeInformatieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mijnEventsToolStripMenuItemRapport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aanmakenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mijnEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inloggenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uitloggenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.registrerenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wachtwoordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblEvenementen = new System.Windows.Forms.Label();
            this.grbEvenementen = new System.Windows.Forms.GroupBox();
            this.lblOrg = new System.Windows.Forms.Label();
            this.lblMaxSubscriptions = new System.Windows.Forms.Label();
            this.lblSubscriptions = new System.Windows.Forms.Label();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lbxEvents = new System.Windows.Forms.ListBox();
            this.rndVerleden = new System.Windows.Forms.RadioButton();
            this.rndToekomst = new System.Windows.Forms.RadioButton();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.rndNietVolzet = new System.Windows.Forms.RadioButton();
            this.rndVolzet = new System.Windows.Forms.RadioButton();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnUitschrijven = new System.Windows.Forms.Button();
            this.btnInschrijven = new System.Windows.Forms.Button();
            this.menuBeginscherm.SuspendLayout();
            this.grbEvenementen.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBeginscherm
            // 
            this.menuBeginscherm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem,
            this.optiesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuBeginscherm.Location = new System.Drawing.Point(0, 0);
            this.menuBeginscherm.Name = "menuBeginscherm";
            this.menuBeginscherm.Size = new System.Drawing.Size(924, 24);
            this.menuBeginscherm.TabIndex = 0;
            this.menuBeginscherm.Text = "menuStrip1";
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rapportToolStripMenuItem,
            this.toolStripSeparator1,
            this.aanmakenToolStripMenuItem,
            this.mijnEventsToolStripMenuItem,
            this.toolStripSeparator2,
            this.afsluitenToolStripMenuItem});
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.bestandToolStripMenuItem.Text = "Event";
            // 
            // rapportToolStripMenuItem
            // 
            this.rapportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toekomstigeEventsToolStripMenuItem,
            this.statischeInformatieToolStripMenuItem,
            this.toolStripSeparator3,
            this.mijnEventsToolStripMenuItemRapport});
            this.rapportToolStripMenuItem.Name = "rapportToolStripMenuItem";
            this.rapportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rapportToolStripMenuItem.Text = "Rapport";
            // 
            // toekomstigeEventsToolStripMenuItem
            // 
            this.toekomstigeEventsToolStripMenuItem.Name = "toekomstigeEventsToolStripMenuItem";
            this.toekomstigeEventsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.toekomstigeEventsToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.toekomstigeEventsToolStripMenuItem.Text = "Toekomstige events";
            this.toekomstigeEventsToolStripMenuItem.Click += new System.EventHandler(this.toekomstigeEventsToolStripMenuItem_Click);
            // 
            // statischeInformatieToolStripMenuItem
            // 
            this.statischeInformatieToolStripMenuItem.Name = "statischeInformatieToolStripMenuItem";
            this.statischeInformatieToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.statischeInformatieToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.statischeInformatieToolStripMenuItem.Text = "Statistische informatie";
            this.statischeInformatieToolStripMenuItem.Click += new System.EventHandler(this.statischeInformatieToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(228, 6);
            // 
            // mijnEventsToolStripMenuItemRapport
            // 
            this.mijnEventsToolStripMenuItemRapport.Enabled = false;
            this.mijnEventsToolStripMenuItemRapport.Name = "mijnEventsToolStripMenuItemRapport";
            this.mijnEventsToolStripMenuItemRapport.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.mijnEventsToolStripMenuItemRapport.Size = new System.Drawing.Size(231, 22);
            this.mijnEventsToolStripMenuItemRapport.Text = "Mijn events";
            this.mijnEventsToolStripMenuItemRapport.Click += new System.EventHandler(this.mijnEventsToolStripMenuRapport_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // aanmakenToolStripMenuItem
            // 
            this.aanmakenToolStripMenuItem.Enabled = false;
            this.aanmakenToolStripMenuItem.Name = "aanmakenToolStripMenuItem";
            this.aanmakenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.aanmakenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aanmakenToolStripMenuItem.Text = "Aanmaken";
            this.aanmakenToolStripMenuItem.Click += new System.EventHandler(this.aanmakenToolStripMenuItem_Click);
            // 
            // mijnEventsToolStripMenuItem
            // 
            this.mijnEventsToolStripMenuItem.Enabled = false;
            this.mijnEventsToolStripMenuItem.Name = "mijnEventsToolStripMenuItem";
            this.mijnEventsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.mijnEventsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mijnEventsToolStripMenuItem.Text = "Mijn Events";
            this.mijnEventsToolStripMenuItem.Click += new System.EventHandler(this.mijnEventsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.afsluitenToolStripMenuItem.Text = "Afsluiten";
            this.afsluitenToolStripMenuItem.Click += new System.EventHandler(this.afsluitenToolStripMenuItem_Click);
            // 
            // optiesToolStripMenuItem
            // 
            this.optiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inloggenToolStripMenuItem,
            this.uitloggenToolStripMenuItem,
            this.toolStripSeparator4,
            this.registrerenToolStripMenuItem,
            this.wachtwoordToolStripMenuItem});
            this.optiesToolStripMenuItem.Name = "optiesToolStripMenuItem";
            this.optiesToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.optiesToolStripMenuItem.Text = "Account";
            // 
            // inloggenToolStripMenuItem
            // 
            this.inloggenToolStripMenuItem.Name = "inloggenToolStripMenuItem";
            this.inloggenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.inloggenToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.inloggenToolStripMenuItem.Text = "Inloggen";
            this.inloggenToolStripMenuItem.Click += new System.EventHandler(this.inloggenToolStripMenuItem_Click);
            // 
            // uitloggenToolStripMenuItem
            // 
            this.uitloggenToolStripMenuItem.Enabled = false;
            this.uitloggenToolStripMenuItem.Name = "uitloggenToolStripMenuItem";
            this.uitloggenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.uitloggenToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.uitloggenToolStripMenuItem.Text = "Uitloggen";
            this.uitloggenToolStripMenuItem.Click += new System.EventHandler(this.uitloggenToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(227, 6);
            // 
            // registrerenToolStripMenuItem
            // 
            this.registrerenToolStripMenuItem.Name = "registrerenToolStripMenuItem";
            this.registrerenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.registrerenToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.registrerenToolStripMenuItem.Text = "Registereren";
            this.registrerenToolStripMenuItem.Click += new System.EventHandler(this.registrerenToolStripMenuItem_Click);
            // 
            // wachtwoordToolStripMenuItem
            // 
            this.wachtwoordToolStripMenuItem.Enabled = false;
            this.wachtwoordToolStripMenuItem.Name = "wachtwoordToolStripMenuItem";
            this.wachtwoordToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.wachtwoordToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.wachtwoordToolStripMenuItem.Text = "Wachtwoord wijzigen";
            this.wachtwoordToolStripMenuItem.Click += new System.EventHandler(this.wachtwoordToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblEvenementen
            // 
            this.lblEvenementen.AutoSize = true;
            this.lblEvenementen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvenementen.Location = new System.Drawing.Point(32, 49);
            this.lblEvenementen.Name = "lblEvenementen";
            this.lblEvenementen.Size = new System.Drawing.Size(140, 24);
            this.lblEvenementen.TabIndex = 1;
            this.lblEvenementen.Text = "Evenementen";
            // 
            // grbEvenementen
            // 
            this.grbEvenementen.Controls.Add(this.lblOrg);
            this.grbEvenementen.Controls.Add(this.lblMaxSubscriptions);
            this.grbEvenementen.Controls.Add(this.lblSubscriptions);
            this.grbEvenementen.Controls.Add(this.lblEventDate);
            this.grbEvenementen.Controls.Add(this.lblEventName);
            this.grbEvenementen.Controls.Add(this.lbxEvents);
            this.grbEvenementen.Location = new System.Drawing.Point(212, 37);
            this.grbEvenementen.Name = "grbEvenementen";
            this.grbEvenementen.Size = new System.Drawing.Size(700, 275);
            this.grbEvenementen.TabIndex = 2;
            this.grbEvenementen.TabStop = false;
            this.grbEvenementen.Text = "Lijst met evenementen";
            // 
            // lblOrg
            // 
            this.lblOrg.AutoSize = true;
            this.lblOrg.Location = new System.Drawing.Point(551, 20);
            this.lblOrg.Name = "lblOrg";
            this.lblOrg.Size = new System.Drawing.Size(61, 13);
            this.lblOrg.TabIndex = 5;
            this.lblOrg.Text = "Organisator";
            // 
            // lblMaxSubscriptions
            // 
            this.lblMaxSubscriptions.Location = new System.Drawing.Point(449, 20);
            this.lblMaxSubscriptions.Name = "lblMaxSubscriptions";
            this.lblMaxSubscriptions.Size = new System.Drawing.Size(82, 16);
            this.lblMaxSubscriptions.TabIndex = 4;
            this.lblMaxSubscriptions.Text = "Max. inschr.";
            // 
            // lblSubscriptions
            // 
            this.lblSubscriptions.Location = new System.Drawing.Point(365, 20);
            this.lblSubscriptions.Name = "lblSubscriptions";
            this.lblSubscriptions.Size = new System.Drawing.Size(87, 16);
            this.lblSubscriptions.TabIndex = 3;
            this.lblSubscriptions.Text = "Aantal inschr.";
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Location = new System.Drawing.Point(289, 20);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(38, 13);
            this.lblEventDate.TabIndex = 2;
            this.lblEventDate.Text = "Datum";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Location = new System.Drawing.Point(6, 20);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(35, 13);
            this.lblEventName.TabIndex = 1;
            this.lblEventName.Text = "Event";
            // 
            // lbxEvents
            // 
            this.lbxEvents.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxEvents.FormattingEnabled = true;
            this.lbxEvents.HorizontalScrollbar = true;
            this.lbxEvents.ItemHeight = 15;
            this.lbxEvents.Location = new System.Drawing.Point(3, 43);
            this.lbxEvents.Name = "lbxEvents";
            this.lbxEvents.Size = new System.Drawing.Size(691, 214);
            this.lbxEvents.TabIndex = 0;
            this.lbxEvents.Click += new System.EventHandler(this.lbxEvents_Click);
            this.lbxEvents.DoubleClick += new System.EventHandler(this.lbxEvents_DoubleClick);
            // 
            // rndVerleden
            // 
            this.rndVerleden.AutoSize = true;
            this.rndVerleden.Location = new System.Drawing.Point(41, 76);
            this.rndVerleden.Name = "rndVerleden";
            this.rndVerleden.Size = new System.Drawing.Size(131, 17);
            this.rndVerleden.TabIndex = 3;
            this.rndVerleden.Text = "Events in het verleden";
            this.rndVerleden.UseVisualStyleBackColor = true;
            this.rndVerleden.CheckedChanged += new System.EventHandler(this.rndVerleden_CheckedChanged);
            // 
            // rndToekomst
            // 
            this.rndToekomst.AutoSize = true;
            this.rndToekomst.Checked = true;
            this.rndToekomst.Location = new System.Drawing.Point(41, 100);
            this.rndToekomst.Name = "rndToekomst";
            this.rndToekomst.Size = new System.Drawing.Size(130, 17);
            this.rndToekomst.TabIndex = 4;
            this.rndToekomst.TabStop = true;
            this.rndToekomst.Text = "Events in de toekomst";
            this.rndToekomst.UseVisualStyleBackColor = true;
            this.rndToekomst.CheckedChanged += new System.EventHandler(this.rndToekomst_CheckedChanged);
            // 
            // pnlStatus
            // 
            this.pnlStatus.Controls.Add(this.rndNietVolzet);
            this.pnlStatus.Controls.Add(this.rndVolzet);
            this.pnlStatus.Location = new System.Drawing.Point(70, 115);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(101, 46);
            this.pnlStatus.TabIndex = 5;
            // 
            // rndNietVolzet
            // 
            this.rndNietVolzet.AutoSize = true;
            this.rndNietVolzet.Checked = true;
            this.rndNietVolzet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rndNietVolzet.Location = new System.Drawing.Point(3, 3);
            this.rndNietVolzet.Name = "rndNietVolzet";
            this.rndNietVolzet.Size = new System.Drawing.Size(75, 17);
            this.rndNietVolzet.TabIndex = 1;
            this.rndNietVolzet.TabStop = true;
            this.rndNietVolzet.Text = "Niet volzet";
            this.rndNietVolzet.UseVisualStyleBackColor = true;
            this.rndNietVolzet.CheckedChanged += new System.EventHandler(this.rndNietVolzet_CheckedChanged);
            // 
            // rndVolzet
            // 
            this.rndVolzet.AutoSize = true;
            this.rndVolzet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rndVolzet.Location = new System.Drawing.Point(3, 26);
            this.rndVolzet.Name = "rndVolzet";
            this.rndVolzet.Size = new System.Drawing.Size(54, 17);
            this.rndVolzet.TabIndex = 0;
            this.rndVolzet.Text = "Volzet";
            this.rndVolzet.UseVisualStyleBackColor = true;
            this.rndVolzet.CheckedChanged += new System.EventHandler(this.rndVolzet_CheckedChanged);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnUitschrijven);
            this.pnlButtons.Controls.Add(this.btnInschrijven);
            this.pnlButtons.Location = new System.Drawing.Point(70, 189);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(102, 58);
            this.pnlButtons.TabIndex = 6;
            // 
            // btnUitschrijven
            // 
            this.btnUitschrijven.Location = new System.Drawing.Point(14, 33);
            this.btnUitschrijven.Name = "btnUitschrijven";
            this.btnUitschrijven.Size = new System.Drawing.Size(75, 23);
            this.btnUitschrijven.TabIndex = 1;
            this.btnUitschrijven.Text = "Uitschrijven";
            this.btnUitschrijven.UseVisualStyleBackColor = true;
            this.btnUitschrijven.Click += new System.EventHandler(this.btnUitschrijven_Click);
            // 
            // btnInschrijven
            // 
            this.btnInschrijven.Location = new System.Drawing.Point(14, 4);
            this.btnInschrijven.Name = "btnInschrijven";
            this.btnInschrijven.Size = new System.Drawing.Size(75, 23);
            this.btnInschrijven.TabIndex = 0;
            this.btnInschrijven.Text = "Inschrijven";
            this.btnInschrijven.UseVisualStyleBackColor = true;
            this.btnInschrijven.Click += new System.EventHandler(this.btnInschrijven_Click);
            // 
            // Beginscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 321);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.rndToekomst);
            this.Controls.Add(this.rndVerleden);
            this.Controls.Add(this.grbEvenementen);
            this.Controls.Add(this.lblEvenementen);
            this.Controls.Add(this.menuBeginscherm);
            this.MainMenuStrip = this.menuBeginscherm;
            this.Name = "Beginscherm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IT events";
            this.menuBeginscherm.ResumeLayout(false);
            this.menuBeginscherm.PerformLayout();
            this.grbEvenementen.ResumeLayout(false);
            this.grbEvenementen.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBeginscherm;
        private System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem afsluitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aanmakenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inloggenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uitloggenToolStripMenuItem;
        private System.Windows.Forms.Label lblEvenementen;
        private System.Windows.Forms.GroupBox grbEvenementen;
        private System.Windows.Forms.RadioButton rndVerleden;
        private System.Windows.Forms.RadioButton rndToekomst;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.RadioButton rndNietVolzet;
        private System.Windows.Forms.RadioButton rndVolzet;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnUitschrijven;
        private System.Windows.Forms.Button btnInschrijven;
        private System.Windows.Forms.ListBox lbxEvents;
        private System.Windows.Forms.Label lblMaxSubscriptions;
        private System.Windows.Forms.Label lblSubscriptions;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.ToolStripMenuItem mijnEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toekomstigeEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statischeInformatieToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mijnEventsToolStripMenuItemRapport;
        private System.Windows.Forms.Label lblOrg;
        private System.Windows.Forms.ToolStripMenuItem registrerenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wachtwoordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

