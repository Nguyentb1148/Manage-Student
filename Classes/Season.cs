using System.Collections.Generic;
using ManageMovie.Interface;

namespace ManageMovie.Classes
{
    public class Season
    {
        private List<IMovie> season;

        public List<IMovie> Episodes
        {
            get => season;
            set => season = value;
        }

        public Season(List<IMovie> season)
        {
            this.Episodes = season;
        }
    }
}