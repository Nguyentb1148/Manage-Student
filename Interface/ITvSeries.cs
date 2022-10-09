using System.Collections.Generic;
using ManageMovie.Classes;

namespace ManageMovie.Interface
{
    public interface ITvSeries : IMovie
    {
        List<Season> Season { get; set; }
    }
}