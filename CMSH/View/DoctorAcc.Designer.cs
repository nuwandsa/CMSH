namespace CMSH.View
{
    partial class FormDoctorAcc
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
            this.labeldamaximize = new System.Windows.Forms.Label();
            this.labeldaminimize = new System.Windows.Forms.Label();
            this.labeldaexit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labeldctrqualifications = new System.Windows.Forms.Label();
            this.labeldctrhospital = new System.Windows.Forms.Label();
            this.labeldctrdesignation = new System.Windows.Forms.Label();
            this.labeldctrname = new System.Windows.Forms.Label();
            this.pictureBoxdctr = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxdctrpatientid = new System.Windows.Forms.TextBox();
            this.buttonDctrexamine = new System.Windows.Forms.Button();
            this.paneldctraccpatientdata = new System.Windows.Forms.Panel();
            this.labeldapbmi = new System.Windows.Forms.Label();
            this.labeldapheight = new System.Windows.Forms.Label();
            this.labeldapweight = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButtondapsmoke = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labeldapagev = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labeldapnic = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labeldapaddress = new System.Windows.Forms.Label();
            this.labeldapname = new System.Windows.Forms.Label();
            this.pictureBoxdapatientimg = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxdctr)).BeginInit();
            this.paneldctraccpatientdata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxdapatientimg)).BeginInit();
            this.SuspendLayout();
            // 
            // labeldamaximize
            // 
            this.labeldamaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labeldamaximize.AutoSize = true;
            this.labeldamaximize.BackColor = System.Drawing.Color.Transparent;
            this.labeldamaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldamaximize.ForeColor = System.Drawing.Color.White;
            this.labeldamaximize.Location = new System.Drawing.Point(576, 9);
            this.labeldamaximize.MaximumSize = new System.Drawing.Size(1366, 768);
            this.labeldamaximize.Name = "labeldamaximize";
            this.labeldamaximize.Size = new System.Drawing.Size(21, 20);
            this.labeldamaximize.TabIndex = 6;
            this.labeldamaximize.Text = "[]]";
            this.labeldamaximize.Click += new System.EventHandler(this.labeldamaximize_Click);
            // 
            // labeldaminimize
            // 
            this.labeldaminimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labeldaminimize.AutoSize = true;
            this.labeldaminimize.BackColor = System.Drawing.Color.Transparent;
            this.labeldaminimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldaminimize.ForeColor = System.Drawing.Color.White;
            this.labeldaminimize.Location = new System.Drawing.Point(556, 9);
            this.labeldaminimize.Name = "labeldaminimize";
            this.labeldaminimize.Size = new System.Drawing.Size(14, 20);
            this.labeldaminimize.TabIndex = 5;
            this.labeldaminimize.Text = "-";
            this.labeldaminimize.Click += new System.EventHandler(this.labeldaminimize_Click);
            // 
            // labeldaexit
            // 
            this.labeldaexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labeldaexit.AutoSize = true;
            this.labeldaexit.BackColor = System.Drawing.Color.Transparent;
            this.labeldaexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldaexit.ForeColor = System.Drawing.Color.White;
            this.labeldaexit.Location = new System.Drawing.Point(608, 9);
            this.labeldaexit.Name = "labeldaexit";
            this.labeldaexit.Size = new System.Drawing.Size(16, 20);
            this.labeldaexit.TabIndex = 4;
            this.labeldaexit.Text = "x";
            this.labeldaexit.Click += new System.EventHandler(this.labeldaexit_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::CMSH.Properties.Resources.background;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.labeldctrqualifications);
            this.panel1.Controls.Add(this.labeldctrhospital);
            this.panel1.Controls.Add(this.labeldctrdesignation);
            this.panel1.Controls.Add(this.labeldctrname);
            this.panel1.Controls.Add(this.pictureBoxdctr);
            this.panel1.Controls.Add(this.labeldaminimize);
            this.panel1.Controls.Add(this.labeldaexit);
            this.panel1.Controls.Add(this.labeldamaximize);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 149);
            this.panel1.TabIndex = 7;
            // 
            // labeldctrqualifications
            // 
            this.labeldctrqualifications.AutoSize = true;
            this.labeldctrqualifications.BackColor = System.Drawing.Color.Transparent;
            this.labeldctrqualifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldctrqualifications.ForeColor = System.Drawing.Color.White;
            this.labeldctrqualifications.Location = new System.Drawing.Point(353, 36);
            this.labeldctrqualifications.Name = "labeldctrqualifications";
            this.labeldctrqualifications.Size = new System.Drawing.Size(68, 13);
            this.labeldctrqualifications.TabIndex = 11;
            this.labeldctrqualifications.Text = "qualifications";
            // 
            // labeldctrhospital
            // 
            this.labeldctrhospital.AutoSize = true;
            this.labeldctrhospital.BackColor = System.Drawing.Color.Transparent;
            this.labeldctrhospital.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldctrhospital.ForeColor = System.Drawing.Color.White;
            this.labeldctrhospital.Location = new System.Drawing.Point(158, 98);
            this.labeldctrhospital.Name = "labeldctrhospital";
            this.labeldctrhospital.Size = new System.Drawing.Size(67, 20);
            this.labeldctrhospital.TabIndex = 10;
            this.labeldctrhospital.Text = "Hospital";
            // 
            // labeldctrdesignation
            // 
            this.labeldctrdesignation.AutoSize = true;
            this.labeldctrdesignation.BackColor = System.Drawing.Color.Transparent;
            this.labeldctrdesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldctrdesignation.ForeColor = System.Drawing.Color.White;
            this.labeldctrdesignation.Location = new System.Drawing.Point(158, 61);
            this.labeldctrdesignation.Name = "labeldctrdesignation";
            this.labeldctrdesignation.Size = new System.Drawing.Size(94, 20);
            this.labeldctrdesignation.TabIndex = 9;
            this.labeldctrdesignation.Text = "Designation";
            // 
            // labeldctrname
            // 
            this.labeldctrname.AutoSize = true;
            this.labeldctrname.BackColor = System.Drawing.Color.Transparent;
            this.labeldctrname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldctrname.ForeColor = System.Drawing.Color.White;
            this.labeldctrname.Location = new System.Drawing.Point(158, 29);
            this.labeldctrname.Name = "labeldctrname";
            this.labeldctrname.Size = new System.Drawing.Size(51, 20);
            this.labeldctrname.TabIndex = 8;
            this.labeldctrname.Text = "Name";
            // 
            // pictureBoxdctr
            // 
            this.pictureBoxdctr.Location = new System.Drawing.Point(26, 15);
            this.pictureBoxdctr.Name = "pictureBoxdctr";
            this.pictureBoxdctr.Size = new System.Drawing.Size(125, 120);
            this.pictureBoxdctr.TabIndex = 7;
            this.pictureBoxdctr.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Examine patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Patient User ID/NIC No:";
            // 
            // textBoxdctrpatientid
            // 
            this.textBoxdctrpatientid.Location = new System.Drawing.Point(228, 213);
            this.textBoxdctrpatientid.Name = "textBoxdctrpatientid";
            this.textBoxdctrpatientid.Size = new System.Drawing.Size(174, 20);
            this.textBoxdctrpatientid.TabIndex = 13;
            // 
            // buttonDctrexamine
            // 
            this.buttonDctrexamine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonDctrexamine.ForeColor = System.Drawing.Color.White;
            this.buttonDctrexamine.Location = new System.Drawing.Point(429, 210);
            this.buttonDctrexamine.Name = "buttonDctrexamine";
            this.buttonDctrexamine.Size = new System.Drawing.Size(75, 23);
            this.buttonDctrexamine.TabIndex = 22;
            this.buttonDctrexamine.Text = "Examine";
            this.buttonDctrexamine.UseVisualStyleBackColor = false;
            // 
            // paneldctraccpatientdata
            // 
            this.paneldctraccpatientdata.BackColor = System.Drawing.Color.Transparent;
            this.paneldctraccpatientdata.Controls.Add(this.labeldapbmi);
            this.paneldctraccpatientdata.Controls.Add(this.labeldapheight);
            this.paneldctraccpatientdata.Controls.Add(this.labeldapweight);
            this.paneldctraccpatientdata.Controls.Add(this.label8);
            this.paneldctraccpatientdata.Controls.Add(this.radioButtondapsmoke);
            this.paneldctraccpatientdata.Controls.Add(this.label7);
            this.paneldctraccpatientdata.Controls.Add(this.label6);
            this.paneldctraccpatientdata.Controls.Add(this.labeldapagev);
            this.paneldctraccpatientdata.Controls.Add(this.label3);
            this.paneldctraccpatientdata.Controls.Add(this.labeldapnic);
            this.paneldctraccpatientdata.Controls.Add(this.label5);
            this.paneldctraccpatientdata.Controls.Add(this.labeldapaddress);
            this.paneldctraccpatientdata.Controls.Add(this.labeldapname);
            this.paneldctraccpatientdata.Controls.Add(this.pictureBoxdapatientimg);
            this.paneldctraccpatientdata.Location = new System.Drawing.Point(-1, 255);
            this.paneldctraccpatientdata.Name = "paneldctraccpatientdata";
            this.paneldctraccpatientdata.Size = new System.Drawing.Size(627, 420);
            this.paneldctraccpatientdata.TabIndex = 23;
            // 
            // labeldapbmi
            // 
            this.labeldapbmi.AutoSize = true;
            this.labeldapbmi.BackColor = System.Drawing.Color.Transparent;
            this.labeldapbmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldapbmi.ForeColor = System.Drawing.Color.White;
            this.labeldapbmi.Location = new System.Drawing.Point(70, 340);
            this.labeldapbmi.Name = "labeldapbmi";
            this.labeldapbmi.Size = new System.Drawing.Size(34, 20);
            this.labeldapbmi.TabIndex = 36;
            this.labeldapbmi.Text = "bmi";
            // 
            // labeldapheight
            // 
            this.labeldapheight.AutoSize = true;
            this.labeldapheight.BackColor = System.Drawing.Color.Transparent;
            this.labeldapheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldapheight.ForeColor = System.Drawing.Color.White;
            this.labeldapheight.Location = new System.Drawing.Point(88, 313);
            this.labeldapheight.Name = "labeldapheight";
            this.labeldapheight.Size = new System.Drawing.Size(53, 20);
            this.labeldapheight.TabIndex = 35;
            this.labeldapheight.Text = "height";
            // 
            // labeldapweight
            // 
            this.labeldapweight.AutoSize = true;
            this.labeldapweight.BackColor = System.Drawing.Color.Transparent;
            this.labeldapweight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldapweight.ForeColor = System.Drawing.Color.White;
            this.labeldapweight.Location = new System.Drawing.Point(88, 282);
            this.labeldapweight.Name = "labeldapweight";
            this.labeldapweight.Size = new System.Drawing.Size(55, 20);
            this.labeldapweight.TabIndex = 34;
            this.labeldapweight.Text = "weight";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(22, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "BMI:";
            // 
            // radioButtondapsmoke
            // 
            this.radioButtondapsmoke.AutoSize = true;
            this.radioButtondapsmoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtondapsmoke.ForeColor = System.Drawing.Color.White;
            this.radioButtondapsmoke.Location = new System.Drawing.Point(26, 373);
            this.radioButtondapsmoke.Name = "radioButtondapsmoke";
            this.radioButtondapsmoke.Size = new System.Drawing.Size(89, 24);
            this.radioButtondapsmoke.TabIndex = 32;
            this.radioButtondapsmoke.TabStop = true;
            this.radioButtondapsmoke.Text = "Smoking";
            this.radioButtondapsmoke.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtondapsmoke.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(22, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Weight:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Height:";
            // 
            // labeldapagev
            // 
            this.labeldapagev.AutoSize = true;
            this.labeldapagev.BackColor = System.Drawing.Color.Transparent;
            this.labeldapagev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldapagev.ForeColor = System.Drawing.Color.White;
            this.labeldapagev.Location = new System.Drawing.Point(70, 251);
            this.labeldapagev.Name = "labeldapagev";
            this.labeldapagev.Size = new System.Drawing.Size(36, 20);
            this.labeldapagev.TabIndex = 29;
            this.labeldapagev.Text = "age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Age:";
            // 
            // labeldapnic
            // 
            this.labeldapnic.AutoSize = true;
            this.labeldapnic.BackColor = System.Drawing.Color.Transparent;
            this.labeldapnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldapnic.ForeColor = System.Drawing.Color.White;
            this.labeldapnic.Location = new System.Drawing.Point(88, 222);
            this.labeldapnic.Name = "labeldapnic";
            this.labeldapnic.Size = new System.Drawing.Size(36, 20);
            this.labeldapnic.TabIndex = 27;
            this.labeldapnic.Text = "NIC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "NIC No:";
            // 
            // labeldapaddress
            // 
            this.labeldapaddress.AutoSize = true;
            this.labeldapaddress.BackColor = System.Drawing.Color.Transparent;
            this.labeldapaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldapaddress.ForeColor = System.Drawing.Color.White;
            this.labeldapaddress.Location = new System.Drawing.Point(22, 193);
            this.labeldapaddress.Name = "labeldapaddress";
            this.labeldapaddress.Size = new System.Drawing.Size(68, 20);
            this.labeldapaddress.TabIndex = 25;
            this.labeldapaddress.Text = "Address";
            // 
            // labeldapname
            // 
            this.labeldapname.AutoSize = true;
            this.labeldapname.BackColor = System.Drawing.Color.Transparent;
            this.labeldapname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldapname.ForeColor = System.Drawing.Color.White;
            this.labeldapname.Location = new System.Drawing.Point(22, 161);
            this.labeldapname.Name = "labeldapname";
            this.labeldapname.Size = new System.Drawing.Size(51, 20);
            this.labeldapname.TabIndex = 24;
            this.labeldapname.Text = "Name";
            // 
            // pictureBoxdapatientimg
            // 
            this.pictureBoxdapatientimg.Location = new System.Drawing.Point(26, 12);
            this.pictureBoxdapatientimg.Name = "pictureBoxdapatientimg";
            this.pictureBoxdapatientimg.Size = new System.Drawing.Size(125, 127);
            this.pictureBoxdapatientimg.TabIndex = 0;
            this.pictureBoxdapatientimg.TabStop = false;
            // 
            // FormDoctorAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CMSH.Properties.Resources.background_image_1273097_960_720;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(626, 675);
            this.Controls.Add(this.paneldctraccpatientdata);
            this.Controls.Add(this.buttonDctrexamine);
            this.Controls.Add(this.textBoxdctrpatientid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDoctorAcc";
            this.Load += new System.EventHandler(this.DoctorAcc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxdctr)).EndInit();
            this.paneldctraccpatientdata.ResumeLayout(false);
            this.paneldctraccpatientdata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxdapatientimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeldamaximize;
        private System.Windows.Forms.Label labeldaminimize;
        private System.Windows.Forms.Label labeldaexit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labeldctrqualifications;
        private System.Windows.Forms.Label labeldctrhospital;
        private System.Windows.Forms.Label labeldctrdesignation;
        private System.Windows.Forms.Label labeldctrname;
        private System.Windows.Forms.PictureBox pictureBoxdctr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxdctrpatientid;
        private System.Windows.Forms.Button buttonDctrexamine;
        private System.Windows.Forms.Panel paneldctraccpatientdata;
        private System.Windows.Forms.Label labeldapbmi;
        private System.Windows.Forms.Label labeldapheight;
        private System.Windows.Forms.Label labeldapweight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButtondapsmoke;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labeldapagev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labeldapnic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labeldapaddress;
        private System.Windows.Forms.Label labeldapname;
        private System.Windows.Forms.PictureBox pictureBoxdapatientimg;
    }
}