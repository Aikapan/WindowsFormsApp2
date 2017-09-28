namespace WindowsFormsApp2
{
    partial class frm_mitarbeiter
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
            this.cb_mitarbeiterauswahl = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bn_abbrechen = new System.Windows.Forms.Button();
            this.bn_speichern = new System.Windows.Forms.Button();
            this.cb_staatsangehörigkeit = new System.Windows.Forms.ComboBox();
            this.cb_konfession = new System.Windows.Forms.ComboBox();
            this.cb_berufsbezeichnung = new System.Windows.Forms.ComboBox();
            this.cb_funktion = new System.Windows.Forms.ComboBox();
            this.cb_abteilung = new System.Windows.Forms.ComboBox();
            this.cb_familienstand = new System.Windows.Forms.ComboBox();
            this.cb_titel = new System.Windows.Forms.ComboBox();
            this.tb_hausnummer = new System.Windows.Forms.TextBox();
            this.tb_tel_fest = new System.Windows.Forms.TextBox();
            this.tb_geburtstag = new System.Windows.Forms.TextBox();
            this.tb_einstellungsdatum = new System.Windows.Forms.TextBox();
            this.tb_tel_priv = new System.Windows.Forms.TextBox();
            this.tb_kinder = new System.Windows.Forms.TextBox();
            this.tb_wohnort = new System.Windows.Forms.TextBox();
            this.tb_postleitzahl = new System.Windows.Forms.TextBox();
            this.tb_tel_mobil = new System.Windows.Forms.TextBox();
            this.tb_priv_email = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_geschlecht = new System.Windows.Forms.TextBox();
            this.tb_nachname = new System.Windows.Forms.TextBox();
            this.tb_zw_vorname = new System.Windows.Forms.TextBox();
            this.tb_vorname = new System.Windows.Forms.TextBox();
            this.tb_straße = new System.Windows.Forms.TextBox();
            this.tb_personalnummer = new System.Windows.Forms.TextBox();
            this.tb_rfid = new System.Windows.Forms.TextBox();
            this.tb_kuerzel = new System.Windows.Forms.TextBox();
            this.lb_kuerzel = new System.Windows.Forms.Label();
            this.lb_hausnummer = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_tel_mobil = new System.Windows.Forms.Label();
            this.lb_tel_fest = new System.Windows.Forms.Label();
            this.lb_kinder = new System.Windows.Forms.Label();
            this.lb_familienstand = new System.Windows.Forms.Label();
            this.lb_staatsangehörigkeit = new System.Windows.Forms.Label();
            this.lb_priv_email = new System.Windows.Forms.Label();
            this.lb_tel_privat = new System.Windows.Forms.Label();
            this.lb_plz = new System.Windows.Forms.Label();
            this.lb_wohnort = new System.Windows.Forms.Label();
            this.lb_konfession = new System.Windows.Forms.Label();
            this.lb_funktion = new System.Windows.Forms.Label();
            this.lb_abteilung = new System.Windows.Forms.Label();
            this.lb_niederlassung = new System.Windows.Forms.Label();
            this.lb_einstellungsdatum = new System.Windows.Forms.Label();
            this.lb_geburtstag = new System.Windows.Forms.Label();
            this.lb_berufsbezeichnung = new System.Windows.Forms.Label();
            this.lb_geschlecht = new System.Windows.Forms.Label();
            this.lb_nachname = new System.Windows.Forms.Label();
            this.lb_zw_vorname = new System.Windows.Forms.Label();
            this.lb_vorname = new System.Windows.Forms.Label();
            this.lb_titel = new System.Windows.Forms.Label();
            this.lb_personalnummer = new System.Windows.Forms.Label();
            this.lb_rfid = new System.Windows.Forms.Label();
            this.lb_straße = new System.Windows.Forms.Label();
            this.cb_niederlassung = new System.Windows.Forms.ComboBox();
            this.bn_neu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_mitarbeiterauswahl
            // 
            this.cb_mitarbeiterauswahl.FormattingEnabled = true;
            this.cb_mitarbeiterauswahl.Location = new System.Drawing.Point(540, 27);
            this.cb_mitarbeiterauswahl.Name = "cb_mitarbeiterauswahl";
            this.cb_mitarbeiterauswahl.Size = new System.Drawing.Size(65, 24);
            this.cb_mitarbeiterauswahl.TabIndex = 0;
            this.cb_mitarbeiterauswahl.SelectedIndexChanged += new System.EventHandler(this.cb_mitarbeiterauswahl_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mitarbeiter auswählen oder neu anlegen:";
            // 
            // bn_abbrechen
            // 
            this.bn_abbrechen.Location = new System.Drawing.Point(479, 523);
            this.bn_abbrechen.Name = "bn_abbrechen";
            this.bn_abbrechen.Size = new System.Drawing.Size(136, 41);
            this.bn_abbrechen.TabIndex = 2;
            this.bn_abbrechen.Text = "Abbrechen";
            this.bn_abbrechen.UseVisualStyleBackColor = true;
            this.bn_abbrechen.Click += new System.EventHandler(this.bn_abbrechen_Click);
            // 
            // bn_speichern
            // 
            this.bn_speichern.Location = new System.Drawing.Point(337, 523);
            this.bn_speichern.Name = "bn_speichern";
            this.bn_speichern.Size = new System.Drawing.Size(136, 41);
            this.bn_speichern.TabIndex = 3;
            this.bn_speichern.Text = "Speichern";
            this.bn_speichern.UseVisualStyleBackColor = true;
            this.bn_speichern.Click += new System.EventHandler(this.bn_speichern_Click);
            // 
            // cb_staatsangehörigkeit
            // 
            this.cb_staatsangehörigkeit.FormattingEnabled = true;
            this.cb_staatsangehörigkeit.Location = new System.Drawing.Point(458, 79);
            this.cb_staatsangehörigkeit.Name = "cb_staatsangehörigkeit";
            this.cb_staatsangehörigkeit.Size = new System.Drawing.Size(147, 24);
            this.cb_staatsangehörigkeit.TabIndex = 4;
            // 
            // cb_konfession
            // 
            this.cb_konfession.FormattingEnabled = true;
            this.cb_konfession.Location = new System.Drawing.Point(458, 109);
            this.cb_konfession.Name = "cb_konfession";
            this.cb_konfession.Size = new System.Drawing.Size(147, 24);
            this.cb_konfession.TabIndex = 5;
            // 
            // cb_berufsbezeichnung
            // 
            this.cb_berufsbezeichnung.FormattingEnabled = true;
            this.cb_berufsbezeichnung.Location = new System.Drawing.Point(163, 317);
            this.cb_berufsbezeichnung.Name = "cb_berufsbezeichnung";
            this.cb_berufsbezeichnung.Size = new System.Drawing.Size(147, 24);
            this.cb_berufsbezeichnung.TabIndex = 6;
            this.cb_berufsbezeichnung.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cb_berufsbezeichnung_MouseClick);
            // 
            // cb_funktion
            // 
            this.cb_funktion.FormattingEnabled = true;
            this.cb_funktion.Location = new System.Drawing.Point(163, 457);
            this.cb_funktion.Name = "cb_funktion";
            this.cb_funktion.Size = new System.Drawing.Size(147, 24);
            this.cb_funktion.TabIndex = 7;
            // 
            // cb_abteilung
            // 
            this.cb_abteilung.FormattingEnabled = true;
            this.cb_abteilung.Location = new System.Drawing.Point(163, 429);
            this.cb_abteilung.Name = "cb_abteilung";
            this.cb_abteilung.Size = new System.Drawing.Size(147, 24);
            this.cb_abteilung.TabIndex = 8;
            // 
            // cb_familienstand
            // 
            this.cb_familienstand.FormattingEnabled = true;
            this.cb_familienstand.Location = new System.Drawing.Point(458, 139);
            this.cb_familienstand.Name = "cb_familienstand";
            this.cb_familienstand.Size = new System.Drawing.Size(147, 24);
            this.cb_familienstand.TabIndex = 9;
            // 
            // cb_titel
            // 
            this.cb_titel.FormattingEnabled = true;
            this.cb_titel.Location = new System.Drawing.Point(163, 169);
            this.cb_titel.Name = "cb_titel";
            this.cb_titel.Size = new System.Drawing.Size(147, 24);
            this.cb_titel.TabIndex = 10;
            this.cb_titel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cb_titel_MouseClick);
            // 
            // tb_hausnummer
            // 
            this.tb_hausnummer.Location = new System.Drawing.Point(458, 289);
            this.tb_hausnummer.Name = "tb_hausnummer";
            this.tb_hausnummer.Size = new System.Drawing.Size(147, 22);
            this.tb_hausnummer.TabIndex = 11;
            // 
            // tb_tel_fest
            // 
            this.tb_tel_fest.Location = new System.Drawing.Point(458, 401);
            this.tb_tel_fest.Name = "tb_tel_fest";
            this.tb_tel_fest.Size = new System.Drawing.Size(147, 22);
            this.tb_tel_fest.TabIndex = 12;
            // 
            // tb_geburtstag
            // 
            this.tb_geburtstag.Location = new System.Drawing.Point(163, 345);
            this.tb_geburtstag.Name = "tb_geburtstag";
            this.tb_geburtstag.Size = new System.Drawing.Size(147, 22);
            this.tb_geburtstag.TabIndex = 13;
            // 
            // tb_einstellungsdatum
            // 
            this.tb_einstellungsdatum.Location = new System.Drawing.Point(163, 373);
            this.tb_einstellungsdatum.Name = "tb_einstellungsdatum";
            this.tb_einstellungsdatum.Size = new System.Drawing.Size(147, 22);
            this.tb_einstellungsdatum.TabIndex = 14;
            // 
            // tb_tel_priv
            // 
            this.tb_tel_priv.Location = new System.Drawing.Point(458, 429);
            this.tb_tel_priv.Name = "tb_tel_priv";
            this.tb_tel_priv.Size = new System.Drawing.Size(147, 22);
            this.tb_tel_priv.TabIndex = 15;
            // 
            // tb_kinder
            // 
            this.tb_kinder.Location = new System.Drawing.Point(458, 169);
            this.tb_kinder.Name = "tb_kinder";
            this.tb_kinder.Size = new System.Drawing.Size(147, 22);
            this.tb_kinder.TabIndex = 17;
            // 
            // tb_wohnort
            // 
            this.tb_wohnort.Location = new System.Drawing.Point(458, 199);
            this.tb_wohnort.Name = "tb_wohnort";
            this.tb_wohnort.Size = new System.Drawing.Size(147, 22);
            this.tb_wohnort.TabIndex = 18;
            // 
            // tb_postleitzahl
            // 
            this.tb_postleitzahl.Location = new System.Drawing.Point(458, 229);
            this.tb_postleitzahl.Name = "tb_postleitzahl";
            this.tb_postleitzahl.Size = new System.Drawing.Size(147, 22);
            this.tb_postleitzahl.TabIndex = 19;
            // 
            // tb_tel_mobil
            // 
            this.tb_tel_mobil.Location = new System.Drawing.Point(458, 373);
            this.tb_tel_mobil.Name = "tb_tel_mobil";
            this.tb_tel_mobil.Size = new System.Drawing.Size(147, 22);
            this.tb_tel_mobil.TabIndex = 20;
            // 
            // tb_priv_email
            // 
            this.tb_priv_email.Location = new System.Drawing.Point(458, 345);
            this.tb_priv_email.Name = "tb_priv_email";
            this.tb_priv_email.Size = new System.Drawing.Size(147, 22);
            this.tb_priv_email.TabIndex = 21;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(458, 317);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(147, 22);
            this.tb_email.TabIndex = 22;
            // 
            // tb_geschlecht
            // 
            this.tb_geschlecht.Location = new System.Drawing.Point(163, 289);
            this.tb_geschlecht.Name = "tb_geschlecht";
            this.tb_geschlecht.Size = new System.Drawing.Size(147, 22);
            this.tb_geschlecht.TabIndex = 23;
            // 
            // tb_nachname
            // 
            this.tb_nachname.Location = new System.Drawing.Point(163, 259);
            this.tb_nachname.Name = "tb_nachname";
            this.tb_nachname.Size = new System.Drawing.Size(147, 22);
            this.tb_nachname.TabIndex = 24;
            // 
            // tb_zw_vorname
            // 
            this.tb_zw_vorname.Location = new System.Drawing.Point(163, 229);
            this.tb_zw_vorname.Name = "tb_zw_vorname";
            this.tb_zw_vorname.Size = new System.Drawing.Size(147, 22);
            this.tb_zw_vorname.TabIndex = 25;
            // 
            // tb_vorname
            // 
            this.tb_vorname.Location = new System.Drawing.Point(163, 199);
            this.tb_vorname.Name = "tb_vorname";
            this.tb_vorname.Size = new System.Drawing.Size(147, 22);
            this.tb_vorname.TabIndex = 26;
            // 
            // tb_straße
            // 
            this.tb_straße.Location = new System.Drawing.Point(458, 259);
            this.tb_straße.Name = "tb_straße";
            this.tb_straße.Size = new System.Drawing.Size(147, 22);
            this.tb_straße.TabIndex = 27;
            // 
            // tb_personalnummer
            // 
            this.tb_personalnummer.Location = new System.Drawing.Point(163, 139);
            this.tb_personalnummer.Name = "tb_personalnummer";
            this.tb_personalnummer.Size = new System.Drawing.Size(147, 22);
            this.tb_personalnummer.TabIndex = 28;
            // 
            // tb_rfid
            // 
            this.tb_rfid.Location = new System.Drawing.Point(163, 109);
            this.tb_rfid.Name = "tb_rfid";
            this.tb_rfid.Size = new System.Drawing.Size(147, 22);
            this.tb_rfid.TabIndex = 29;
            // 
            // tb_kuerzel
            // 
            this.tb_kuerzel.Location = new System.Drawing.Point(163, 79);
            this.tb_kuerzel.Name = "tb_kuerzel";
            this.tb_kuerzel.Size = new System.Drawing.Size(147, 22);
            this.tb_kuerzel.TabIndex = 30;
            // 
            // lb_kuerzel
            // 
            this.lb_kuerzel.AutoSize = true;
            this.lb_kuerzel.Location = new System.Drawing.Point(32, 82);
            this.lb_kuerzel.Name = "lb_kuerzel";
            this.lb_kuerzel.Size = new System.Drawing.Size(48, 17);
            this.lb_kuerzel.TabIndex = 31;
            this.lb_kuerzel.Text = "Kürzel";
            // 
            // lb_hausnummer
            // 
            this.lb_hausnummer.AutoSize = true;
            this.lb_hausnummer.Location = new System.Drawing.Point(323, 292);
            this.lb_hausnummer.Name = "lb_hausnummer";
            this.lb_hausnummer.Size = new System.Drawing.Size(92, 17);
            this.lb_hausnummer.TabIndex = 32;
            this.lb_hausnummer.Text = "Hausnummer";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(323, 320);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(42, 17);
            this.lb_email.TabIndex = 33;
            this.lb_email.Text = "Email";
            // 
            // lb_tel_mobil
            // 
            this.lb_tel_mobil.AutoSize = true;
            this.lb_tel_mobil.Location = new System.Drawing.Point(323, 376);
            this.lb_tel_mobil.Name = "lb_tel_mobil";
            this.lb_tel_mobil.Size = new System.Drawing.Size(69, 17);
            this.lb_tel_mobil.TabIndex = 34;
            this.lb_tel_mobil.Text = "Tel. Mobil";
            // 
            // lb_tel_fest
            // 
            this.lb_tel_fest.AutoSize = true;
            this.lb_tel_fest.Location = new System.Drawing.Point(323, 404);
            this.lb_tel_fest.Name = "lb_tel_fest";
            this.lb_tel_fest.Size = new System.Drawing.Size(67, 17);
            this.lb_tel_fest.TabIndex = 35;
            this.lb_tel_fest.Text = "Tel. Fest.";
            // 
            // lb_kinder
            // 
            this.lb_kinder.AutoSize = true;
            this.lb_kinder.Location = new System.Drawing.Point(323, 172);
            this.lb_kinder.Name = "lb_kinder";
            this.lb_kinder.Size = new System.Drawing.Size(96, 17);
            this.lb_kinder.TabIndex = 36;
            this.lb_kinder.Text = "Anzahl Kinder";
            // 
            // lb_familienstand
            // 
            this.lb_familienstand.AutoSize = true;
            this.lb_familienstand.Location = new System.Drawing.Point(323, 142);
            this.lb_familienstand.Name = "lb_familienstand";
            this.lb_familienstand.Size = new System.Drawing.Size(95, 17);
            this.lb_familienstand.TabIndex = 37;
            this.lb_familienstand.Text = "Familienstand";
            // 
            // lb_staatsangehörigkeit
            // 
            this.lb_staatsangehörigkeit.AutoSize = true;
            this.lb_staatsangehörigkeit.Location = new System.Drawing.Point(323, 82);
            this.lb_staatsangehörigkeit.Name = "lb_staatsangehörigkeit";
            this.lb_staatsangehörigkeit.Size = new System.Drawing.Size(134, 17);
            this.lb_staatsangehörigkeit.TabIndex = 38;
            this.lb_staatsangehörigkeit.Text = "Staatsangehörigkeit";
            // 
            // lb_priv_email
            // 
            this.lb_priv_email.AutoSize = true;
            this.lb_priv_email.Location = new System.Drawing.Point(323, 348);
            this.lb_priv_email.Name = "lb_priv_email";
            this.lb_priv_email.Size = new System.Drawing.Size(74, 17);
            this.lb_priv_email.TabIndex = 39;
            this.lb_priv_email.Text = "Priv. Email";
            // 
            // lb_tel_privat
            // 
            this.lb_tel_privat.AutoSize = true;
            this.lb_tel_privat.Location = new System.Drawing.Point(323, 432);
            this.lb_tel_privat.Name = "lb_tel_privat";
            this.lb_tel_privat.Size = new System.Drawing.Size(72, 17);
            this.lb_tel_privat.TabIndex = 40;
            this.lb_tel_privat.Text = "Tel. Privat";
            // 
            // lb_plz
            // 
            this.lb_plz.AutoSize = true;
            this.lb_plz.Location = new System.Drawing.Point(323, 232);
            this.lb_plz.Name = "lb_plz";
            this.lb_plz.Size = new System.Drawing.Size(80, 17);
            this.lb_plz.TabIndex = 41;
            this.lb_plz.Text = "Postleitzahl";
            // 
            // lb_wohnort
            // 
            this.lb_wohnort.AutoSize = true;
            this.lb_wohnort.Location = new System.Drawing.Point(323, 202);
            this.lb_wohnort.Name = "lb_wohnort";
            this.lb_wohnort.Size = new System.Drawing.Size(62, 17);
            this.lb_wohnort.TabIndex = 42;
            this.lb_wohnort.Text = "Wohnort";
            // 
            // lb_konfession
            // 
            this.lb_konfession.AutoSize = true;
            this.lb_konfession.Location = new System.Drawing.Point(323, 112);
            this.lb_konfession.Name = "lb_konfession";
            this.lb_konfession.Size = new System.Drawing.Size(78, 17);
            this.lb_konfession.TabIndex = 43;
            this.lb_konfession.Text = "Konfession";
            // 
            // lb_funktion
            // 
            this.lb_funktion.AutoSize = true;
            this.lb_funktion.Location = new System.Drawing.Point(32, 460);
            this.lb_funktion.Name = "lb_funktion";
            this.lb_funktion.Size = new System.Drawing.Size(62, 17);
            this.lb_funktion.TabIndex = 44;
            this.lb_funktion.Text = "Funktion";
            // 
            // lb_abteilung
            // 
            this.lb_abteilung.AutoSize = true;
            this.lb_abteilung.Location = new System.Drawing.Point(32, 432);
            this.lb_abteilung.Name = "lb_abteilung";
            this.lb_abteilung.Size = new System.Drawing.Size(67, 17);
            this.lb_abteilung.TabIndex = 45;
            this.lb_abteilung.Text = "Abteilung";
            // 
            // lb_niederlassung
            // 
            this.lb_niederlassung.AutoSize = true;
            this.lb_niederlassung.Location = new System.Drawing.Point(32, 404);
            this.lb_niederlassung.Name = "lb_niederlassung";
            this.lb_niederlassung.Size = new System.Drawing.Size(99, 17);
            this.lb_niederlassung.TabIndex = 46;
            this.lb_niederlassung.Text = "Niederlassung";
            // 
            // lb_einstellungsdatum
            // 
            this.lb_einstellungsdatum.AutoSize = true;
            this.lb_einstellungsdatum.Location = new System.Drawing.Point(32, 376);
            this.lb_einstellungsdatum.Name = "lb_einstellungsdatum";
            this.lb_einstellungsdatum.Size = new System.Drawing.Size(123, 17);
            this.lb_einstellungsdatum.TabIndex = 47;
            this.lb_einstellungsdatum.Text = "Einstellungsdatum";
            // 
            // lb_geburtstag
            // 
            this.lb_geburtstag.AutoSize = true;
            this.lb_geburtstag.Location = new System.Drawing.Point(32, 348);
            this.lb_geburtstag.Name = "lb_geburtstag";
            this.lb_geburtstag.Size = new System.Drawing.Size(79, 17);
            this.lb_geburtstag.TabIndex = 48;
            this.lb_geburtstag.Text = "Geburtstag";
            // 
            // lb_berufsbezeichnung
            // 
            this.lb_berufsbezeichnung.AutoSize = true;
            this.lb_berufsbezeichnung.Location = new System.Drawing.Point(32, 320);
            this.lb_berufsbezeichnung.Name = "lb_berufsbezeichnung";
            this.lb_berufsbezeichnung.Size = new System.Drawing.Size(130, 17);
            this.lb_berufsbezeichnung.TabIndex = 49;
            this.lb_berufsbezeichnung.Text = "Berufsbezeichnung";
            // 
            // lb_geschlecht
            // 
            this.lb_geschlecht.AutoSize = true;
            this.lb_geschlecht.Location = new System.Drawing.Point(32, 292);
            this.lb_geschlecht.Name = "lb_geschlecht";
            this.lb_geschlecht.Size = new System.Drawing.Size(79, 17);
            this.lb_geschlecht.TabIndex = 50;
            this.lb_geschlecht.Text = "Geschlecht";
            // 
            // lb_nachname
            // 
            this.lb_nachname.AutoSize = true;
            this.lb_nachname.Location = new System.Drawing.Point(32, 262);
            this.lb_nachname.Name = "lb_nachname";
            this.lb_nachname.Size = new System.Drawing.Size(76, 17);
            this.lb_nachname.TabIndex = 51;
            this.lb_nachname.Text = "Nachname";
            // 
            // lb_zw_vorname
            // 
            this.lb_zw_vorname.AutoSize = true;
            this.lb_zw_vorname.Location = new System.Drawing.Point(32, 232);
            this.lb_zw_vorname.Name = "lb_zw_vorname";
            this.lb_zw_vorname.Size = new System.Drawing.Size(91, 17);
            this.lb_zw_vorname.TabIndex = 52;
            this.lb_zw_vorname.Text = "Zw. Vorname";
            // 
            // lb_vorname
            // 
            this.lb_vorname.AutoSize = true;
            this.lb_vorname.Location = new System.Drawing.Point(32, 202);
            this.lb_vorname.Name = "lb_vorname";
            this.lb_vorname.Size = new System.Drawing.Size(65, 17);
            this.lb_vorname.TabIndex = 53;
            this.lb_vorname.Text = "Vorname";
            // 
            // lb_titel
            // 
            this.lb_titel.AutoSize = true;
            this.lb_titel.Location = new System.Drawing.Point(32, 172);
            this.lb_titel.Name = "lb_titel";
            this.lb_titel.Size = new System.Drawing.Size(35, 17);
            this.lb_titel.TabIndex = 54;
            this.lb_titel.Text = "Titel";
            // 
            // lb_personalnummer
            // 
            this.lb_personalnummer.AutoSize = true;
            this.lb_personalnummer.Location = new System.Drawing.Point(32, 142);
            this.lb_personalnummer.Name = "lb_personalnummer";
            this.lb_personalnummer.Size = new System.Drawing.Size(115, 17);
            this.lb_personalnummer.TabIndex = 55;
            this.lb_personalnummer.Text = "Personalnummer";
            // 
            // lb_rfid
            // 
            this.lb_rfid.AutoSize = true;
            this.lb_rfid.Location = new System.Drawing.Point(32, 112);
            this.lb_rfid.Name = "lb_rfid";
            this.lb_rfid.Size = new System.Drawing.Size(72, 17);
            this.lb_rfid.TabIndex = 56;
            this.lb_rfid.Text = "RFID_Tag";
            // 
            // lb_straße
            // 
            this.lb_straße.AutoSize = true;
            this.lb_straße.Location = new System.Drawing.Point(323, 262);
            this.lb_straße.Name = "lb_straße";
            this.lb_straße.Size = new System.Drawing.Size(51, 17);
            this.lb_straße.TabIndex = 57;
            this.lb_straße.Text = "Straße";
            // 
            // cb_niederlassung
            // 
            this.cb_niederlassung.FormattingEnabled = true;
            this.cb_niederlassung.Location = new System.Drawing.Point(163, 401);
            this.cb_niederlassung.Name = "cb_niederlassung";
            this.cb_niederlassung.Size = new System.Drawing.Size(147, 24);
            this.cb_niederlassung.TabIndex = 58;
            // 
            // bn_neu
            // 
            this.bn_neu.Location = new System.Drawing.Point(458, 27);
            this.bn_neu.Name = "bn_neu";
            this.bn_neu.Size = new System.Drawing.Size(59, 24);
            this.bn_neu.TabIndex = 59;
            this.bn_neu.Text = "Neu";
            this.bn_neu.UseVisualStyleBackColor = true;
            this.bn_neu.Click += new System.EventHandler(this.bn_neu_Click);
            // 
            // frm_mitarbeiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 587);
            this.Controls.Add(this.bn_neu);
            this.Controls.Add(this.cb_niederlassung);
            this.Controls.Add(this.lb_straße);
            this.Controls.Add(this.lb_rfid);
            this.Controls.Add(this.lb_personalnummer);
            this.Controls.Add(this.lb_titel);
            this.Controls.Add(this.lb_vorname);
            this.Controls.Add(this.lb_zw_vorname);
            this.Controls.Add(this.lb_nachname);
            this.Controls.Add(this.lb_geschlecht);
            this.Controls.Add(this.lb_berufsbezeichnung);
            this.Controls.Add(this.lb_geburtstag);
            this.Controls.Add(this.lb_einstellungsdatum);
            this.Controls.Add(this.lb_niederlassung);
            this.Controls.Add(this.lb_abteilung);
            this.Controls.Add(this.lb_funktion);
            this.Controls.Add(this.lb_konfession);
            this.Controls.Add(this.lb_wohnort);
            this.Controls.Add(this.lb_plz);
            this.Controls.Add(this.lb_tel_privat);
            this.Controls.Add(this.lb_priv_email);
            this.Controls.Add(this.lb_staatsangehörigkeit);
            this.Controls.Add(this.lb_familienstand);
            this.Controls.Add(this.lb_kinder);
            this.Controls.Add(this.lb_tel_fest);
            this.Controls.Add(this.lb_tel_mobil);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_hausnummer);
            this.Controls.Add(this.lb_kuerzel);
            this.Controls.Add(this.tb_kuerzel);
            this.Controls.Add(this.tb_rfid);
            this.Controls.Add(this.tb_personalnummer);
            this.Controls.Add(this.tb_straße);
            this.Controls.Add(this.tb_vorname);
            this.Controls.Add(this.tb_zw_vorname);
            this.Controls.Add(this.tb_nachname);
            this.Controls.Add(this.tb_geschlecht);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_priv_email);
            this.Controls.Add(this.tb_tel_mobil);
            this.Controls.Add(this.tb_postleitzahl);
            this.Controls.Add(this.tb_wohnort);
            this.Controls.Add(this.tb_kinder);
            this.Controls.Add(this.tb_tel_priv);
            this.Controls.Add(this.tb_einstellungsdatum);
            this.Controls.Add(this.tb_geburtstag);
            this.Controls.Add(this.tb_tel_fest);
            this.Controls.Add(this.tb_hausnummer);
            this.Controls.Add(this.cb_titel);
            this.Controls.Add(this.cb_familienstand);
            this.Controls.Add(this.cb_abteilung);
            this.Controls.Add(this.cb_funktion);
            this.Controls.Add(this.cb_berufsbezeichnung);
            this.Controls.Add(this.cb_konfession);
            this.Controls.Add(this.cb_staatsangehörigkeit);
            this.Controls.Add(this.bn_speichern);
            this.Controls.Add(this.bn_abbrechen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_mitarbeiterauswahl);
            this.Name = "frm_mitarbeiter";
            this.Text = "Mitarbeiter anlegen oder ändern";
            this.Load += new System.EventHandler(this.frm_mitarbeiter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_mitarbeiterauswahl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bn_abbrechen;
        private System.Windows.Forms.Button bn_speichern;
        private System.Windows.Forms.ComboBox cb_staatsangehörigkeit;
        private System.Windows.Forms.ComboBox cb_konfession;
        private System.Windows.Forms.ComboBox cb_berufsbezeichnung;
        private System.Windows.Forms.ComboBox cb_funktion;
        private System.Windows.Forms.ComboBox cb_abteilung;
        private System.Windows.Forms.ComboBox cb_familienstand;
        private System.Windows.Forms.ComboBox cb_titel;
        private System.Windows.Forms.TextBox tb_hausnummer;
        private System.Windows.Forms.TextBox tb_tel_fest;
        private System.Windows.Forms.TextBox tb_geburtstag;
        private System.Windows.Forms.TextBox tb_einstellungsdatum;
        private System.Windows.Forms.TextBox tb_tel_priv;
        private System.Windows.Forms.TextBox tb_kinder;
        private System.Windows.Forms.TextBox tb_wohnort;
        private System.Windows.Forms.TextBox tb_postleitzahl;
        private System.Windows.Forms.TextBox tb_tel_mobil;
        private System.Windows.Forms.TextBox tb_priv_email;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_geschlecht;
        private System.Windows.Forms.TextBox tb_nachname;
        private System.Windows.Forms.TextBox tb_zw_vorname;
        private System.Windows.Forms.TextBox tb_vorname;
        private System.Windows.Forms.TextBox tb_straße;
        private System.Windows.Forms.TextBox tb_personalnummer;
        private System.Windows.Forms.TextBox tb_rfid;
        private System.Windows.Forms.TextBox tb_kuerzel;
        private System.Windows.Forms.Label lb_kuerzel;
        private System.Windows.Forms.Label lb_hausnummer;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_tel_mobil;
        private System.Windows.Forms.Label lb_tel_fest;
        private System.Windows.Forms.Label lb_kinder;
        private System.Windows.Forms.Label lb_familienstand;
        private System.Windows.Forms.Label lb_staatsangehörigkeit;
        private System.Windows.Forms.Label lb_priv_email;
        private System.Windows.Forms.Label lb_tel_privat;
        private System.Windows.Forms.Label lb_plz;
        private System.Windows.Forms.Label lb_wohnort;
        private System.Windows.Forms.Label lb_konfession;
        private System.Windows.Forms.Label lb_funktion;
        private System.Windows.Forms.Label lb_abteilung;
        private System.Windows.Forms.Label lb_niederlassung;
        private System.Windows.Forms.Label lb_einstellungsdatum;
        private System.Windows.Forms.Label lb_geburtstag;
        private System.Windows.Forms.Label lb_berufsbezeichnung;
        private System.Windows.Forms.Label lb_geschlecht;
        private System.Windows.Forms.Label lb_nachname;
        private System.Windows.Forms.Label lb_zw_vorname;
        private System.Windows.Forms.Label lb_vorname;
        private System.Windows.Forms.Label lb_titel;
        private System.Windows.Forms.Label lb_personalnummer;
        private System.Windows.Forms.Label lb_rfid;
        private System.Windows.Forms.Label lb_straße;
        private System.Windows.Forms.ComboBox cb_niederlassung;
        private System.Windows.Forms.Button bn_neu;
    }
}