namespace CMSH.View
{
    partial class Formrcmndcheckups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formrcmndcheckups));
            this.buttonRecommendcheckups = new System.Windows.Forms.Button();
            this.buttoncheckupsaddlist = new System.Windows.Forms.Button();
            this.labelcheckupreciptno = new System.Windows.Forms.Label();
            this.textBoxaddcheckup = new System.Windows.Forms.TextBox();
            this.listBoxcheckups = new System.Windows.Forms.ListBox();
            this.buttonremovecheckup = new System.Windows.Forms.Button();
            this.buttonrecommendchback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRecommendcheckups
            // 
            this.buttonRecommendcheckups.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonRecommendcheckups.Location = new System.Drawing.Point(129, 252);
            this.buttonRecommendcheckups.Name = "buttonRecommendcheckups";
            this.buttonRecommendcheckups.Size = new System.Drawing.Size(75, 23);
            this.buttonRecommendcheckups.TabIndex = 1;
            this.buttonRecommendcheckups.Text = "Recommend";
            this.buttonRecommendcheckups.UseVisualStyleBackColor = false;
            this.buttonRecommendcheckups.Click += new System.EventHandler(this.buttonRecommendcheckups_Click);
            // 
            // buttoncheckupsaddlist
            // 
            this.buttoncheckupsaddlist.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttoncheckupsaddlist.Location = new System.Drawing.Point(314, 22);
            this.buttoncheckupsaddlist.Name = "buttoncheckupsaddlist";
            this.buttoncheckupsaddlist.Size = new System.Drawing.Size(75, 23);
            this.buttoncheckupsaddlist.TabIndex = 3;
            this.buttoncheckupsaddlist.Text = "Add to List";
            this.buttoncheckupsaddlist.UseVisualStyleBackColor = false;
            this.buttoncheckupsaddlist.Click += new System.EventHandler(this.buttoncheckupsaddlist_Click);
            // 
            // labelcheckupreciptno
            // 
            this.labelcheckupreciptno.AutoSize = true;
            this.labelcheckupreciptno.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelcheckupreciptno.Location = new System.Drawing.Point(12, 83);
            this.labelcheckupreciptno.Name = "labelcheckupreciptno";
            this.labelcheckupreciptno.Size = new System.Drawing.Size(64, 13);
            this.labelcheckupreciptno.TabIndex = 4;
            this.labelcheckupreciptno.Text = "Receipt No:";
            // 
            // textBoxaddcheckup
            // 
            this.textBoxaddcheckup.AutoCompleteCustomSource.AddRange(new string[] {
            "Cholesterol",
            "Fasting Blood Sugar",
            "Full Blood Count",
            "Lipid Profile",
            "Urine Full Report"});
            this.textBoxaddcheckup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxaddcheckup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxaddcheckup.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxaddcheckup.Location = new System.Drawing.Point(15, 23);
            this.textBoxaddcheckup.Name = "textBoxaddcheckup";
            this.textBoxaddcheckup.Size = new System.Drawing.Size(274, 20);
            this.textBoxaddcheckup.TabIndex = 5;
            this.textBoxaddcheckup.Text = "Type the checkup here...";
            // 
            // listBoxcheckups
            // 
            this.listBoxcheckups.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.listBoxcheckups.FormattingEnabled = true;
            this.listBoxcheckups.Location = new System.Drawing.Point(12, 99);
            this.listBoxcheckups.Name = "listBoxcheckups";
            this.listBoxcheckups.Size = new System.Drawing.Size(275, 147);
            this.listBoxcheckups.TabIndex = 6;
            // 
            // buttonremovecheckup
            // 
            this.buttonremovecheckup.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonremovecheckup.Location = new System.Drawing.Point(293, 148);
            this.buttonremovecheckup.Name = "buttonremovecheckup";
            this.buttonremovecheckup.Size = new System.Drawing.Size(75, 23);
            this.buttonremovecheckup.TabIndex = 7;
            this.buttonremovecheckup.Text = "Remove";
            this.buttonremovecheckup.UseVisualStyleBackColor = false;
            this.buttonremovecheckup.Click += new System.EventHandler(this.buttonremovecheckup_Click);
            // 
            // buttonrecommendchback
            // 
            this.buttonrecommendchback.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonrecommendchback.Location = new System.Drawing.Point(15, 252);
            this.buttonrecommendchback.Name = "buttonrecommendchback";
            this.buttonrecommendchback.Size = new System.Drawing.Size(75, 23);
            this.buttonrecommendchback.TabIndex = 8;
            this.buttonrecommendchback.Text = "Back";
            this.buttonrecommendchback.UseVisualStyleBackColor = false;
            // 
            // Formrcmndcheckups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(401, 305);
            this.Controls.Add(this.buttonrecommendchback);
            this.Controls.Add(this.buttonremovecheckup);
            this.Controls.Add(this.listBoxcheckups);
            this.Controls.Add(this.textBoxaddcheckup);
            this.Controls.Add(this.labelcheckupreciptno);
            this.Controls.Add(this.buttoncheckupsaddlist);
            this.Controls.Add(this.buttonRecommendcheckups);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Formrcmndcheckups";
            this.Text = "Recommend Checkups";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRecommendcheckups;
        private System.Windows.Forms.Button buttoncheckupsaddlist;
        private System.Windows.Forms.Label labelcheckupreciptno;
        private System.Windows.Forms.TextBox textBoxaddcheckup;
        private System.Windows.Forms.ListBox listBoxcheckups;
        private System.Windows.Forms.Button buttonremovecheckup;
        private System.Windows.Forms.Button buttonrecommendchback;
    }
}