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
using System.IO;
namespace Kalkulator_dnevnice
{
    public partial class Form1 : Form
    {
        string dbPath = Application.StartupPath + @"\KaficDnevniceKalkulator.mdb";


        string prvaSmenaComm = "SELECT R.Ime from Radnik R inner join RadniDan RD on RD.PrvaSmena = R.ID WHERE (RD.Datum = @Datum)";
        string drugaSmenaComm = "SELECT R.Ime from Radnik R inner join RadniDan RD on RD.DrugaSmena = R.ID WHERE (RD.Datum = @Datum)";
        string prvaIspomocComm = "SELECT R.Ime from Radnik R inner join RadniDan RD on RD.IspomocPrva = R.ID WHERE (RD.Datum = @Datum)";
        string drugaIspomocComm = "SELECT R.Ime from Radnik R inner join RadniDan RD on RD.IspomocDruga = R.ID WHERE (RD.Datum = @Datum)";
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            string connString = String.Format("Provider=Microsoft.ACE.OLEDB.12.0; Data Source={0}", dbPath);
            DateTime Date = DateTime.Now.Date;
            using (OleDbConnection con = new OleDbConnection(connString))
            {
                con.Open();
                using (OleDbCommand cmd = new OleDbCommand(prvaSmenaComm, con))
                {
                    cmd.Parameters.AddWithValue("@Datum", Date);
                    OleDbDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        prvaSmenaTB.Text = rdr.GetValue(0).ToString();
                    }
                }
                using (OleDbCommand cmd1 = new OleDbCommand(drugaSmenaComm, con))
                {
                    cmd1.Parameters.AddWithValue("@Datum", Date);
                    OleDbDataReader rdr1 = cmd1.ExecuteReader();
                    while (rdr1.Read())
                    {
                        drugaSmenaTB.Text = rdr1.GetValue(0).ToString();
                    }
                }
                using (OleDbCommand cmd2 = new OleDbCommand(prvaIspomocComm, con))
                {
                    cmd2.Parameters.AddWithValue("@Datum", Date);
                    OleDbDataReader rdr2 = cmd2.ExecuteReader();
                    while (rdr2.Read())
                    {
                        PrvaIspomocTB.Text = rdr2.GetValue(0).ToString();
                    }
                }
                using (OleDbCommand cmd3 = new OleDbCommand(drugaIspomocComm, con))
                {
                    cmd3.Parameters.AddWithValue("@Datum", Date);
                    OleDbDataReader rdr3 = cmd3.ExecuteReader();
                    while (rdr3.Read())
                    {
                        DrugaIspomocTB.Text = rdr3.GetValue(0).ToString();
                    }
                }
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newDay newDay = new newDay();
            if (newDay.ShowDialog() == DialogResult.OK)
            {
                this.dateTimePicker1_ValueChanged(sender, e);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string connString = String.Format("Provider=Microsoft.ACE.OLEDB.12.0; Data Source={0}", dbPath);
            DateTime Date = dateTimePicker1.Value.Date;

            using (OleDbConnection con = new OleDbConnection(connString))
            {
                using (OleDbCommand cmd = new OleDbCommand(prvaSmenaComm, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@Datum", Date);
                    OleDbDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        prvaSmenaTB.Text = rdr.GetValue(0).ToString();
                    }
                    else
                        prvaSmenaTB.Text = "";
                }
                using (OleDbCommand cmd1 = new OleDbCommand(drugaSmenaComm, con))
                {
                    cmd1.Parameters.AddWithValue("@Datum", Date);
                    OleDbDataReader rdr1 = cmd1.ExecuteReader();
                    if (rdr1.Read())
                    {
                        drugaSmenaTB.Text = rdr1.GetValue(0).ToString();
                    }
                    else drugaSmenaTB.Text = "";
                }
                using (OleDbCommand cmd2 = new OleDbCommand(prvaIspomocComm, con))
                {
                    cmd2.Parameters.AddWithValue("@Datum", Date);
                    OleDbDataReader rdr2 = cmd2.ExecuteReader();
                    if (rdr2.Read())
                    {
                        PrvaIspomocTB.Text = rdr2.GetValue(0).ToString();
                    }
                    else PrvaIspomocTB.Text = "";
                }
                using (OleDbCommand cmd3 = new OleDbCommand(drugaIspomocComm, con))
                {
                    cmd3.Parameters.AddWithValue("@Datum", Date);
                    OleDbDataReader rdr3 = cmd3.ExecuteReader();
                    if (rdr3.Read())
                    {
                        DrugaIspomocTB.Text = rdr3.GetValue(0).ToString();
                    }
                    else DrugaIspomocTB.Text = "";
                }
                con.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            editDay editDay = new editDay();
            if(editDay.ShowDialog() == DialogResult.OK)
            {
                this.dateTimePicker1_ValueChanged(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CalculatePay calc = new CalculatePay();
            if(calc.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void deldayBtn_Click(object sender, EventArgs e)
        {
            deleteDay delDay = new deleteDay();
            if(delDay.ShowDialog() == DialogResult.OK)
            {
                this.dateTimePicker1_ValueChanged(sender, e);
            }
        }
    }
}
