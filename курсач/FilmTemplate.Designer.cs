namespace курсач
{
    partial class FilmTemplate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TrailerButton = new System.Windows.Forms.Button();
            this.ExitForm3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.IsNewLabel = new System.Windows.Forms.Label();
            this.LabelPremier = new System.Windows.Forms.Label();
            this.LabelType = new System.Windows.Forms.Label();
            this.LabelDuration = new System.Windows.Forms.Label();
            this.LabelTranslation = new System.Windows.Forms.Label();
            this.LabelProducer = new System.Windows.Forms.Label();
            this.LabelCountry = new System.Windows.Forms.Label();
            this.LabelRaiting = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.PosterPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PosterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15);
            this.panel1.Size = new System.Drawing.Size(564, 446);
            this.panel1.TabIndex = 0;
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelDescription.Location = new System.Drawing.Point(18, 36);
            this.LabelDescription.Margin = new System.Windows.Forms.Padding(7);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(86, 13);
            this.LabelDescription.TabIndex = 34;
            this.LabelDescription.Text = "LabelDescription";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(18, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Опис:";
            // 
            // TrailerButton
            // 
            this.TrailerButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TrailerButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TrailerButton.FlatAppearance.BorderSize = 0;
            this.TrailerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrailerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrailerButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.TrailerButton.Location = new System.Drawing.Point(5, 305);
            this.TrailerButton.Name = "TrailerButton";
            this.TrailerButton.Size = new System.Drawing.Size(188, 37);
            this.TrailerButton.TabIndex = 14;
            this.TrailerButton.Text = "Трийлер";
            this.TrailerButton.UseVisualStyleBackColor = false;
            this.TrailerButton.Click += new System.EventHandler(this.TrailerButton_Click);
            // 
            // ExitForm3
            // 
            this.ExitForm3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitForm3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ExitForm3.FlatAppearance.BorderSize = 0;
            this.ExitForm3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitForm3.ForeColor = System.Drawing.Color.Gainsboro;
            this.ExitForm3.Location = new System.Drawing.Point(258, 3);
            this.ExitForm3.Name = "ExitForm3";
            this.ExitForm3.Size = new System.Drawing.Size(75, 23);
            this.ExitForm3.TabIndex = 10;
            this.ExitForm3.Text = "X";
            this.ExitForm3.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.LabelDescription);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(15, 362);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(534, 69);
            this.panel2.TabIndex = 35;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.PosterPictureBox);
            this.panel3.Controls.Add(this.TrailerButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(15, 15);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(198, 347);
            this.panel3.TabIndex = 36;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.IsNewLabel);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.ExitForm3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(213, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(336, 347);
            this.panel4.TabIndex = 38;
            // 
            // IsNewLabel
            // 
            this.IsNewLabel.AutoSize = true;
            this.IsNewLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.IsNewLabel.Location = new System.Drawing.Point(280, 326);
            this.IsNewLabel.Margin = new System.Windows.Forms.Padding(7);
            this.IsNewLabel.Name = "IsNewLabel";
            this.IsNewLabel.Size = new System.Drawing.Size(54, 13);
            this.IsNewLabel.TabIndex = 16;
            this.IsNewLabel.Text = "Новинка!";
            this.IsNewLabel.Visible = false;
            // 
            // LabelPremier
            // 
            this.LabelPremier.AutoSize = true;
            this.LabelPremier.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelPremier.Location = new System.Drawing.Point(7, 202);
            this.LabelPremier.Margin = new System.Windows.Forms.Padding(7);
            this.LabelPremier.Name = "LabelPremier";
            this.LabelPremier.Size = new System.Drawing.Size(68, 13);
            this.LabelPremier.TabIndex = 39;
            this.LabelPremier.Text = "LabelPremier";
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.LabelType.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelType.Location = new System.Drawing.Point(7, 175);
            this.LabelType.Margin = new System.Windows.Forms.Padding(7);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(57, 13);
            this.LabelType.TabIndex = 38;
            this.LabelType.Text = "LabelType";
            // 
            // LabelDuration
            // 
            this.LabelDuration.AutoSize = true;
            this.LabelDuration.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelDuration.Location = new System.Drawing.Point(7, 148);
            this.LabelDuration.Margin = new System.Windows.Forms.Padding(7);
            this.LabelDuration.Name = "LabelDuration";
            this.LabelDuration.Size = new System.Drawing.Size(73, 13);
            this.LabelDuration.TabIndex = 37;
            this.LabelDuration.Text = "LabelDuration";
            // 
            // LabelTranslation
            // 
            this.LabelTranslation.AutoSize = true;
            this.LabelTranslation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelTranslation.Location = new System.Drawing.Point(7, 121);
            this.LabelTranslation.Margin = new System.Windows.Forms.Padding(7);
            this.LabelTranslation.Name = "LabelTranslation";
            this.LabelTranslation.Size = new System.Drawing.Size(85, 13);
            this.LabelTranslation.TabIndex = 36;
            this.LabelTranslation.Text = "LabelTranslation";
            // 
            // LabelProducer
            // 
            this.LabelProducer.AutoSize = true;
            this.LabelProducer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelProducer.Location = new System.Drawing.Point(7, 94);
            this.LabelProducer.Margin = new System.Windows.Forms.Padding(7);
            this.LabelProducer.Name = "LabelProducer";
            this.LabelProducer.Size = new System.Drawing.Size(76, 13);
            this.LabelProducer.TabIndex = 35;
            this.LabelProducer.Text = "LabelProducer";
            // 
            // LabelCountry
            // 
            this.LabelCountry.AutoSize = true;
            this.LabelCountry.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelCountry.Location = new System.Drawing.Point(7, 67);
            this.LabelCountry.Margin = new System.Windows.Forms.Padding(7);
            this.LabelCountry.Name = "LabelCountry";
            this.LabelCountry.Size = new System.Drawing.Size(69, 13);
            this.LabelCountry.TabIndex = 34;
            this.LabelCountry.Text = "LabelCountry";
            // 
            // LabelRaiting
            // 
            this.LabelRaiting.AutoSize = true;
            this.LabelRaiting.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelRaiting.Location = new System.Drawing.Point(7, 40);
            this.LabelRaiting.Margin = new System.Windows.Forms.Padding(7);
            this.LabelRaiting.Name = "LabelRaiting";
            this.LabelRaiting.Size = new System.Drawing.Size(66, 13);
            this.LabelRaiting.TabIndex = 33;
            this.LabelRaiting.Text = "LabelRaiting";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelName.Location = new System.Drawing.Point(7, 13);
            this.LabelName.Margin = new System.Windows.Forms.Padding(7);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(61, 13);
            this.LabelName.TabIndex = 32;
            this.LabelName.Text = "LabelName";
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.Controls.Add(this.LabelName);
            this.panel5.Controls.Add(this.LabelPremier);
            this.panel5.Controls.Add(this.LabelRaiting);
            this.panel5.Controls.Add(this.LabelCountry);
            this.panel5.Controls.Add(this.LabelType);
            this.panel5.Controls.Add(this.LabelProducer);
            this.panel5.Controls.Add(this.LabelDuration);
            this.panel5.Controls.Add(this.LabelTranslation);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(99, 347);
            this.panel5.TabIndex = 40;
            // 
            // PosterPictureBox
            // 
            this.PosterPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PosterPictureBox.Location = new System.Drawing.Point(5, 5);
            this.PosterPictureBox.Name = "PosterPictureBox";
            this.PosterPictureBox.Size = new System.Drawing.Size(188, 300);
            this.PosterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PosterPictureBox.TabIndex = 13;
            this.PosterPictureBox.TabStop = false;
            // 
            // FilmTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 448);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FilmTemplate";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "FilmTemplate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FilmTemplate_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PosterPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExitForm3;
        private System.Windows.Forms.Button TrailerButton;
        private System.Windows.Forms.PictureBox PosterPictureBox;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label IsNewLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelPremier;
        private System.Windows.Forms.Label LabelRaiting;
        private System.Windows.Forms.Label LabelCountry;
        private System.Windows.Forms.Label LabelType;
        private System.Windows.Forms.Label LabelProducer;
        private System.Windows.Forms.Label LabelDuration;
        private System.Windows.Forms.Label LabelTranslation;
    }
}