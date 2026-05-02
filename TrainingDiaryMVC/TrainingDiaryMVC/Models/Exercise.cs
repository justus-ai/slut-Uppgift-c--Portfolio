using System.ComponentModel.DataAnnotations;

namespace TrainingDiaryMVC.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}