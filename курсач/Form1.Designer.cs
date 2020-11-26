
namespace курсач
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnFilm = new System.Windows.Forms.Button();
            this.btnSeries = new System.Windows.Forms.Button();
            this.panelGenresMenu = new System.Windows.Forms.Panel();
            this.Detective = new System.Windows.Forms.Button();
            this.survival = new System.Windows.Forms.Button();
            this.boyevyk = new System.Windows.Forms.Button();
            this.Horror = new System.Windows.Forms.Button();
            this.btnGenres = new System.Windows.Forms.Button();
            this.panelNewsMenu = new System.Windows.Forms.Panel();
            this.btnNews = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelGenresMenu.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Controls.Add(this.btnSeries);
            this.panelSideMenu.Controls.Add(this.panelGenresMenu);
            this.panelSideMenu.Controls.Add(this.btnGenres);
            this.panelSideMenu.Controls.Add(this.panelNewsMenu);
            this.panelSideMenu.Controls.Add(this.btnNews);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(169, 599);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Controls.Add(this.btnFilm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 302);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 100);
            this.panel1.TabIndex = 8;
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHelp.Location = new System.Drawing.Point(0, 32);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(169, 30);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnFilm
            // 
            this.btnFilm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilm.FlatAppearance.BorderSize = 0;
            this.btnFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilm.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFilm.Location = new System.Drawing.Point(0, 0);
            this.btnFilm.Name = "btnFilm";
            this.btnFilm.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFilm.Size = new System.Drawing.Size(169, 32);
            this.btnFilm.TabIndex = 5;
            this.btnFilm.Text = "Фільми";
            this.btnFilm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilm.UseVisualStyleBackColor = true;
            this.btnFilm.Click += new System.EventHandler(this.btnFilms_Click);
            // 
            // btnSeries
            // 
            this.btnSeries.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeries.FlatAppearance.BorderSize = 0;
            this.btnSeries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeries.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSeries.Location = new System.Drawing.Point(0, 272);
            this.btnSeries.Name = "btnSeries";
            this.btnSeries.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSeries.Size = new System.Drawing.Size(169, 30);
            this.btnSeries.TabIndex = 6;
            this.btnSeries.Text = "Серіали";
            this.btnSeries.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeries.UseVisualStyleBackColor = true;
            this.btnSeries.Click += new System.EventHandler(this.btnSeries_Click);
            // 
            // panelGenresMenu
            // 
            this.panelGenresMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelGenresMenu.Controls.Add(this.Detective);
            this.panelGenresMenu.Controls.Add(this.survival);
            this.panelGenresMenu.Controls.Add(this.boyevyk);
            this.panelGenresMenu.Controls.Add(this.Horror);
            this.panelGenresMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGenresMenu.Location = new System.Drawing.Point(0, 160);
            this.panelGenresMenu.Name = "panelGenresMenu";
            this.panelGenresMenu.Size = new System.Drawing.Size(169, 112);
            this.panelGenresMenu.TabIndex = 4;
            // 
            // Detective
            // 
            this.Detective.Dock = System.Windows.Forms.DockStyle.Top;
            this.Detective.FlatAppearance.BorderSize = 0;
            this.Detective.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Detective.ForeColor = System.Drawing.Color.LightGray;
            this.Detective.Location = new System.Drawing.Point(0, 78);
            this.Detective.Name = "Detective";
            this.Detective.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Detective.Size = new System.Drawing.Size(169, 26);
            this.Detective.TabIndex = 3;
            this.Detective.Text = "Детектив";
            this.Detective.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Detective.UseVisualStyleBackColor = true;
            this.Detective.Click += new System.EventHandler(this.Detective_Click);
            // 
            // survival
            // 
            this.survival.Dock = System.Windows.Forms.DockStyle.Top;
            this.survival.FlatAppearance.BorderSize = 0;
            this.survival.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.survival.ForeColor = System.Drawing.Color.LightGray;
            this.survival.Location = new System.Drawing.Point(0, 52);
            this.survival.Name = "survival";
            this.survival.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.survival.Size = new System.Drawing.Size(169, 26);
            this.survival.TabIndex = 2;
            this.survival.Text = "Виживання";
            this.survival.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.survival.UseVisualStyleBackColor = true;
            this.survival.Click += new System.EventHandler(this.survival_Click);
            // 
            // boyevyk
            // 
            this.boyevyk.Dock = System.Windows.Forms.DockStyle.Top;
            this.boyevyk.FlatAppearance.BorderSize = 0;
            this.boyevyk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boyevyk.ForeColor = System.Drawing.Color.LightGray;
            this.boyevyk.Location = new System.Drawing.Point(0, 26);
            this.boyevyk.Name = "boyevyk";
            this.boyevyk.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.boyevyk.Size = new System.Drawing.Size(169, 26);
            this.boyevyk.TabIndex = 1;
            this.boyevyk.Text = "Боєвик";
            this.boyevyk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boyevyk.UseVisualStyleBackColor = true;
            this.boyevyk.Click += new System.EventHandler(this.boyevyk_Click);
            // 
            // Horror
            // 
            this.Horror.Dock = System.Windows.Forms.DockStyle.Top;
            this.Horror.FlatAppearance.BorderSize = 0;
            this.Horror.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Horror.ForeColor = System.Drawing.Color.LightGray;
            this.Horror.Location = new System.Drawing.Point(0, 0);
            this.Horror.Name = "Horror";
            this.Horror.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Horror.Size = new System.Drawing.Size(169, 26);
            this.Horror.TabIndex = 0;
            this.Horror.Text = "Ужаси";
            this.Horror.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Horror.UseVisualStyleBackColor = true;
            this.Horror.Click += new System.EventHandler(this.Horror_Click);
            // 
            // btnGenres
            // 
            this.btnGenres.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenres.FlatAppearance.BorderSize = 0;
            this.btnGenres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenres.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGenres.Location = new System.Drawing.Point(0, 130);
            this.btnGenres.Name = "btnGenres";
            this.btnGenres.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGenres.Size = new System.Drawing.Size(169, 30);
            this.btnGenres.TabIndex = 3;
            this.btnGenres.Text = "Жанри";
            this.btnGenres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenres.UseVisualStyleBackColor = true;
            this.btnGenres.Click += new System.EventHandler(this.btnGenres_Click);
            // 
            // panelNewsMenu
            // 
            this.panelNewsMenu.AutoSize = true;
            this.panelNewsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelNewsMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNewsMenu.Location = new System.Drawing.Point(0, 130);
            this.panelNewsMenu.Name = "panelNewsMenu";
            this.panelNewsMenu.Size = new System.Drawing.Size(169, 0);
            this.panelNewsMenu.TabIndex = 2;
            // 
            // btnNews
            // 
            this.btnNews.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNews.FlatAppearance.BorderSize = 0;
            this.btnNews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNews.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNews.Location = new System.Drawing.Point(0, 100);
            this.btnNews.Name = "btnNews";
            this.btnNews.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNews.Size = new System.Drawing.Size(169, 30);
            this.btnNews.TabIndex = 1;
            this.btnNews.Text = "Новинки";
            this.btnNews.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNews.UseVisualStyleBackColor = true;
            this.btnNews.Click += new System.EventHandler(this.btnNews_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(169, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(169, 0);
            this.panelChildForm.MinimumSize = new System.Drawing.Size(551, 499);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(679, 599);
            this.panelChildForm.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(245, 250);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 599);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(864, 638);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelGenresMenu.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnSeries;
        private System.Windows.Forms.Button btnFilm;
        private System.Windows.Forms.Panel panelGenresMenu;
        private System.Windows.Forms.Button Detective;
        private System.Windows.Forms.Button survival;
        private System.Windows.Forms.Button boyevyk;
        private System.Windows.Forms.Button Horror;
        private System.Windows.Forms.Button btnGenres;
        private System.Windows.Forms.Panel panelNewsMenu;
        private System.Windows.Forms.Button btnNews;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

