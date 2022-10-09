using System;

namespace ManageMovie.Interface
{
    public interface IFilm: IMovie
    {
        string IdFilm { get; set; }
        DateTime FilmDuration { get; set; }
    }
}