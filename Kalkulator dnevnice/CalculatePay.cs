using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing.Printing;
namespace Kalkulator_dnevnice
{
    public partial class CalculatePay : Form
    {
        string dbPath = Application.StartupPath + @"\KaficDnevniceKalkulator.mdb";
        string PrvaSmena = "select count(PrvaSmena) as PS, SUM(Bonus) as bs  from radnidan where datum between ? and ? and prvasmena = ?";
        string DrugaSmena = "select count(DrugaSmena) as DS, SUM(Bonus) as bs  from radnidan where datum between ? and ? and drugasmena = ?";
        string PrvaIspomoc = "select count(IspomocPrva) as IP from radnidan where datum between ? and ? and ispomocprva = ?";
        string DrugaIspomoc = "select count(IspomocDruga) as ID from radnidan where datum between ? and ? and ispomocdruga  = ?";

        int PareSmene = 0, PareIspomoc = 0;
        Int32 Bonus = 0;
        int Pare;
        public CalculatePay()
        {
            InitializeComponent();
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CalculatePay_Load(object sender, EventArgs e)
        {
            if (PrinterSettings.InstalledPrinters.Count <= 0)
            {
                MessageBox.Show("Štampac nije pronađen!");
                return;
            } 
            foreach (String printer in PrinterSettings.InstalledPrinters)
            {
                printersCB.Items.Add(printer.ToString());
            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();

            //Set PrinterName as the selected printer in the printers list  
            pd.PrinterSettings.PrinterName =
            printersCB.SelectedItem.ToString();
            
            //Add PrintPage event handler  
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);

            //Print the document  
            pd.Print();
        }
        public void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {

            //Get the Graphics object  
            Graphics g = ev.Graphics;

            //Create a font Arial with size 16  
            Font font = new Font("Arial", 16);

            //Create a solid brush with black color  
            SolidBrush brush = new SolidBrush(Color.Black);

            string dnevnice = string.Format("Stefa {0}," + Environment.NewLine +
                "Stefa DL {1}, " + Environment.NewLine +
                "Kezman {2}, " + Environment.NewLine +
                "Fica {3}, " + Environment.NewLine +
                "Nemanja {4}, " + Environment.NewLine +
                "Petra {5}, " + Environment.NewLine +
                "Milica {6}, " + Environment.NewLine +
                "Nina {7}, " + Environment.NewLine +
                "Andjela {8}", StefaTb.Text, StefaDLTb.Text, KezmanTb.Text, FicaTb.Text, NemanjaTb.Text, PetraTb.Text, MilicaTb.Text, NinaTb.Text, AndjelaTb.Text);
            MessageBox.Show(dnevnice);
            //Draw "Hello Printer!"; 
            g.DrawRectangle(Pens.Black, new Rectangle(20, 20, 200, 250));
            g.DrawString(dnevnice,
            font, brush,
            new Rectangle(20, 20, 200, 250));
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            string connString = String.Format("Provider=Microsoft.ACE.OLEDB.12.0; Data Source={0}", dbPath);
            int i = 1;
            using (OleDbConnection con = new OleDbConnection(connString))
            {
                TextBox[] tbArray = { StefaTb, StefaDLTb, KezmanTb, FicaTb, NemanjaTb, PetraTb, MilicaTb, NinaTb, AndjelaTb };
                con.Open();
                while (i <= 9) {
                    using (OleDbCommand cmd = new OleDbCommand(PrvaSmena, con))
                    {
                        cmd.Parameters.AddWithValue("@Datum", DateTime.Parse(DatumOd.Text).AddDays(-1));
                        cmd.Parameters.AddWithValue("@Datum", DateTime.Parse(DatumDo.Text).AddDays(-1));
                        cmd.Parameters.AddWithValue("@ID", i);
                        OleDbDataReader rdr = cmd.ExecuteReader();
                        while (rdr.Read()) {
                            PareSmene += Int32.Parse(rdr.GetValue(0).ToString());
                            int newBonus;
                            if (int.TryParse(rdr.GetValue(1).ToString(), out newBonus))
                            {
                                Bonus += newBonus;
                            }
                        }
                    }
                    using (OleDbCommand cmd1 = new OleDbCommand(DrugaSmena, con))
                    {
                        cmd1.Parameters.AddWithValue("@Datum", DateTime.Parse(DatumOd.Text).AddDays(-1));
                        cmd1.Parameters.AddWithValue("@Datum", DateTime.Parse(DatumDo.Text).AddDays(-1));
                        cmd1.Parameters.AddWithValue("@ID", i);
                        OleDbDataReader rdr1 = cmd1.ExecuteReader();
                        while (rdr1.Read())
                        {
                            
                            PareSmene += Int32.Parse(rdr1.GetValue(0).ToString());
                            int newBonus;
                            if (int.TryParse(rdr1.GetValue(1).ToString(), out newBonus))
                            {
                                Bonus += newBonus;
                            }
                        }
                    }
                    using (OleDbCommand cmd2 = new OleDbCommand(PrvaIspomoc, con))
                    {
                        cmd2.Parameters.AddWithValue("@Datum", DateTime.Parse(DatumOd.Text).AddDays(-1));
                        cmd2.Parameters.AddWithValue("@Datum", DateTime.Parse(DatumDo.Text).AddDays(-1));
                        cmd2.Parameters.AddWithValue("@ID", i);
                        OleDbDataReader rdr2 = cmd2.ExecuteReader();
                        while (rdr2.Read())
                        {
                            PareIspomoc += Int32.Parse(rdr2.GetValue(0).ToString());
                        }
                    }
                    using (OleDbCommand cmd3 = new OleDbCommand(DrugaIspomoc, con))
                    {
                        cmd3.Parameters.AddWithValue("@Datum", DateTime.Parse(DatumOd.Text).AddDays(-1));
                        cmd3.Parameters.AddWithValue("@Datum", DateTime.Parse(DatumDo.Text).AddDays(-1));
                        cmd3.Parameters.AddWithValue("@ID", i);
                        OleDbDataReader rdr3 = cmd3.ExecuteReader();
                        while (rdr3.Read())
                        {
                            PareIspomoc += Int32.Parse(rdr3.GetValue(0).ToString());
                        }
                        
                        
                    }
                    switch (i)
                    {
                        case 3:
                            Pare = PareSmene * 1550 + PareIspomoc * 700 + (Bonus / 2);
                            tbArray[i-1].Text = Pare.ToString();
                            
                            Pare = 0;
                            PareSmene = 0;
                            PareIspomoc = 0;
                            i++;
                            break;
                        default:
                            Pare = PareSmene * 1350 + PareIspomoc * 700 + (Bonus / 2);
                            tbArray[i-1].Text = Pare.ToString();
                            
                            Pare = 0;
                            PareSmene = 0;
                            PareIspomoc = 0;
                            Bonus = 0;
                            i++;
                            break ;

                    }
                }
                con.Close();
            }
        }
    }
}
