using System;
namespace lab_10
{
    class Movie
    {
        
       
            //////fields
            
        private string _catagory;
        private string _movieTitle;

            //////properties

        public string Catagory
        {
            get
            {
                return _catagory;
            }
            set
            {
                _catagory = value;
            }
        }

        public string MovieTitle
        {
            get
            {
                return _movieTitle;
            }
            set
            {
                _movieTitle = value;
            }
        }

        public Movie()
        {

        }

        public Movie(string _movieTitle, string _catagory)
        {
            MovieTitle = _movieTitle;
            Catagory = _catagory;
        }
        
    }
}
