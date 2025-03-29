using System.ComponentModel.DataAnnotations;

namespace ES_TUTOR.Models
{
    public class StudentRegisterationDetails
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string? Address { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }

        public DateTime? DOB { get; set; }
        public string Mobile { get; set; }
        public string CoreSubject { get; set; }
        public string StudentMedium { get; set; }//Student
        public bool? IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public string? IsRole { get; set; }
    }
}
