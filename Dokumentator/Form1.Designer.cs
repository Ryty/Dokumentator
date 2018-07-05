namespace Dokumentator
{
    partial class Dokumentator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnZus = new System.Windows.Forms.Button();
            this.btnKpir = new System.Windows.Forms.Button();
            this.btnUpl = new System.Windows.Forms.Button();
            this.btnVatr = new System.Windows.Forms.Button();
            this.btnKwe = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.fldName = new System.Windows.Forms.TextBox();
            this.fldNip = new System.Windows.Forms.TextBox();
            this.fldDate = new System.Windows.Forms.DateTimePicker();
            this.fldPesel = new System.Windows.Forms.TextBox();
            this.chkMale = new System.Windows.Forms.CheckBox();
            this.chkFemale = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.fldStreet = new System.Windows.Forms.TextBox();
            this.fldCity = new System.Windows.Forms.TextBox();
            this.fldNrdom = new System.Windows.Forms.TextBox();
            this.fldNrmiesz = new System.Windows.Forms.TextBox();
            this.fldPostal = new System.Windows.Forms.TextBox();
            this.fldCountry = new System.Windows.Forms.TextBox();
            this.fldGmina = new System.Windows.Forms.TextBox();
            this.fldPowiat = new System.Windows.Forms.TextBox();
            this.fldPoczta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnZus, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnKpir, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUpl, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnVatr, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnKwe, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 310);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(649, 56);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnZus
            // 
            this.btnZus.Location = new System.Drawing.Point(3, 3);
            this.btnZus.Name = "btnZus";
            this.btnZus.Size = new System.Drawing.Size(123, 50);
            this.btnZus.TabIndex = 31;
            this.btnZus.Text = "Generuj pełnomocnictwo ZUS";
            this.btnZus.UseVisualStyleBackColor = true;
            this.btnZus.Click += new System.EventHandler(this.btnZus_Click);
            // 
            // btnKpir
            // 
            this.btnKpir.Location = new System.Drawing.Point(132, 3);
            this.btnKpir.Name = "btnKpir";
            this.btnKpir.Size = new System.Drawing.Size(123, 50);
            this.btnKpir.TabIndex = 32;
            this.btnKpir.Text = "Generuj KPiR vat, kadry BBK";
            this.btnKpir.UseVisualStyleBackColor = true;
            this.btnKpir.Click += new System.EventHandler(this.btnKpir_Click);
            // 
            // btnUpl
            // 
            this.btnUpl.Location = new System.Drawing.Point(261, 3);
            this.btnUpl.Name = "btnUpl";
            this.btnUpl.Size = new System.Drawing.Size(123, 50);
            this.btnUpl.TabIndex = 33;
            this.btnUpl.Text = "Generuj UPL";
            this.btnUpl.UseVisualStyleBackColor = true;
            this.btnUpl.Click += new System.EventHandler(this.btnUpl_Click);
            // 
            // btnVatr
            // 
            this.btnVatr.Location = new System.Drawing.Point(390, 3);
            this.btnVatr.Name = "btnVatr";
            this.btnVatr.Size = new System.Drawing.Size(123, 50);
            this.btnVatr.TabIndex = 34;
            this.btnVatr.Text = "Generuj VATR";
            this.btnVatr.UseVisualStyleBackColor = true;
            this.btnVatr.Click += new System.EventHandler(this.btnVatr_Click);
            // 
            // btnKwe
            // 
            this.btnKwe.AutoSize = true;
            this.btnKwe.BackColor = System.Drawing.SystemColors.Control;
            this.btnKwe.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnKwe.Location = new System.Drawing.Point(519, 3);
            this.btnKwe.Name = "btnKwe";
            this.btnKwe.Size = new System.Drawing.Size(127, 50);
            this.btnKwe.TabIndex = 34;
            this.btnKwe.Text = "Generuj kwestionariusz dla firmy";
            this.btnKwe.UseVisualStyleBackColor = false;
            this.btnKwe.Click += new System.EventHandler(this.btnKwe_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.fldName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.fldNip, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.fldDate, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.fldPesel, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 47);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(372, 104);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // fldName
            // 
            this.fldName.Location = new System.Drawing.Point(3, 3);
            this.fldName.MaxLength = 40;
            this.fldName.Name = "fldName";
            this.fldName.Size = new System.Drawing.Size(366, 20);
            this.fldName.TabIndex = 2;
            this.fldName.Text = "Imię i nazwisko";
            // 
            // fldNip
            // 
            this.fldNip.Location = new System.Drawing.Point(3, 55);
            this.fldNip.MaxLength = 10;
            this.fldNip.Name = "fldNip";
            this.fldNip.Size = new System.Drawing.Size(95, 20);
            this.fldNip.TabIndex = 4;
            this.fldNip.Text = "NIP";
            // 
            // fldDate
            // 
            this.fldDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fldDate.Location = new System.Drawing.Point(3, 81);
            this.fldDate.Name = "fldDate";
            this.fldDate.Size = new System.Drawing.Size(95, 20);
            this.fldDate.TabIndex = 5;
            // 
            // fldPesel
            // 
            this.fldPesel.Location = new System.Drawing.Point(3, 29);
            this.fldPesel.MaxLength = 11;
            this.fldPesel.Name = "fldPesel";
            this.fldPesel.Size = new System.Drawing.Size(145, 20);
            this.fldPesel.TabIndex = 3;
            this.fldPesel.Text = "PESEL";
            // 
            // chkMale
            // 
            this.chkMale.AutoSize = true;
            this.chkMale.Location = new System.Drawing.Point(12, 27);
            this.chkMale.Name = "chkMale";
            this.chkMale.Size = new System.Drawing.Size(79, 17);
            this.chkMale.TabIndex = 0;
            this.chkMale.Text = "Mężczyzna";
            this.chkMale.UseVisualStyleBackColor = true;
            this.chkMale.CheckedChanged += new System.EventHandler(this.chkMale_CheckedChanged);
            // 
            // chkFemale
            // 
            this.chkFemale.AutoSize = true;
            this.chkFemale.Location = new System.Drawing.Point(97, 27);
            this.chkFemale.Name = "chkFemale";
            this.chkFemale.Size = new System.Drawing.Size(62, 17);
            this.chkFemale.TabIndex = 1;
            this.chkFemale.Text = "Kobieta";
            this.chkFemale.UseVisualStyleBackColor = true;
            this.chkFemale.CheckedChanged += new System.EventHandler(this.chkFemale_CheckedChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.73885F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.62208F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.62208F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.01698F));
            this.tableLayoutPanel3.Controls.Add(this.fldStreet, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.fldCity, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.fldNrdom, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.fldNrmiesz, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.fldPostal, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.fldCountry, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.fldGmina, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.fldPowiat, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.fldPoczta, 3, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 179);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(372, 99);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // fldStreet
            // 
            this.fldStreet.Location = new System.Drawing.Point(3, 3);
            this.fldStreet.Name = "fldStreet";
            this.fldStreet.Size = new System.Drawing.Size(152, 20);
            this.fldStreet.TabIndex = 6;
            this.fldStreet.Text = "Ulica";
            // 
            // fldCity
            // 
            this.fldCity.Location = new System.Drawing.Point(3, 27);
            this.fldCity.Name = "fldCity";
            this.fldCity.Size = new System.Drawing.Size(152, 20);
            this.fldCity.TabIndex = 10;
            this.fldCity.Text = "Miejscowość";
            // 
            // fldNrdom
            // 
            this.fldNrdom.Location = new System.Drawing.Point(161, 3);
            this.fldNrdom.Name = "fldNrdom";
            this.fldNrdom.Size = new System.Drawing.Size(59, 20);
            this.fldNrdom.TabIndex = 7;
            this.fldNrdom.Text = "Nr. domu";
            // 
            // fldNrmiesz
            // 
            this.fldNrmiesz.Location = new System.Drawing.Point(226, 3);
            this.fldNrmiesz.Name = "fldNrmiesz";
            this.fldNrmiesz.Size = new System.Drawing.Size(59, 20);
            this.fldNrmiesz.TabIndex = 8;
            this.fldNrmiesz.Text = "Nr. mieszkania";
            // 
            // fldPostal
            // 
            this.fldPostal.Location = new System.Drawing.Point(291, 3);
            this.fldPostal.Name = "fldPostal";
            this.fldPostal.Size = new System.Drawing.Size(78, 20);
            this.fldPostal.TabIndex = 9;
            this.fldPostal.Text = "Kod pocztowy";
            // 
            // fldCountry
            // 
            this.fldCountry.Location = new System.Drawing.Point(291, 27);
            this.fldCountry.Name = "fldCountry";
            this.fldCountry.Size = new System.Drawing.Size(78, 20);
            this.fldCountry.TabIndex = 11;
            this.fldCountry.Text = "Kraj";
            // 
            // fldGmina
            // 
            this.fldGmina.Location = new System.Drawing.Point(3, 51);
            this.fldGmina.Name = "fldGmina";
            this.fldGmina.Size = new System.Drawing.Size(152, 20);
            this.fldGmina.TabIndex = 12;
            this.fldGmina.Text = "Gmina";
            // 
            // fldPowiat
            // 
            this.fldPowiat.Location = new System.Drawing.Point(3, 75);
            this.fldPowiat.Name = "fldPowiat";
            this.fldPowiat.Size = new System.Drawing.Size(152, 20);
            this.fldPowiat.TabIndex = 14;
            this.fldPowiat.Text = "Powiat";
            // 
            // fldPoczta
            // 
            this.fldPoczta.Location = new System.Drawing.Point(291, 51);
            this.fldPoczta.Name = "fldPoczta";
            this.fldPoczta.Size = new System.Drawing.Size(78, 20);
            this.fldPoczta.TabIndex = 13;
            this.fldPoczta.Text = "Poczta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dane osobiste";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Adres zamieszkania";
            // 
            // Dokumentator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(673, 378);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.chkFemale);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.chkMale);
            this.Name = "Dokumentator";
            this.Text = "Dokumentator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnZus;
        private System.Windows.Forms.Button btnKpir;
        private System.Windows.Forms.Button btnUpl;
        private System.Windows.Forms.Button btnVatr;
        private System.Windows.Forms.Button btnKwe;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox fldName;
        private System.Windows.Forms.TextBox fldNip;
        private System.Windows.Forms.DateTimePicker fldDate;
        private System.Windows.Forms.CheckBox chkMale;
        private System.Windows.Forms.CheckBox chkFemale;
        private System.Windows.Forms.TextBox fldPesel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox fldStreet;
        private System.Windows.Forms.TextBox fldCity;
        private System.Windows.Forms.TextBox fldNrdom;
        private System.Windows.Forms.TextBox fldNrmiesz;
        private System.Windows.Forms.TextBox fldPostal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fldCountry;
        private System.Windows.Forms.TextBox fldGmina;
        private System.Windows.Forms.TextBox fldPowiat;
        private System.Windows.Forms.TextBox fldPoczta;
    }
}

