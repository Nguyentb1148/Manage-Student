using System;

namespace ManageMovie.Interface
{
    public interface IMovie
    {
        int Id { get; set; }
        string IdFilm { get; set; }
        string Name { get; set; }
        string Kind { get; set; }
        string Director { get; set; }
        string FilmClassification { get; set; }
        string FilmAdaptation { get; set; }
        DateTime FilmDuration { get; set; }
        DateTime ReleaseDate { get; set; }
        double ImdbPoints { get; set; }

        void AddFilm();
        void ViewListFilm();
        void SearchFilmByID(string search);
        void DeleteFilmByID(string s);
        void UpdateFilmByID(string s);
        void SoftFilmByID();
    }
}