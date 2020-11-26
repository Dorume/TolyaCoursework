
namespace курсач
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.ExitForm2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TrailerForm2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitForm2
            // 
            this.ExitForm2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitForm2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ExitForm2.FlatAppearance.BorderSize = 0;
            this.ExitForm2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitForm2.ForeColor = System.Drawing.Color.Gainsboro;
            this.ExitForm2.Location = new System.Drawing.Point(536, 13);
            this.ExitForm2.Name = "ExitForm2";
            this.ExitForm2.Size = new System.Drawing.Size(75, 23);
            this.ExitForm2.TabIndex = 9;
            this.ExitForm2.Text = "X";
            this.ExitForm2.UseVisualStyleBackColor = false;
            this.ExitForm2.Click += new System.EventHandler(this.ExitForm2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(269, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 182);
            this.label1.TabIndex = 11;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // TrailerForm2
            // 
            this.TrailerForm2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TrailerForm2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TrailerForm2.FlatAppearance.BorderSize = 0;
            this.TrailerForm2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrailerForm2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrailerForm2.ForeColor = System.Drawing.Color.Gainsboro;
            this.TrailerForm2.Location = new System.Drawing.Point(65, 305);
            this.TrailerForm2.Name = "TrailerForm2";
            this.TrailerForm2.Size = new System.Drawing.Size(183, 40);
            this.TrailerForm2.TabIndex = 12;
            this.TrailerForm2.Text = "Трийлер";
            this.TrailerForm2.UseVisualStyleBackColor = false;
            this.TrailerForm2.Click += new System.EventHandler(this.TrailerForm2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.TrailerForm2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ExitForm2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(624, 383);
            this.panel1.TabIndex = 13;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 385);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitForm2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TrailerForm2;
        private System.Windows.Forms.Panel panel1;
    }
}