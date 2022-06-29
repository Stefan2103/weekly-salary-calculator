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
    public partial class newDay : Form
    {
        int Bonus = 0;
        string dbPath = Application.StartupPath + @"\KaficDnevniceKalkulator.mdb";
        string newDayString = "INSERT INTO RadniDan (Datum, PrvaSmena, DrugaSmena, IspomocPrva, IspomocDruga, Bonus) VALUES (?, ?, ?, ?, ?, ?)";
        public newDay()
        {
            InitializeComponent();
        }

        private void newDay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appDB1.Radnik' table. You can move, or remove it, as needed.
            this.radnikTableAdapter.Fill(this.appDB1.Radnik);
            // TODO: This line of code loads data into the 'appDB1.Radnik' table. You can move, or remove it, as needed.
            this.radnikTableAdapter.Fill(this.appDB1.Radnik);
            // TODO: This line of code loads data into the 'appDB1.Radnik' table. You can move, or remove it, as needed.
            this.radnikTableAdapter.Fill(this.appDB1.Radnik);
            // TODO: This line of code loads data into the 'appDB.Radnik' table. You can move, or remove it, as needed.
            this.radnikTableAdapter.Fill(this.appDB.Radnik);
            datePicker.Value = DateTime.Now.Date;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = String.Format("Provider=Microsoft.ACE.OLEDB.12.0; Data Source={0}", dbPath);
            using (OleDbConnection con = new OleDbConnection(connString))
            {
                con.Open();
                try
                {
                    if (bonusTB.Text.Length > 0)
                    {
                        Bonus = Int32.Parse(bonusTB.Text);
                        OleDbCommand cmd = new OleDbCommand(newDayString, con);
                        cmd.Parameters.AddWithValue("@Datum", datePicker.Value);
                        cmd.Parameters.AddWithValue("@PS", comboBox1.SelectedIndex + 1);
                        cmd.Parameters.AddWithValue("@DS", comboBox2.SelectedIndex + 1);
                        cmd.Parameters.AddWithValue("@PI", comboBox3.SelectedIndex + 1);
                        cmd.Parameters.AddWithValue("@DI", comboBox4.SelectedIndex + 1);
                        cmd.Parameters.AddWithValue("@Bonus", Bonus);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Uspesno napravljen dan!");
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        if (MessageBox.Show("Niste dodali bonus, da li želite da dodate dan bez bonusa?", "Upozorenje", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            Bonus = 0;
                            OleDbCommand cmd = new OleDbCommand(newDayString, con);
                            cmd.Parameters.AddWithValue("@Datum", datePicker.Value);
                            cmd.Parameters.AddWithValue("@PS", comboBox1.SelectedIndex + 1);
                            cmd.Parameters.AddWithValue("@DS", comboBox2.SelectedIndex + 1);
                            cmd.Parameters.AddWithValue("@PI", comboBox3.SelectedIndex + 1);
                            cmd.Parameters.AddWithValue("@DI", comboBox4.SelectedIndex + 1);
                            cmd.Parameters.AddWithValue("@Bonus", Bonus);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Uspesno napravljen dan!");
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            bonusTB.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
