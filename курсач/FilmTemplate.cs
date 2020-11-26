﻿using System;
using System.Windows.Forms;
using курсач.Films.Film;

namespace курсач
{
    public partial class FilmTemplate : Form
    {
        private FilmC _Film = new FilmC();

        public FilmC Film 
        { 
            get => _Film;
            set
            {
                _Film = value;
                RefreshLabels();
            } 
        }


        public FilmTemplate()
        {
            InitializeComponent();
        }

        private void RefreshLabels()
        {
            LabelName.Text = "Назва: " + _Film.Name;
            LabelCountry.Text = "Країна: " + _Film.Country;
            LabelDescription.Text = "Опис: " + _Film.Description;
            LabelDuration.Text = "Тривалість: " + _Film.Duration.ToString() + " хв.";
            LabelPremier.Text = "Дата прем'єри: " + _Film.ReleaseData.ToString();
            LabelProducer.Text = "Режисер: " + _Film.Producer;
            LabelRaiting.Text = "Рейтинг: " + _Film.Rating;
            LabelTranslation.Text = "Дубляж: " + _Film.Translation;
            LabelType.Text = "Тип: " + _Film.TypeF.ToString();
            IsNewLabel.Visible = _Film.IsNew;
            PosterPictureBox.Image = _Film.Poster;
        }

        private void TrailerButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(_Film.TrailerURL);
        }

        private void FilmTemplate_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
