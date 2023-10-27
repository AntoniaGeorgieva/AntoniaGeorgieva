using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project1.Data.Models
{
    public class Post
    {
        [Required]
        public int Id { get; set; }
        

        [Required]
        public string Title { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        [Required] 
        public DateTime Date { get; set; }

        [Required]
        public int CreatorId { get; set; }

        //[ForeignKey(CreatorId)]
        //public IdentityUser Creator { get; set; } = null!;
        [Required]
        public List<string> SkillsRequired { get; set; } = null!;
    }
}
