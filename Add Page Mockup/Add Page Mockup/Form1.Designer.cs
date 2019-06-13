namespace Add_Page_Mockup
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.tbxDuration = new System.Windows.Forms.TextBox();
            this.tbxGenre = new System.Windows.Forms.TextBox();
            this.tbxYear = new System.Windows.Forms.TextBox();
            this.tbxArtist = new System.Windows.Forms.TextBox();
            this.lbxAdd = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(42, 48);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(42, 133);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(30, 13);
            this.lblArtist.TabIndex = 1;
            this.lblArtist.Text = "Artist";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(42, 212);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Year";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(42, 293);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 3;
            this.lblGenre.Text = "Genre";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(42, 367);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(47, 13);
            this.lblDuration.TabIndex = 4;
            this.lblDuration.Text = "Duration";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(42, 447);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(71, 13);
            this.lblAdd.TabIndex = 5;
            this.lblAdd.Text = "Add audio file";
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(45, 74);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(670, 20);
            this.tbxTitle.TabIndex = 6;
            this.tbxTitle.Text = "Add the title of the song";
            // 
            // tbxDuration
            // 
            this.tbxDuration.Location = new System.Drawing.Point(45, 402);
            this.tbxDuration.Name = "tbxDuration";
            this.tbxDuration.Size = new System.Drawing.Size(670, 20);
            this.tbxDuration.TabIndex = 8;
            this.tbxDuration.Text = "Add the duriation time of the song";
            // 
            // tbxGenre
            // 
            this.tbxGenre.Location = new System.Drawing.Point(45, 328);
            this.tbxGenre.Name = "tbxGenre";
            this.tbxGenre.Size = new System.Drawing.Size(670, 20);
            this.tbxGenre.TabIndex = 9;
            this.tbxGenre.Text = "Add the genre of the song";
            // 
            // tbxYear
            // 
            this.tbxYear.Location = new System.Drawing.Point(45, 245);
            this.tbxYear.Name = "tbxYear";
            this.tbxYear.Size = new System.Drawing.Size(670, 20);
            this.tbxYear.TabIndex = 10;
            this.tbxYear.Text = "Add the year of release of the song";
            // 
            // tbxArtist
            // 
            this.tbxArtist.Location = new System.Drawing.Point(45, 167);
            this.tbxArtist.Name = "tbxArtist";
            this.tbxArtist.Size = new System.Drawing.Size(670, 20);
            this.tbxArtist.TabIndex = 11;
            this.tbxArtist.Text = "Add the artist of the song";
            // 
            // lbxAdd
            // 
            this.lbxAdd.FormattingEnabled = true;
            this.lbxAdd.Location = new System.Drawing.Point(45, 481);
            this.lbxAdd.Name = "lbxAdd";
            this.lbxAdd.Size = new System.Drawing.Size(269, 95);
            this.lbxAdd.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 624);
            this.Controls.Add(this.lbxAdd);
            this.Controls.Add(this.tbxArtist);
            this.Controls.Add(this.tbxYear);
            this.Controls.Add(this.tbxGenre);
            this.Controls.Add(this.tbxDuration);
            this.Controls.Add(this.tbxTitle);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.TextBox tbxDuration;
        private System.Windows.Forms.TextBox tbxGenre;
        private System.Windows.Forms.TextBox tbxYear;
        private System.Windows.Forms.TextBox tbxArtist;
        private System.Windows.Forms.ListBox lbxAdd;
    }
}

