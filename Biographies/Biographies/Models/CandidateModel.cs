using System;
using System.ComponentModel.DataAnnotations;

namespace Biographies.Models
{
    public class CandidateModel
    {
        public int IdCandidate { get; set; }

        [Required]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle name")]
        public string SecondName { get; set; }

        [Required]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Display(Name = "Second last name")]
        public string SecondLastName { get; set; }

        [Required]
        public System.DateTime BirthDate { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Cellphone { get; set; }

        public Nullable<int> FOJ { get; set; }
        public Nullable<int> Location { get; set; }
        public Nullable<int> Site { get; set; }
        public Nullable<int> Market { get; set; }
    }
}