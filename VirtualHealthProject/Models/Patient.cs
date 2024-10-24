using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace VirtualHealthProject.Models
{
    public class Patient
    {
        [Key]
        public int PatientID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        [RegularExpression(@"\d{3}-\d{3}-\d{4}", ErrorMessage = "Contact Number must be in the format XXX-XXX-XXXX.")]
        public string ContactNumber { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Invalid email format. Email must contain '@' and be valid.")]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string PostalCode { get; set; }
        [Required]
        public string PrimaryConcern { get; set; }

        public List<string> MedicalHistory { get; set; } = new();
        public List<string> ChronicIllness { get; set; } = new();
        public List<string> Allergies { get; set; } = new();
        public List<string> CurrentMedication { get; set; } = new();

        public virtual ICollection<CurrentMedication> CurrentMedications { get; set; }
        public virtual ICollection<MedicalHistory> MedicalHistories { get; set; }
        public virtual ICollection<ChronicIllness> ChronicIllnesses { get; set; }

        public class EmailContainsAtAttribute : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                var email = value as string;

                if (!string.IsNullOrEmpty(email) && email.Contains("@"))
                {
                    return ValidationResult.Success;
                }

                return new ValidationResult(ErrorMessage);
            }
        }
    }
}
