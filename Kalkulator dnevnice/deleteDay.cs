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
namespace Kalkulator_dnevnice
{

    public partial class deleteDay : Form
    {
        
        string prvaSmenaComm = "SELECT R.Ime from Radnik R inner join RadniDan RD on RD.PrvaSmena = R.ID WHERE (RD.Datum = @Datum)";
        string drugaSmenaComm = "SELECT R.Ime from Radnik R inner join RadniDan RD on RD.DrugaSmena = R.ID WHERE (RD.Datum = @Datum)";
        string prvaIspomocComm = "SELECT R.Ime from Radnik R inner join RadniDan RD on RD.IspomocPrva = R.ID WHERE (RD.Datum = @Datum)";
        string drugaIspomocComm = "SELECT R.Ime from Radnik R inner join RadniDan RD on RD.IspomocDruga = R.ID WHERE (RD.Datum = @Datum)";
        string dbPath = Application.StartupPath + @"\KaficDnevniceKalkulator.mdb";
        string deleteDayString = "DELETE FROM RadniDan WHERE Datum = ?";
        public deleteDay()
            {
                InitializeComponent();
            }
        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            string connString = String.Format("Provider=Microsoft.ACE.OLEDB.12.0; Data Source={0}", dbPath);
            DateTime Date = datePicker.Value.Date;

            using (OleDbConnection con = new OleDbConnection(connString))
            {
                using (OleDbCommand cmd = new OleDbCommand(prvaSmenaComm, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@Datum", Date);
                    OleDbDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        textBox1.Text = rdr.GetValue(0).ToString();
                    }
                    else
                        textBox1.Text = "";
                }
                using (OleDbCommand cmd1 = new OleDbCommand(drugaSmenaComm, con))
                {
                    cmd1.Parameters.AddWithValue("@Datum", Date);
                    OleDbDataReader rdr1 = cmd1.ExecuteReader();
                    if (rdr1.Read())
                    {
                        textBox2.Text = rdr1.GetValue(0).ToString();
                    }
                    else textBox2.Text = "";
                }
                using (OleDbCommand cmd2 = new OleDbCommand(prvaIspomocComm, con))
                {
                    cmd2.Parameters.AddWithValue("@Datum", Date);
                    OleDbDataReader rdr2 = cmd2.ExecuteReader();
                    if (rdr2.Read())
                    {
                        textBox3.Text = rdr2.GetValue(0).ToString();
                    }
                    else textBox3.Text = "";
                }
                using (OleDbCommand cmd3 = new OleDbCommand(drugaIspomocComm, con))
                {
                    cmd3.Parameters.AddWithValue("@Datum", Date);
                    OleDbDataReader rdr3 = cmd3.ExecuteReader();
                    if (rdr3.Read())
                    {
                        textBox4.Text = rdr3.GetValue(0).ToString();
                    }
                    else textBox4.Text = "";
                }
                con.Close();
            }


        }
        private void deleteDay_Load(object sender, EventArgs e)
        {
            datePicker_ValueChanged(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = String.Format("Provider=Microsoft.ACE.OLEDB.12.0; Data Source={0}", dbPath);
            DateTime Date = datePicker.Value.Date;

            using (OleDbConnection con = new OleDbConnection(connString))
            {
                using (OleDbCommand cmd = new OleDbCommand(deleteDayString, con))
                {
                    try
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@Datum", Date);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex) { 
                        MessageBox.Show(ex.Message);
                    }
                    
                }
            }
        }
    }
}
