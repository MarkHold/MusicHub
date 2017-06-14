using System.ComponentModel.DataAnnotations;
namespace FullstackCourse.Models
{
    public class Genre
    {
        //Method for genre ID, the reason why we use byte is because we wont need to have 
        //more than 255 genres. 
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}