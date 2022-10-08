using System;

namespace ManageMovie.Interface
{
    public interface IMovie
    {
        string Id { get; set; }
        string Kind { get; set; }
        string Director { get; set; }
        string FilmClassification { get; set; }
        string FilmAdaptation { get; set; }
        string Review { get; set; }
        DateTime ReleaseDate { get; set; }
        double ImdbPoints { get; set; }
    }
}