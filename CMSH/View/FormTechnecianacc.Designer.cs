namespace CMSH.View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labeltechname = new System.Windows.Forms.Label();
            this.labeltechdesignation = new System.Windows.Forms.Label();
            this.labeltechworkingplace = new System.Windows.Forms.Label();
            this.labeltechqualifications = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.labeltechqualifications);
            this.panel1.Controls.Add(this.labeltechworkingplace);
            this.panel1.Controls.Add(this.labeltechdesignation);
            this.panel1.Controls.Add(this.labeltechname);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 170);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 144);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labeltechname
            // 
            this.labeltechname.AutoSize = true;
            this.labeltechname.BackColor = System.Drawing.Color.Transparent;
            this.labeltechname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltechname.ForeColor = System.Drawing.Color.White;
            this.labeltechname.Location = new System.Drawing.Point(188, 25);
            this.labeltechname.Name = "labeltechname";
            this.labeltechname.Size = new System.Drawing.Size(65, 24);
            this.labeltechname.TabIndex = 1;
            this.labeltechname.Text = "Name";
            this.labeltechname.Click += new System.EventHandler(this.labeltechname_Click);
            // 
            // labeltechdesignation
            // 
            this.labeltechdesignation.AutoSize = true;
            this.labeltechdesignation.BackColor = System.Drawing.Color.Transparent;
            this.labeltechdesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltechdesignation.ForeColor = System.Drawing.Color.White;
            this.labeltechdesignation.Location = new System.Drawing.Point(188, 62);
            this.labeltechdesignation.Name = "labeltechdesignation";
            this.labeltechdesignation.Size = new System.Drawing.Size(120, 24);
            this.labeltechdesignation.TabIndex = 2;
            this.labeltechdesignation.Text = "Designation";
            // 
            // labeltechworkingplace
            // 
            this.labeltechworkingplace.AutoSize = true;
            this.labeltechworkingplace.BackColor = System.Drawing.Color.Transparent;
            this.labeltechworkingplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltechworkingplace.ForeColor = System.Drawing.Color.White;
            this.labeltechworkingplace.Location = new System.Drawing.Point(188, 102);
            this.labeltechworkingplace.Name = "labeltechworkingplace";
            this.labeltechworkingplace.Size = new System.Drawing.Size(145, 24);
            this.labeltechworkingplace.TabIndex = 3;
            this.labeltechworkingplace.Text = "Working Place";
            // 
            // labeltechqualifications
            // 
            this.labeltechqualifications.AutoSize = true;
            this.labeltechqualifications.BackColor = System.Drawing.Color.Transparent;
            this.labeltechqualifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltechqualifications.ForeColor = System.Drawing.Color.White;
            this.labeltechqualifications.Location = new System.Drawing.Point(418, 36);
            this.labeltechqualifications.Name = "labeltechqualifications";
            this.labeltechqualifications.Size = new System.Drawing.Size(76, 13);
            this.labeltechqualifications.TabIndex = 9;
            this.labeltechqualifications.Text = "Qualidfications";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 547);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labeltechname;
        private System.Windows.Forms.Label labeltechworkingplace;
        private System.Windows.Forms.Label labeltechdesignation;
        private System.Windows.Forms.Label labeltechqualifications;
    }
}