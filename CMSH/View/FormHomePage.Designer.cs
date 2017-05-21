namespace CMSH
{
    partial class FormHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomePage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxHFusername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxHFpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelHFcreateaccount = new System.Windows.Forms.Label();
            this.buttonHFlogin = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To CMSH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name:";
            // 
            // textboxHFusername
            // 
            this.textboxHFusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxHFusername.Location = new System.Drawing.Point(138, 134);
            this.textboxHFusername.Name = "textboxHFusername";
            this.textboxHFusername.Size = new System.Drawing.Size(157, 26);
            this.textboxHFusername.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // textboxHFpassword
            // 
            this.textboxHFpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxHFpassword.Location = new System.Drawing.Point(138, 179);
            this.textboxHFpassword.Name = "textboxHFpassword";
            this.textboxHFpassword.Size = new System.Drawing.Size(157, 26);
            this.textboxHFpassword.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(27, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dont have an account?";
            // 
            // labelHFcreateaccount
            // 
            this.labelHFcreateaccount.AutoSize = true;
            this.labelHFcreateaccount.BackColor = System.Drawing.Color.Transparent;
            this.labelHFcreateaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHFcreateaccount.ForeColor = System.Drawing.Color.Maroon;
            this.labelHFcreateaccount.Location = new System.Drawing.Point(153, 257);
            this.labelHFcreateaccount.Name = "labelHFcreateaccount";
            this.labelHFcreateaccount.Size = new System.Drawing.Size(95, 13);
            this.labelHFcreateaccount.TabIndex = 6;
            this.labelHFcreateaccount.Text = "Create an account";
            this.labelHFcreateaccount.Click += new System.EventHandler(this.labelHFcreateaccount_Click);
            // 
            // buttonHFlogin
            // 
            this.buttonHFlogin.ForeColor = System.Drawing.Color.Black;
            this.buttonHFlogin.Location = new System.Drawing.Point(137, 221);
            this.buttonHFlogin.Name = "buttonHFlogin";
            this.buttonHFlogin.Size = new System.Drawing.Size(75, 23);
            this.buttonHFlogin.TabIndex = 7;
            this.buttonHFlogin.Text = "Login";
            this.buttonHFlogin.UseVisualStyleBackColor = true;
            this.buttonHFlogin.Click += new System.EventHandler(this.buttonHFlogin_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(525, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "x";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(497, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "-";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // FormHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(556, 309);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonHFlogin);
            this.Controls.Add(this.labelHFcreateaccount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textboxHFpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textboxHFusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computerized Healthcare service Networking Syatem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxHFusername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxHFpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelHFcreateaccount;
        private System.Windows.Forms.Button buttonHFlogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

