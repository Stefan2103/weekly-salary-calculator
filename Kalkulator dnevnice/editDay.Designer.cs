namespace Kalkulator_dnevnice
{
    partial class editDay
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
            this.components = new System.ComponentModel.Container();
            this.radniDanTableAdapter1 = new Kalkulator_dnevnice.AppDBTableAdapters.RadniDanTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.radnikTableAdapter = new Kalkulator_dnevnice.AppDBTableAdapters.RadnikTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.radnikBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.appDB1 = new Kalkulator_dnevnice.AppDB();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.radnikBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.appDB1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.radnikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.appDB = new Kalkulator_dnevnice.AppDB();
            this.radnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.bonusTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radnikBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnikBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDB1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnikBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // radniDanTableAdapter1
            // 
            this.radniDanTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 30);
            this.button1.TabIndex = 25;
            this.button1.Text = "Napravi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Datum";
            // 
            // radnikTableAdapter
            // 
            this.radnikTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ispomoc druga";
            // 
            // radnikBindingSource3
            // 
            this.radnikBindingSource3.DataMember = "Radnik";
            this.radnikBindingSource3.DataSource = this.appDB1;
            // 
            // appDB1
            // 
            this.appDB1.DataSetName = "AppDB";
            this.appDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.radnikBindingSource3;
            this.comboBox4.DisplayMember = "Ime";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(172, 126);
            this.comboBox4.MaxDropDownItems = 9;
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 23;
            this.comboBox4.ValueMember = "ID";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // radnikBindingSource2
            // 
            this.radnikBindingSource2.DataMember = "Radnik";
            this.radnikBindingSource2.DataSource = this.appDB1;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(207, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 30);
            this.button2.TabIndex = 26;
            this.button2.Text = "Otkaži";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.radnikBindingSource2;
            this.comboBox3.DisplayMember = "Ime";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(172, 80);
            this.comboBox3.MaxDropDownItems = 9;
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 21;
            this.comboBox3.ValueMember = "ID";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // appDB1BindingSource
            // 
            this.appDB1BindingSource.DataSource = this.appDB1;
            this.appDB1BindingSource.Position = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ispomoc prva";
            // 
            // radnikBindingSource1
            // 
            this.radnikBindingSource1.DataMember = "Radnik";
            this.radnikBindingSource1.DataSource = this.appDB1BindingSource;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.radnikBindingSource1;
            this.comboBox2.DisplayMember = "Ime";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(14, 126);
            this.comboBox2.MaxDropDownItems = 9;
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.ValueMember = "ID";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // appDB
            // 
            this.appDB.DataSetName = "AppDB";
            this.appDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radnikBindingSource
            // 
            this.radnikBindingSource.DataMember = "Radnik";
            this.radnikBindingSource.DataSource = this.appDB;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Druga smena";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.radnikBindingSource;
            this.comboBox1.DisplayMember = "Ime";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(14, 80);
            this.comboBox1.MaxDropDownItems = 9;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.ValueMember = "ID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Prva smena";
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(112, 29);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(80, 20);
            this.datePicker.TabIndex = 15;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // bonusTB
            // 
            this.bonusTB.Location = new System.Drawing.Point(112, 177);
            this.bonusTB.Name = "bonusTB";
            this.bonusTB.Size = new System.Drawing.Size(80, 20);
            this.bonusTB.TabIndex = 27;
            this.bonusTB.TextChanged += new System.EventHandler(this.bonusTB_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Bonus";
            // 
            // editDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 214);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bonusTB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datePicker);
            this.Name = "editDay";
            this.Text = "Izmeni dan";
            this.Load += new System.EventHandler(this.editDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radnikBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnikBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDB1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnikBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppDBTableAdapters.RadniDanTableAdapter radniDanTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private AppDBTableAdapters.RadnikTableAdapter radnikTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource radnikBindingSource3;
        private AppDB appDB1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.BindingSource radnikBindingSource2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource appDB1BindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource radnikBindingSource1;
        private System.Windows.Forms.ComboBox comboBox2;
        private AppDB appDB;
        private System.Windows.Forms.BindingSource radnikBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox bonusTB;
        private System.Windows.Forms.Label label6;
    }
}