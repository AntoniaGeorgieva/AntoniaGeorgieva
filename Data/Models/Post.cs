using System.ComponentModel.DataAnnotations;

namespace project1.Data.Models
{
    public class Post
    {
        [Required]
        public string Title { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        [Required] 
        public DateTime Date { get; set; }

        [Required]
        public string Creator { get; set; } = null!;

        [Required]
        public List<string> SkillsRequired { get; set; } = null!;
    }
}
