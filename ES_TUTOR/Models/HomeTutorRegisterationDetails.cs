using System.ComponentModel.DataAnnotations;

namespace ES_TUTOR.Models
{
    public class HomeTutorRegisterationDetails
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string? Address { get; set; }
        public string? Country { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }

        public DateTime? DOB { get; set; }
        public string Mobile { get; set; }
        public string Qualification { get; set; }
        public float TeachingExperience { get; set; }
        public string CoreSubject { get; set; }
        public int TeachingClass { get; set; }
        public string TeachingMedium { get; set; }
        public string TeachingBoard { get; set; } // Home Tutor
        public bool? IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public string? IsRole { get; set; }
    }
}
