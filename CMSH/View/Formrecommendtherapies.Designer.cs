namespace CMSH.View
{
    partial class Formrecommendtherapies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formrecommendtherapies));
            this.textBoxrecommendtherapies = new System.Windows.Forms.TextBox();
            this.buttonrecommendtherapies = new System.Windows.Forms.Button();
            this.labeltherapyreceiptno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxrecommendtherapies
            // 
            this.textBoxrecommendtherapies.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxrecommendtherapies.Location = new System.Drawing.Point(13, 37);
            this.textBoxrecommendtherapies.Multiline = true;
            this.textBoxrecommendtherapies.Name = "textBoxrecommendtherapies";
            this.textBoxrecommendtherapies.Size = new System.Drawing.Size(379, 169);
            this.textBoxrecommendtherapies.TabIndex = 0;
            this.textBoxrecommendtherapies.Text = "Add therapies here";
            // 
            // buttonrecommendtherapies
            // 
            this.buttonrecommendtherapies.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonrecommendtherapies.Location = new System.Drawing.Point(154, 226);
            this.buttonrecommendtherapies.Name = "buttonrecommendtherapies";
            this.buttonrecommendtherapies.Size = new System.Drawing.Size(75, 23);
            this.buttonrecommendtherapies.TabIndex = 1;
            this.buttonrecommendtherapies.Text = "Recommend";
            this.buttonrecommendtherapies.UseVisualStyleBackColor = false;
            // 
            // labeltherapyreceiptno
            // 
            this.labeltherapyreceiptno.AutoSize = true;
            this.labeltherapyreceiptno.BackColor = System.Drawing.SystemColors.Highlight;
            this.labeltherapyreceiptno.Location = new System.Drawing.Point(13, 13);
            this.labeltherapyreceiptno.Name = "labeltherapyreceiptno";
            this.labeltherapyreceiptno.Size = new System.Drawing.Size(64, 13);
            this.labeltherapyreceiptno.TabIndex = 2;
            this.labeltherapyreceiptno.Text = "Receipt No:";
            // 
            // Formrecommendtherapies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.Controls.Add(this.labeltherapyreceiptno);
            this.Controls.Add(this.buttonrecommendtherapies);
            this.Controls.Add(this.textBoxrecommendtherapies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Formrecommendtherapies";
            this.Text = "Recommend Therapies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxrecommendtherapies;
        private System.Windows.Forms.Button buttonrecommendtherapies;
        private System.Windows.Forms.Label labeltherapyreceiptno;
    }
}