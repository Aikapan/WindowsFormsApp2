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
using System.Diagnostics;
using System.Configuration;

namespace WindowsFormsApp2
{
    public partial class frm_mitarbeiter : Form
    {
        string connectionstring = "Server =GFA-DATABASE-PC\\SQLEXPRESS; Database = GfA_Datenbank; User ID=GfA-MJ-V3550; Password=jannik39";
        bool new_user = false;

        public frm_mitarbeiter()
        {
            InitializeComponent();
        }

        private void bn_abbrechen_Click(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
            Application.DoEvents();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cb_mitarbeiterauswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))

            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tbl_mitarbeiter", conn);
                DataTable Tabelle = new DataTable();
                adapter.Fill(Tabelle);

                string expression;
                expression = "kuerzel =" + cb_mitarbeiterauswahl.SelectedText;
                DataRow[] foundRows;
                foundRows = Tabelle.Select(expression);

                tb_kuerzel.Text = foundRows[0][1].ToString();
                tb_rfid.Text = foundRows[0][2].ToString();
                tb_personalnummer.Text = foundRows[0][3].ToString();
                cb_titel.Text = foundRows[0][4].ToString();
                tb_vorname.Text = foundRows[0][5].ToString();
                tb_zw_vorname.Text = foundRows[0][6].ToString();
                tb_nachname.Text = foundRows[0][7].ToString();
                tb_geschlecht.Text = foundRows[0][8].ToString();
                cb_berufsbezeichnung.Text = foundRows[0][9].ToString();
                tb_geburtstag.Text = foundRows[0][10].ToString();
                tb_einstellungsdatum.Text = foundRows[0][11].ToString();
                cb_niederlassung.Text = foundRows[0][12].ToString();
                cb_abteilung.Text = foundRows[0][13].ToString();
                cb_funktion.Text = foundRows[0][14].ToString();
                cb_staatsangehörigkeit.Text = foundRows[0][15].ToString();
                cb_konfession.Text = foundRows[0][16].ToString();
                cb_familienstand.Text = foundRows[0][17].ToString();
                tb_kinder.Text = foundRows[0][18].ToString();
                tb_postleitzahl.Text = foundRows[0][19].ToString();
                tb_wohnort.Text = foundRows[0][20].ToString();
                tb_straße.Text = foundRows[0][21].ToString();
                tb_hausnummer.Text = foundRows[0][22].ToString();
                tb_email.Text = foundRows[0][23].ToString();
                tb_priv_email.Text = foundRows[0][24].ToString();
                tb_tel_mobil.Text = foundRows[0][25].ToString();
                tb_tel_fest.Text = foundRows[0][26].ToString();
                tb_tel_priv.Text = foundRows[0][27].ToString();
              
         
            }
        }

        private void frm_mitarbeiter_Load(object sender, EventArgs e)
        {
            
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tbl_mitarbeiter", conn);
                DataTable Tabelle = new DataTable();
                adapter.Fill(Tabelle);

                cb_mitarbeiterauswahl.DataSource = Tabelle;
                cb_mitarbeiterauswahl.DisplayMember = "kuerzel";
                cb_mitarbeiterauswahl.ValueMember = "ID";

            }
        }

        private void bn_neu_Click(object sender, EventArgs e)
        {
            new_user = true;

            using (SqlConnection conn = new SqlConnection("Server =.\\SQLEXPRESS; Database = GfA_Database; Integrated Security = true"))
            {
                conn.Open();
                SqlDataAdapter A_titel = new SqlDataAdapter("SELECT * ID FROM tbl_users", conn);
                DataTable T_titel = new DataTable();
                A_titel.Fill(T_titel);
                SqlDataAdapter A_beruf = new SqlDataAdapter("SELECT * FROM tbl_users", conn);
                DataTable T_beruf = new DataTable();
                A_beruf.Fill(T_beruf);
                SqlDataAdapter A_niederlassung = new SqlDataAdapter("SELECT * FROM tbl_users", conn);
                DataTable T_niederlassung = new DataTable();
                A_niederlassung.Fill(T_niederlassung);
                SqlDataAdapter A_abteilung = new SqlDataAdapter("SELECT * FROM tbl_users", conn);
                DataTable T_abteilung = new DataTable();
                A_abteilung.Fill(T_abteilung);
                SqlDataAdapter A_funktion = new SqlDataAdapter("SELECT * FROM tbl_users", conn);
                DataTable T_funktion = new DataTable();
                A_funktion.Fill(T_funktion);
                SqlDataAdapter A_staat = new SqlDataAdapter("SELECT * FROM tbl_users", conn);
                DataTable T_staat = new DataTable();
                A_staat.Fill(T_staat);
                SqlDataAdapter A_konfession = new SqlDataAdapter("SELECT * FROM tbl_users", conn);
                DataTable T_konfession = new DataTable();
                A_konfession.Fill(T_konfession);
                SqlDataAdapter A_familienstand = new SqlDataAdapter("SELECT * FROM tbl_users", conn);
                DataTable T_familienstand = new DataTable();
                A_familienstand.Fill(T_familienstand);


                tb_kuerzel.Text = "";
                tb_rfid.Text = "";
                tb_personalnummer.Text = "";
                cb_titel.DataSource = T_titel;
                cb_titel.DisplayMember = "login";
                tb_vorname.Text = "";
                tb_zw_vorname.Text = "";
                tb_nachname.Text = "";
                tb_geschlecht.Text = "";
                cb_berufsbezeichnung.DataSource = T_beruf;
                cb_berufsbezeichnung.DisplayMember = "login";
                tb_geburtstag.Text = "";
                tb_einstellungsdatum.Text = "";
                cb_niederlassung.DataSource = T_niederlassung;
                cb_niederlassung.DisplayMember = "login";
                cb_abteilung.DataSource = T_abteilung;
                cb_abteilung.DisplayMember = "login";
                cb_funktion.DataSource = T_funktion;
                cb_funktion.DisplayMember = "login";
                cb_staatsangehörigkeit.DataSource = T_staat;
                cb_staatsangehörigkeit.DisplayMember = "login";
                cb_konfession.DataSource = T_konfession;
                cb_konfession.DisplayMember = "login";
                cb_familienstand.DataSource = T_familienstand;
                cb_familienstand.DisplayMember = "login";
                tb_kinder.Text = "";
                tb_postleitzahl.Text = "";
                tb_wohnort.Text = "";
                tb_straße.Text = "";
                tb_hausnummer.Text = "";
                tb_email.Text = "";
                tb_priv_email.Text = "";
                tb_tel_mobil.Text = "";
                tb_tel_fest.Text = "";
                tb_tel_priv.Text = "";
            }
        }

        private void cb_titel_MouseClick(object sender, MouseEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tbl_users", conn);
                DataTable Tabelle = new DataTable();
                adapter.Fill(Tabelle);

                cb_mitarbeiterauswahl.DataSource = Tabelle;
                cb_mitarbeiterauswahl.DisplayMember = "login";
                cb_mitarbeiterauswahl.ValueMember = "ID";

            }
        }

        private void cb_berufsbezeichnung_MouseClick(object sender, MouseEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tbl_users", conn);
                DataTable Tabelle = new DataTable();
                adapter.Fill(Tabelle);

                cb_mitarbeiterauswahl.DataSource = Tabelle;
                cb_mitarbeiterauswahl.DisplayMember = "login";
                cb_mitarbeiterauswahl.ValueMember = "ID";

            }
        }

        private void bn_speichern_Click(object sender, EventArgs e)
        {
            if (new_user == true)
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO tbl_mitarbeiter (rfid, kuerzel, personalnummer, titel, vorname," +
                        " vorname2, nachname, geschlecht, beruf_id, geburtsdatum, einstellungsdatum, niederlassung_id, abteilung_id, funktion_id, staatsangehörigkeit," +
                        " konfession, familienstand, anzahl_kinder, str_name, str_nr, plz, stadt, email, email_privat, telefon _mobil, telefon_festnetz, telefon_privat )" +
                        " VALUES (@rfid, @kuerzel, @personalnummer, @titel, @vorname, @vorname2, @nachname, @geschlecht, @beruf_id, @geburtsdatum, @einstellungsdatum," +
                        " @niederlassung_id, @abteilung_id, @funktion_id, @staatsangehörigkeit, @konfession, @familienstand, @anzahl_kinder, @str_name," +
                        " @str_nr, @plz, @stadt, @email, @email_privat, @telefon_mobil, @telefon_festnetz, @telefon_privat)");
                    command.Connection = conn;

                    command.Parameters.Add("@rfid", SqlDbType.VarChar, 10).Value = tb_rfid.Text;
                    command.Parameters.Add("@kuerzel", SqlDbType.VarChar, 3).Value = tb_kuerzel;
                    command.Parameters.Add("@personalnummer", SqlDbType.Int).Value = tb_personalnummer;
                    command.Parameters.Add("@titel", SqlDbType.VarChar, 25).Value = cb_titel;
                    command.Parameters.Add("@vorname", SqlDbType.VarChar, 25).Value = tb_vorname;
                    command.Parameters.Add("@vorname2", SqlDbType.VarChar, 25).Value = tb_zw_vorname;
                    command.Parameters.Add("@nachname", SqlDbType.VarChar, 25).Value = tb_nachname;
                    command.Parameters.Add("@geschlecht", SqlDbType.VarChar, 8).Value = tb_geschlecht;
                    command.Parameters.Add("@beruf_id", SqlDbType.Int).Value = cb_berufsbezeichnung;
                    command.Parameters.Add("@geburtsdatum", SqlDbType.Date).Value = tb_geburtstag;
                    command.Parameters.Add("@einstellungsdatum", SqlDbType.Date).Value = tb_einstellungsdatum;
                    command.Parameters.Add("@niederlassung_id", SqlDbType.Int).Value = cb_niederlassung;
                    command.Parameters.Add("@abteilung_id", SqlDbType.Int).Value = cb_abteilung;
                    command.Parameters.Add("@funktion_id", SqlDbType.Int).Value = cb_funktion;
                    command.Parameters.Add("@staatsangehörigkeit", SqlDbType.VarChar, 25).Value = cb_staatsangehörigkeit;
                    command.Parameters.Add("@konfession", SqlDbType.VarChar, 25).Value = cb_konfession;
                    command.Parameters.Add("@familienstand", SqlDbType.VarChar, 25).Value = cb_familienstand;
                    command.Parameters.Add("@anzahl_kinder", SqlDbType.TinyInt).Value = tb_kinder;
                    command.Parameters.Add("@str_name", SqlDbType.VarChar,25).Value = tb_straße;
                    command.Parameters.Add("@str_nr", SqlDbType.VarChar, 10).Value = tb_hausnummer;
                    command.Parameters.Add("@plz", SqlDbType.VarChar, 5).Value = tb_postleitzahl;
                    command.Parameters.Add("@stadt", SqlDbType.VarChar, 25).Value = tb_wohnort;
                    command.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = tb_email;
                    command.Parameters.Add("@email_privat", SqlDbType.VarChar, 50).Value = tb_priv_email;
                    command.Parameters.Add("@telefon_mobil", SqlDbType.VarChar, 25).Value = tb_tel_mobil;
                    command.Parameters.Add("@telefon_festnetz", SqlDbType.VarChar, 25).Value = tb_tel_fest;
                    command.Parameters.Add("@telefon_privat", SqlDbType.VarChar, 25).Value = tb_tel_priv;
                }
            }
            else
            { 
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO tbl_mitarbeiter (rfid, kuerzel, personalnummer, titel, vorname," +
                        " vorname2, nachname, geschlecht, beruf_id, geburtsdatum, einstellungsdatum, niederlassung_id, abteilung_id, funktion_id, staatsangehörigkeit," +
                        " konfession, familienstand, anzahl_kinder, str_name, str_nr, plz, stadt, email, email_privat, telefon _mobil, telefon_festnetz, telefon_privat )" +
                        " VALUES (@rfid, @kuerzel, @personalnummer, @titel, @vorname, @vorname2, @nachname, @geschlecht, @beruf_id, @geburtsdatum, @einstellungsdatum," +
                        " @niederlassung_id, @abteilung_id, @funktion_id, @staatsangehörigkeit, @konfession, @familienstand, @anzahl_kinder, @str_name," +
                        " @str_nr, @plz, @stadt, @email, @email_privat, @telefon_mobil, @telefon_festnetz, @telefon_privat)");
                    command.Connection = conn;
                }
            }
        }
    }
}
