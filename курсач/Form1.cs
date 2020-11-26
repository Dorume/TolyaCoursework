using System;
using System.Windows.Forms;
using курсач.Films;
using курсач.Films.Film;

namespace курсач
{
    public partial class Form1 : Form
    {
        private FilmTemplate FilmForm { get; set; } = new FilmTemplate();
        public Form1()
        {
            InitializeComponent();
            FillSideMenu();
            customizeDesing();
        }

        private void FillSideMenu()
        {
            FillNewFilms();
        }

        private void FillNewFilms()
        {
            foreach (FilmC film in FilmsC.FilmsList)
            {
                if (film.IsNew)
                    AddFilmToNew(film.Name);
            }
        }

        private void AddFilmToNew(string nameOfFilm)
        {
            Button button = new Button();
            button.Dock = DockStyle.Top;
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = FlatStyle.Flat;
            button.ForeColor = System.Drawing.Color.LightGray;
            button.Text = nameOfFilm;
            button.Padding = new Padding(25, 0, 0, 0);
            button.Size = new System.Drawing.Size(169, 26);
            button.Name = nameOfFilm;
            button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button.UseVisualStyleBackColor = true;
            panelNewsMenu.Controls.Add(button);
            panelNewsMenu.Tag = button;
            button.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            foreach (FilmC film in FilmsC.FilmsList)
            {
                if(button.Text == film.Name)
                {
                    FilmForm.Film = film;
                    openChildForm(FilmForm);
                }
            }
        }

        private void customizeDesing()
        {
            panelNewsMenu.Visible = false;
            panelGenresMenu.Visible = false;

        }

        private void hideSubMenu()
        {
            if (panelNewsMenu.Visible == true)
                panelNewsMenu.Visible = false;
            if (panelGenresMenu.Visible == true)
                panelGenresMenu.Visible = false;
        
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void btnNews_Click(object sender, EventArgs e)
        {
            showSubMenu(panelNewsMenu);
        }
        #region NewsSubMenu
        private void Zaklyatiye_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
        }

        private void Zaklyatiye2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
        }

#endregion
        private void btnGenres_Click(object sender, EventArgs e)
        {
            showSubMenu(panelGenresMenu);
        }
        #region GenresSubMenu

        private void Horror_Click(object sender, EventArgs e)
        {
            openChildForm(new Form4());

        }

        private void boyevyk_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void survival_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void Detective_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
#endregion

        private void btnFilms_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            hideSubMenu();
        }

        private void btnSeries_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            //Width = panelSideMenu.Width + childForm.Width;
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
             
    }
}
