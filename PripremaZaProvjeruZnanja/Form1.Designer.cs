
namespace PripremaZaProvjeruZnanja
{
    partial class lbl
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
            this.cmbVrsta = new System.Windows.Forms.ComboBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.rtbIspis = new System.Windows.Forms.RichTextBox();
            this.btnIspisi = new System.Windows.Forms.Button();
            this.trckSnaga = new System.Windows.Forms.TrackBar();
            this.dtpGodPro = new System.Windows.Forms.DateTimePicker();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.VrstaVozila = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.lblSnaga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trckSnaga)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbVrsta
            // 
            this.cmbVrsta.FormattingEnabled = true;
            this.cmbVrsta.Location = new System.Drawing.Point(81, 29);
            this.cmbVrsta.Name = "cmbVrsta";
            this.cmbVrsta.Size = new System.Drawing.Size(121, 21);
            this.cmbVrsta.TabIndex = 0;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(81, 68);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtNaziv.TabIndex = 1;
            // 
            // rtbIspis
            // 
            this.rtbIspis.Location = new System.Drawing.Point(403, 29);
            this.rtbIspis.Name = "rtbIspis";
            this.rtbIspis.Size = new System.Drawing.Size(299, 342);
            this.rtbIspis.TabIndex = 2;
            this.rtbIspis.Text = "";
            // 
            // btnIspisi
            // 
            this.btnIspisi.Location = new System.Drawing.Point(106, 309);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(156, 46);
            this.btnIspisi.TabIndex = 3;
            this.btnIspisi.Text = "Ispiši";
            this.btnIspisi.UseVisualStyleBackColor = true;
            this.btnIspisi.Click += new System.EventHandler(this.btnIspisi_Click);
            // 
            // trckSnaga
            // 
            this.trckSnaga.LargeChange = 20;
            this.trckSnaga.Location = new System.Drawing.Point(81, 191);
            this.trckSnaga.Maximum = 500;
            this.trckSnaga.Minimum = 50;
            this.trckSnaga.Name = "trckSnaga";
            this.trckSnaga.Size = new System.Drawing.Size(240, 45);
            this.trckSnaga.TabIndex = 4;
            this.trckSnaga.Value = 50;
            this.trckSnaga.Scroll += new System.EventHandler(this.trckSnaga_Scroll);
            // 
            // dtpGodPro
            // 
            this.dtpGodPro.Location = new System.Drawing.Point(121, 109);
            this.dtpGodPro.Name = "dtpGodPro";
            this.dtpGodPro.Size = new System.Drawing.Size(200, 20);
            this.dtpGodPro.TabIndex = 5;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(81, 152);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(100, 20);
            this.txtMarka.TabIndex = 6;
            this.txtMarka.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // VrstaVozila
            // 
            this.VrstaVozila.AutoSize = true;
            this.VrstaVozila.Location = new System.Drawing.Point(13, 37);
            this.VrstaVozila.Name = "VrstaVozila";
            this.VrstaVozila.Size = new System.Drawing.Size(64, 13);
            this.VrstaVozila.TabIndex = 7;
            this.VrstaVozila.Text = "Vrsta vozila:";
            this.VrstaVozila.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Naziv:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Godina Proizvodnje:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Marka:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Snaga:";
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(106, 242);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(156, 50);
            this.btnUnesi.TabIndex = 12;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // lblSnaga
            // 
            this.lblSnaga.AutoSize = true;
            this.lblSnaga.Location = new System.Drawing.Point(327, 201);
            this.lblSnaga.Name = "lblSnaga";
            this.lblSnaga.Size = new System.Drawing.Size(0, 13);
            this.lblSnaga.TabIndex = 13;
            this.lblSnaga.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 393);
            this.Controls.Add(this.lblSnaga);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VrstaVozila);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.dtpGodPro);
            this.Controls.Add(this.trckSnaga);
            this.Controls.Add(this.btnIspisi);
            this.Controls.Add(this.rtbIspis);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.cmbVrsta);
            this.Name = "lbl";
            this.Text = "Marka:";
            this.Load += new System.EventHandler(this.lbl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trckSnaga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVrsta;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.RichTextBox rtbIspis;
        private System.Windows.Forms.Button btnIspisi;
        private System.Windows.Forms.TrackBar trckSnaga;
        private System.Windows.Forms.DateTimePicker dtpGodPro;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label VrstaVozila;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Label lblSnaga;
    }
}

