namespace Kalkulator_dnevnice
{
    partial class deleteDay
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
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radnikBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.appDB1 = new Kalkulator_dnevnice.AppDB();
            this.label2 = new System.Windows.Forms.Label();
            this.radnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appDB = new Kalkulator_dnevnice.AppDB();
            this.radnikBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.radnikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.appDB1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.radnikTableAdapter = new Kalkulator_dnevnice.AppDBTableAdapters.RadnikTableAdapter();
            this.radniDanTableAdapter1 = new Kalkulator_dnevnice.AppDBTableAdapters.RadniDanTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radnikBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnikBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnikBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDB1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 30);
            this.button1.TabIndex = 37;
            this.button1.Text = "Obriši dan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Datum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Ispomoc druga";
            // 
            // radnikBindingSource2
            // 
            this.radnikBindingSource2.DataMember = "Radnik";
            this.radnikBindingSource2.DataSource = this.appDB1;
            // 
            // appDB1
            // 
            this.appDB1.DataSetName = "AppDB";
            this.appDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Druga smena";
            // 
            // radnikBindingSource
            // 
            this.radnikBindingSource.DataMember = "Radnik";
            this.radnikBindingSource.DataSource = this.appDB;
            // 
            // appDB
            // 
            this.appDB.DataSetName = "AppDB";
            this.appDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radnikBindingSource3
            // 
            this.radnikBindingSource3.DataMember = "Radnik";
            this.radnikBindingSource3.DataSource = this.appDB1;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(207, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 30);
            this.button2.TabIndex = 38;
            this.button2.Text = "Otkaži";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ispomoc prva";
            // 
            // radnikBindingSource1
            // 
            this.radnikBindingSource1.DataMember = "Radnik";
            this.radnikBindingSource1.DataSource = this.appDB1BindingSource;
            // 
            // appDB1BindingSource
            // 
            this.appDB1BindingSource.DataSource = this.appDB1;
            this.appDB1BindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Prva smena";
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(112, 29);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(80, 20);
            this.datePicker.TabIndex = 27;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // radnikTableAdapter
            // 
            this.radnikTableAdapter.ClearBeforeFill = true;
            // 
            // radniDanTableAdapter1
            // 
            this.radniDanTableAdapter1.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 20);
            this.textBox1.TabIndex = 39;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(14, 131);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(86, 20);
            this.textBox2.TabIndex = 40;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(207, 80);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(86, 20);
            this.textBox3.TabIndex = 41;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(207, 131);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(86, 20);
            this.textBox4.TabIndex = 42;
            // 
            // deleteDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 214);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datePicker);
            this.Name = "deleteDay";
            this.Text = "Brisanje dana";
            this.Load += new System.EventHandler(this.deleteDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radnikBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnikBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnikBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDB1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource radnikBindingSource2;
        private AppDB appDB1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource radnikBindingSource;
        private AppDB appDB;
        private System.Windows.Forms.BindingSource radnikBindingSource3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource radnikBindingSource1;
        private System.Windows.Forms.BindingSource appDB1BindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePicker;
        private AppDBTableAdapters.RadnikTableAdapter radnikTableAdapter;
        private AppDBTableAdapters.RadniDanTableAdapter radniDanTableAdapter1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}