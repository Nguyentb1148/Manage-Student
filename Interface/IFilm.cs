using System;

namespace ManageMovie.Interface
{
    public interface IFilm: IMovie
    {
        DateTime FilmDuration { get; set; }
    }
}