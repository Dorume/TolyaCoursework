using System;
using System.Collections.Generic;
using курсач.Films.Film;
namespace курсач.Films
{
    static class FilmsC
    {
        public static List<FilmC> FilmsList = new List<FilmC>();

        static FilmsC()
        {
            AddFilm(
                new FilmC[] 
                {
                    new FilmC() {Name = "Закляття 2", Duration = 133,
                        IsNew = true, Jenres = "Хорор", 
                        Producer = "Джеймс Ван", Country = "USA", 
                        Description = "Some", TypeF = TypeOfFilm.Film,
                        TrailerURL = "https://www.youtube.com/watch?v=A5PaKL70hcI",
                        Rating = "4/5", Translation = "Дубляж",
                        ReleaseData = DateTime.Now,
                        Poster = Properties.Resources.Проклятие},

                    new FilmC() {Name = "Simpons", Duration = 133,
                        IsNew = false, Jenres = "Хорор",
                        Producer = "Джеймс Ван", Country = "USA",
                        Description = "Some", TypeF = TypeOfFilm.Film,
                        TrailerURL = "https://www.youtube.com/watch?v=A5PaKL70hcI",
                        Rating = "4/5", Translation = "Дубляж",
                        ReleaseData = DateTime.Now,
                        Poster = Properties.Resources.Procklyatie}
                }
                );
        }

        private static void AddFilm(FilmC[] films)
        {
            foreach (FilmC film in films)
            {
                FilmsList.Add(film);
            }
        }
    }
}
