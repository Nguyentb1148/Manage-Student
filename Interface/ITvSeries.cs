using System.Collections.Generic;
using ManageMovie.Classes;

namespace ManageMovie.Interface
{
    public interface ITvSeries : IMovie
    {
        List<IMovie> Season { get; set; }
    }
}