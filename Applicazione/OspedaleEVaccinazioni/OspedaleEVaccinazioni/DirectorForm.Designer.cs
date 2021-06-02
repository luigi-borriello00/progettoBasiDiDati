﻿
namespace OspedaleEVaccinazioni
{
    partial class DirectorForm
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
            this.genderPatient = new System.Windows.Forms.ComboBox();
            this.residenceNurse = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DeletePatient = new System.Windows.Forms.Button();
            this.InsertPatient = new System.Windows.Forms.Button();
            this.mailNurse = new System.Windows.Forms.TextBox();
            this.nameNurse = new System.Windows.Forms.TextBox();
            this.surnameNurse = new System.Windows.Forms.TextBox();
            this.codNurse = new System.Windows.Forms.TextBox();
            this.cellNurse = new System.Windows.Forms.TextBox();
            this.idInfermiere = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.bdDate = new System.Windows.Forms.DateTimePicker();
            this.residenceDelete = new System.Windows.Forms.Button();
            this.residenceInsert = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.goBack = new System.Windows.Forms.Button();
            this.goToWareHouse = new System.Windows.Forms.Button();
            this.dateStartWork = new System.Windows.Forms.DateTimePicker();
            this.residenceId = new System.Windows.Forms.TextBox();
            this.residenceName = new System.Windows.Forms.TextBox();
            this.residenceProv = new System.Windows.Forms.TextBox();
            this.residenceCap = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.choiceDirector = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateVaccination = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // genderPatient
            // 
            this.genderPatient.FormattingEnabled = true;
            this.genderPatient.Items.AddRange(new object[] {
            "Maschio",
            "Femmina"});
            this.genderPatient.Location = new System.Drawing.Point(88, 247);
            this.genderPatient.Name = "genderPatient";
            this.genderPatient.Size = new System.Drawing.Size(140, 21);
            this.genderPatient.TabIndex = 68;
            // 
            // residenceNurse
            // 
            this.residenceNurse.FormattingEnabled = true;
            this.residenceNurse.Location = new System.Drawing.Point(88, 391);
            this.residenceNurse.Name = "residenceNurse";
            this.residenceNurse.Size = new System.Drawing.Size(140, 21);
            this.residenceNurse.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "Residenza";
            // 
            // DeletePatient
            // 
            this.DeletePatient.BackColor = System.Drawing.Color.Red;
            this.DeletePatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeletePatient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeletePatient.Location = new System.Drawing.Point(253, 91);
            this.DeletePatient.Name = "DeletePatient";
            this.DeletePatient.Size = new System.Drawing.Size(75, 23);
            this.DeletePatient.TabIndex = 58;
            this.DeletePatient.Text = "Cancella";
            this.DeletePatient.UseVisualStyleBackColor = false;
            this.DeletePatient.Click += new System.EventHandler(this.DeletePatient_Click);
            // 
            // InsertPatient
            // 
            this.InsertPatient.BackColor = System.Drawing.Color.Lime;
            this.InsertPatient.Location = new System.Drawing.Point(253, 131);
            this.InsertPatient.Name = "InsertPatient";
            this.InsertPatient.Size = new System.Drawing.Size(75, 23);
            this.InsertPatient.TabIndex = 57;
            this.InsertPatient.Text = "Inserisci";
            this.InsertPatient.UseVisualStyleBackColor = false;
            // 
            // mailNurse
            // 
            this.mailNurse.Location = new System.Drawing.Point(88, 356);
            this.mailNurse.Name = "mailNurse";
            this.mailNurse.Size = new System.Drawing.Size(140, 20);
            this.mailNurse.TabIndex = 56;
            // 
            // nameNurse
            // 
            this.nameNurse.Location = new System.Drawing.Point(88, 133);
            this.nameNurse.Name = "nameNurse";
            this.nameNurse.Size = new System.Drawing.Size(140, 20);
            this.nameNurse.TabIndex = 55;
            // 
            // surnameNurse
            // 
            this.surnameNurse.Location = new System.Drawing.Point(88, 172);
            this.surnameNurse.Name = "surnameNurse";
            this.surnameNurse.Size = new System.Drawing.Size(140, 20);
            this.surnameNurse.TabIndex = 54;
            // 
            // codNurse
            // 
            this.codNurse.Location = new System.Drawing.Point(88, 283);
            this.codNurse.Name = "codNurse";
            this.codNurse.Size = new System.Drawing.Size(140, 20);
            this.codNurse.TabIndex = 52;
            // 
            // cellNurse
            // 
            this.cellNurse.Location = new System.Drawing.Point(88, 319);
            this.cellNurse.Name = "cellNurse";
            this.cellNurse.Size = new System.Drawing.Size(140, 20);
            this.cellNurse.TabIndex = 51;
            // 
            // idInfermiere
            // 
            this.idInfermiere.Location = new System.Drawing.Point(88, 93);
            this.idInfermiere.Name = "idInfermiere";
            this.idInfermiere.Size = new System.Drawing.Size(140, 20);
            this.idInfermiere.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Nome";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Cognome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "DataNascita";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Sesso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "CodFiscale";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "IdPersona";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 41;
            this.label1.Text = "Inserisci Infermiere";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 431);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 13);
            this.label15.TabIndex = 73;
            this.label15.Text = "DataAssunzione";
            // 
            // bdDate
            // 
            this.bdDate.Location = new System.Drawing.Point(88, 208);
            this.bdDate.Name = "bdDate";
            this.bdDate.Size = new System.Drawing.Size(168, 20);
            this.bdDate.TabIndex = 75;
            // 
            // residenceDelete
            // 
            this.residenceDelete.BackColor = System.Drawing.Color.Red;
            this.residenceDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.residenceDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.residenceDelete.Location = new System.Drawing.Point(1155, 83);
            this.residenceDelete.Name = "residenceDelete";
            this.residenceDelete.Size = new System.Drawing.Size(75, 23);
            this.residenceDelete.TabIndex = 84;
            this.residenceDelete.Text = "Cancella";
            this.residenceDelete.UseVisualStyleBackColor = false;
            this.residenceDelete.Click += new System.EventHandler(this.residenceDelete_Click);
            // 
            // residenceInsert
            // 
            this.residenceInsert.BackColor = System.Drawing.Color.Lime;
            this.residenceInsert.Location = new System.Drawing.Point(1155, 123);
            this.residenceInsert.Name = "residenceInsert";
            this.residenceInsert.Size = new System.Drawing.Size(75, 23);
            this.residenceInsert.TabIndex = 83;
            this.residenceInsert.Text = "Inserisci";
            this.residenceInsert.UseVisualStyleBackColor = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(933, 49);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(172, 24);
            this.label20.TabIndex = 76;
            this.label20.Text = "Inserisci Residenza";
            // 
            // goBack
            // 
            this.goBack.Location = new System.Drawing.Point(506, 450);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(88, 34);
            this.goBack.TabIndex = 94;
            this.goBack.Text = "Torna Indietro";
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // goToWareHouse
            // 
            this.goToWareHouse.Location = new System.Drawing.Point(646, 450);
            this.goToWareHouse.Name = "goToWareHouse";
            this.goToWareHouse.Size = new System.Drawing.Size(83, 34);
            this.goToWareHouse.TabIndex = 96;
            this.goToWareHouse.Text = "Magazzino";
            this.goToWareHouse.UseVisualStyleBackColor = true;
            this.goToWareHouse.Click += new System.EventHandler(this.goToWareHouse_Click);
            // 
            // dateStartWork
            // 
            this.dateStartWork.Location = new System.Drawing.Point(88, 425);
            this.dateStartWork.Name = "dateStartWork";
            this.dateStartWork.Size = new System.Drawing.Size(168, 20);
            this.dateStartWork.TabIndex = 97;
            // 
            // residenceId
            // 
            this.residenceId.Location = new System.Drawing.Point(990, 83);
            this.residenceId.Name = "residenceId";
            this.residenceId.Size = new System.Drawing.Size(140, 20);
            this.residenceId.TabIndex = 107;
            // 
            // residenceName
            // 
            this.residenceName.Location = new System.Drawing.Point(990, 122);
            this.residenceName.Name = "residenceName";
            this.residenceName.Size = new System.Drawing.Size(140, 20);
            this.residenceName.TabIndex = 106;
            // 
            // residenceProv
            // 
            this.residenceProv.Location = new System.Drawing.Point(990, 161);
            this.residenceProv.Name = "residenceProv";
            this.residenceProv.Size = new System.Drawing.Size(140, 20);
            this.residenceProv.TabIndex = 105;
            // 
            // residenceCap
            // 
            this.residenceCap.Location = new System.Drawing.Point(990, 197);
            this.residenceCap.Name = "residenceCap";
            this.residenceCap.Size = new System.Drawing.Size(140, 20);
            this.residenceCap.TabIndex = 104;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(924, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 102;
            this.label12.Text = "IdResidenza";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(924, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 101;
            this.label13.Text = "Città";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(924, 164);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 100;
            this.label14.Text = "Provincia";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(924, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 99;
            this.label11.Text = "CAP";
            // 
            // choiceDirector
            // 
            this.choiceDirector.FormattingEnabled = true;
            this.choiceDirector.Items.AddRange(new object[] {
            "Vaccinazioni"});
            this.choiceDirector.Location = new System.Drawing.Point(374, 54);
            this.choiceDirector.Name = "choiceDirector";
            this.choiceDirector.Size = new System.Drawing.Size(423, 21);
            this.choiceDirector.TabIndex = 111;
            this.choiceDirector.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(803, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 45);
            this.button1.TabIndex = 110;
            this.button1.Text = "Visualizza";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(521, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(208, 24);
            this.label16.TabIndex = 109;
            this.label16.Text = "Scegli cosa visualizzare";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(374, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(494, 329);
            this.dataGridView1.TabIndex = 108;
            // 
            // dateVaccination
            // 
            this.dateVaccination.Location = new System.Drawing.Point(374, 80);
            this.dateVaccination.Name = "dateVaccination";
            this.dateVaccination.Size = new System.Drawing.Size(423, 20);
            this.dateVaccination.TabIndex = 112;
            // 
            // DirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 496);
            this.Controls.Add(this.dateVaccination);
            this.Controls.Add(this.choiceDirector);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.residenceId);
            this.Controls.Add(this.residenceName);
            this.Controls.Add(this.residenceProv);
            this.Controls.Add(this.residenceCap);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateStartWork);
            this.Controls.Add(this.goToWareHouse);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.residenceDelete);
            this.Controls.Add(this.residenceInsert);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.bdDate);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.genderPatient);
            this.Controls.Add(this.residenceNurse);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DeletePatient);
            this.Controls.Add(this.InsertPatient);
            this.Controls.Add(this.mailNurse);
            this.Controls.Add(this.nameNurse);
            this.Controls.Add(this.surnameNurse);
            this.Controls.Add(this.codNurse);
            this.Controls.Add(this.cellNurse);
            this.Controls.Add(this.idInfermiere);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DirectorForm";
            this.Text = "DirectorForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DirectorForm_FormClosing);
            this.Load += new System.EventHandler(this.DirectorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox genderPatient;
        private System.Windows.Forms.ComboBox residenceNurse;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button DeletePatient;
        private System.Windows.Forms.Button InsertPatient;
        private System.Windows.Forms.TextBox mailNurse;
        private System.Windows.Forms.TextBox nameNurse;
        private System.Windows.Forms.TextBox surnameNurse;
        private System.Windows.Forms.TextBox codNurse;
        private System.Windows.Forms.TextBox cellNurse;
        private System.Windows.Forms.TextBox idInfermiere;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker bdDate;
        private System.Windows.Forms.Button residenceDelete;
        private System.Windows.Forms.Button residenceInsert;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.Button goToWareHouse;
        private System.Windows.Forms.DateTimePicker dateStartWork;
        private System.Windows.Forms.TextBox residenceId;
        private System.Windows.Forms.TextBox residenceName;
        private System.Windows.Forms.TextBox residenceProv;
        private System.Windows.Forms.TextBox residenceCap;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox choiceDirector;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateVaccination;
    }
}