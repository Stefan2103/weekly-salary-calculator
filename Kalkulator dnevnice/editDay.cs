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
    public partial class editDay : Form
    {
        int PrvaSmena, DrugaSmena, IspomocPrva, IspomocDruga, Bonus;
        string CommString = "SELECT PrvaSmena, DrugaSmena, IspomocPrva, IspomocDruga, Bonus from RadniDan RD WHERE (RD.Datum = @Datum)";
        string UpdateString = "UPDATE RadniDan SET PrvaSmena = ?, DrugaSmena = ?, IspomocPrva = ?, IspomocDruga = ?, Bonus = ? WHERE Datum = ?";
        string dbPath = Application.StartupPath + @"\KaficDnevniceKalkulator.mdb";
        public editDay()
        {
            InitializeComponent();
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime Date = datePicker.Value.Date;
            string connString = String.Format("Provider=Microsoft.ACE.OLEDB.12.0; Data Source={0}", dbPath);
            using (OleDbConnection con = new OleDbConnection(connString))
            {   
                con.Open();
                using (OleDbCommand cmd = new OleDbCommand(CommString, con))
                {
                    cmd.Parameters.AddWithValue("@Datum", Date);
                    OleDbDataReader rdr = cmd.ExecuteReader();
                    if(rdr.Read())
                    {
                        comboBox1.SelectedIndex = PrvaSmena = Int32.Parse(rdr.GetValue(0).ToString()) - 1;
                        comboBox2.SelectedIndex = DrugaSmena =  Int32.Parse(rdr.GetValue(1).ToString()) - 1;
                        comboBox3.SelectedIndex = IspomocPrva = Int32.Parse(rdr.GetValue(2).ToString()) - 1; 
                        comboBox4.SelectedIndex = IspomocDruga = Int32.Parse(rdr.GetValue(3).ToString()) - 1;
                        Bonus = Int32.Parse(rdr.GetValue(4).ToString());
                        bonusTB.Text = Bonus.ToString();
                    }
                    else
                    {
                        comboBox1.SelectedIndex = -1;
                        comboBox2.SelectedIndex = -1;
                        comboBox3.SelectedIndex = -1;
                        comboBox4.SelectedIndex = -1;
                        bonusTB.Text = "";
                    }
                }
                con.Close();
            }
        }

        private void editDay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appDB1.Radnik' table. You can move, or remove it, as needed.
            this.radnikTableAdapter.Fill(this.appDB1.Radnik);
            // TODO: This line of code loads data into the 'appDB1.Radnik' table. You can move, or remove it, as needed.
            this.radnikTableAdapter.Fill(this.appDB1.Radnik);
            // TODO: This line of code loads data into the 'appDB1.Radnik' table. You can move, or remove it, as needed.
            this.radnikTableAdapter.Fill(this.appDB1.Radnik);
            // TODO: This line of code loads data into the 'appDB.Radnik' table. You can move, or remove it, as needed.
            this.radnikTableAdapter.Fill(this.appDB.Radnik);

            datePicker_ValueChanged(sender, e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string connString = String.Format("Provider=Microsoft.ACE.OLEDB.12.0; Data Source={0}", dbPath);
            using (OleDbConnection con = new OleDbConnection(connString))
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand(UpdateString, con);
                    cmd.Parameters.AddWithValue("@PrvaSmena", PrvaSmena + 1);
                    cmd.Parameters.AddWithValue("@DrugaSmena", DrugaSmena + 1);
                    cmd.Parameters.AddWithValue("@IspomocPrva", IspomocPrva + 1);
                    cmd.Parameters.AddWithValue("@IspomocDruga", IspomocDruga + 1);
                    cmd.Parameters.AddWithValue("@Bonus", Bonus);
                    cmd.Parameters.AddWithValue("@Datum", datePicker.Value.Date);
                    
                    try {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Uspešno izmenjeno!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    con.Close();
                }
                DialogResult = DialogResult.OK;
        }

        private void bonusTB_TextChanged(object sender, EventArgs e)
        {
            Bonus = Int32.Parse(bonusTB.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrvaSmena = comboBox1.SelectedIndex;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrugaSmena = comboBox2.SelectedIndex;
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            IspomocPrva = comboBox3.SelectedIndex;
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            IspomocDruga = comboBox4.SelectedIndex;
        }
    }
}
