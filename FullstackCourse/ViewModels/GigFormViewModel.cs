using FullstackCourse.Models;
using System.Collections.Generic;

namespace FullstackCourse.ViewModels
{
    public class GigFormViewModel
    {
        public string Venu { get; set; }
        public string Date { get; set; }
        
        public string Time { get; set; }

        public int Genre { get; set; }

        public IEnumerable<Genre> Genres { get; set; }
    }
}