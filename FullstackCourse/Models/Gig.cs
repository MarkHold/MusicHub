using System;
using System.ComponentModel.DataAnnotations;

namespace FullstackCourse.Models
{
    /* This class represents a gig or song, it captures who is preforming it, when and more.

          In order to do this, we need to start with the who part. We need to associate this class 
          with another pre-existing class in ASP.NET that represents a user in this Application. That class 
          is, which is IdentitiyModels.cs */
    public class Gig
    {
        public int Id { get; set; }
         //here we create a property of type Application User

        [Required]
        public ApplicationUser Artist { get; set; }

        //Another property of date time 
       public DateTime DateTime { get; set; }

        //Another property for Venu

        [Required]
        [StringLength(255)]
        public string Venu { get; set; }

        [Required]
        public Genre Genre { get; set; }
    }

    
} 