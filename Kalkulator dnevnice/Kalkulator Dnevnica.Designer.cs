
namespace Kalkulator_dnevnice
{
    partial class Form1
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.prvaSmenaTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.drugaSmenaTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PrvaIspomocTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DrugaIspomocTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radniDanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appDB = new Kalkulator_dnevnice.AppDB();
            this.radniDanTableAdapter = new Kalkulator_dnevnice.AppDBTableAdapters.RadniDanTableAdapter();
            this.radnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radnikTableAdapter = new Kalkulator_dnevnice.AppDBTableAdapters.RadnikTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.deldayBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.radniDanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "NOVI RADNI DAN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(12, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 100);
            this.button2.TabIndex = 1;
            this.button2.Text = "ISPRAVI RADNI DAN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(259, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 100);
            this.button3.TabIndex = 2;
            this.button3.Text = "IZRAČUNAJ DNEVNICE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // prvaSmenaTB
            // 
            this.prvaSmenaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prvaSmenaTB.Location = new System.Drawing.Point(259, 38);
            this.prvaSmenaTB.Multiline = true;
            this.prvaSmenaTB.Name = "prvaSmenaTB";
            this.prvaSmenaTB.Size = new System.Drawing.Size(170, 28);
            this.prvaSmenaTB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Prva smena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Druga smena";
            // 
            // drugaSmenaTB
            // 
            this.drugaSmenaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drugaSmenaTB.Location = new System.Drawing.Point(259, 115);
            this.drugaSmenaTB.Multiline = true;
            this.drugaSmenaTB.Name = "drugaSmenaTB";
            this.drugaSmenaTB.Size = new System.Drawing.Size(170, 28);
            this.drugaSmenaTB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(502, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prva ispomoc";
            // 
            // PrvaIspomocTB
            // 
            this.PrvaIspomocTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrvaIspomocTB.Location = new System.Drawing.Point(494, 38);
            this.PrvaIspomocTB.Multiline = true;
            this.PrvaIspomocTB.Name = "PrvaIspomocTB";
            this.PrvaIspomocTB.Size = new System.Drawing.Size(170, 28);
            this.PrvaIspomocTB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(502, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Druga ispomoc";
            // 
            // DrugaIspomocTB
            // 
            this.DrugaIspomocTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrugaIspomocTB.Location = new System.Drawing.Point(494, 115);
            this.DrugaIspomocTB.Multiline = true;
            this.DrugaIspomocTB.Name = "DrugaIspomocTB";
            this.DrugaIspomocTB.Size = new System.Drawing.Size(170, 28);
            this.DrugaIspomocTB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(502, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Datum";
            // 
            // radniDanBindingSource
            // 
            this.radniDanBindingSource.DataSource = this.appDB;
            this.radniDanBindingSource.Position = 0;
            // 
            // appDB
            // 
            this.appDB.DataSetName = "AppDB";
            this.appDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radniDanTableAdapter
            // 
            this.radniDanTableAdapter.ClearBeforeFill = true;
            // 
            // radnikBindingSource
            // 
            this.radnikBindingSource.DataMember = "Radnik";
            this.radnikBindingSource.DataSource = this.appDB;
            // 
            // radnikTableAdapter
            // 
            this.radnikTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(494, 207);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 31);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // deldayBtn
            // 
            this.deldayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deldayBtn.Location = new System.Drawing.Point(642, 244);
            this.deldayBtn.Name = "deldayBtn";
            this.deldayBtn.Size = new System.Drawing.Size(22, 23);
            this.deldayBtn.TabIndex = 14;
            this.deldayBtn.Text = "X";
            this.deldayBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deldayBtn.UseVisualStyleBackColor = true;
            this.deldayBtn.Click += new System.EventHandler(this.deldayBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 271);
            this.Controls.Add(this.deldayBtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DrugaIspomocTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrvaIspomocTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.drugaSmenaTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prvaSmenaTB);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Kalkulator dnevnica";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radniDanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private AppDB appDB;
        private System.Windows.Forms.BindingSource radniDanBindingSource;
        private AppDBTableAdapters.RadniDanTableAdapter radniDanTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox prvaSmenaTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox drugaSmenaTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PrvaIspomocTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DrugaIspomocTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource radnikBindingSource;
        private AppDBTableAdapters.RadnikTableAdapter radnikTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button deldayBtn;
    }
}

