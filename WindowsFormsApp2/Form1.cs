using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Configuration;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form


    {
        public Form1()
        {
            InitializeComponent();

            //connectionString = ConfigurationManager.ConnectionStrings["Server=.\\SQLEXPRESS;Database=GfA_Database;Integrated Security=true"].ConnectionString;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            SqlConnection conn = new SqlConnection("Server =.\\SQLEXPRESS; Database = GfA_Database; Integrated Security = true");
            conn.Open();
           // SqlCommand cmd = new SqlCommand("SELECT Login, date, duration, projectnumber, description, taskid FROM Log_Data", conn);
            //SqlDataReader reader = cmd.ExecuteReader();
            

            /*while (reader.Read())

            {

                String value = reader.GetString(1);
                Char delimiter = '-';
                String[] substrings = value.Split(delimiter);

                int Month = 0;
                Int32.TryParse(substrings[1], out Month);
                int Day = 0;
                Int32.TryParse(substrings[2], out Day);

                String Login = reader.GetString(0);
                Microsoft.Office.Interop.Excel.Workbook sheet = excel.Workbooks.Open("C:\\Users\\janni\\Stn_" + reader.GetString(0) + ".xlsx");
                //Microsoft.Office.Interop.Excel.Worksheet x = excel.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;
                Microsoft.Office.Interop.Excel.Worksheet x = (Excel.Worksheet)sheet.Worksheets.get_Item(Month);
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", reader.GetString(0), reader.GetString(1), reader.GetFloat(2), reader.GetString(3), reader.GetString(4), reader.GetInt32(5));

                int spalte = 20;
                int zeile = Day + 7;


                for (int i = 1; i < 10; i++)
                {
                    string Excel_Projectnumber = x.Cells[4, spalte].Value == null ? "-" : x.Cells[4, spalte].Value.ToString();
                    if (Excel_Projectnumber == "-")
                    {
                        x.Cells[4, spalte] = reader.GetString(3);
                        x.Cells[5, spalte] = reader.GetString(4);
                        x.Cells[zeile, spalte + reader.GetInt32(5) - 1] = reader.GetFloat(2);
                        break;
                    }
                    else if (Excel_Projectnumber == reader.GetString(3))
                    {
                        x.Cells[zeile, spalte + reader.GetInt32(5) - 1] = reader.GetFloat(2);
                        break;
                    }
                    {
                        spalte = spalte + 10;
                    }

                }
                sheet.Close(true, Type.Missing, Type.Missing);
            }*/

            //reader.Close();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Log_Data", conn);
            DataTable Tabelle = new DataTable();
            adapter.Fill(Tabelle);

            Listtest.DataSource = Tabelle;
            Listtest.DisplayMember = "Login";
            Listtest.ValueMember = "ID";


            excel.Quit();
            conn.Close();

            if (Debugger.IsAttached)
            {
                Console.ReadLine();
            }
        }

        private void Import_Reisezeit_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            using (SqlConnection conn = new SqlConnection("Server =.\\SQLEXPRESS; Database = GfA_Database; Integrated Security = true"))
            {
              /*  int Month = 0;
                Int32.TryParse(substrings[1], out Month);
                int Day = 0;
                Int32.TryParse(substrings[2], out Day);

                String Login = reader.GetString(0);*/
                //Microsoft.Office.Interop.Excel.Workbook sheet = excel.Workbooks.Open("C:\\Users\\janni\\Stn_" + reader.GetString(0) + ".xlsx");
                //Microsoft.Office.Interop.Excel.Worksheet x = (Excel.Worksheet)sheet.Worksheets.get_Item(Month);



                SqlCommand command = new SqlCommand("INSERT INTO tbl_log VALUES (2)", conn);
                command.Connection.Open();
                command.ExecuteNonQuery();

            }
        

            if (Debugger.IsAttached)
            {
                Console.ReadLine();
            }
        }

        private void Aktualisieren_Click(object sender, EventArgs e)
        {
            try
            {
                var files = from file in Directory.EnumerateFiles(@"C:\users\janni", "*.xlsx", SearchOption.TopDirectoryOnly)
                            //from line in File.read(file)
                            where file.Contains("Reisezeit")
                            select new
                            {
                                File = file,
                                //Line = line
                            };

                foreach (var f in files)
                {
                    TestFiles.Items.Add(f.File);
                }
            tb1.Text = files.Count().ToString() + " files found.";
            }

            catch (UnauthorizedAccessException UAEx)
            {
                tb1.Text = UAEx.Message;
            }
            catch (PathTooLongException PathEx)
            {
                tb1.Text = PathEx.Message;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
