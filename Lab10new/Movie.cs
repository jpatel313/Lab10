using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10new
{
    class Movie
    {
        private string title;
        private string category;

        public string Title1
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string Category1
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }

        public Movie(string inputTitles, string inputCategories)
        {
        Title1 = inputTitles; Category1 = inputCategories;
        }


    }
}
