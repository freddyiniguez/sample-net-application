//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Biographies.Entities
{
    using System;
    
    public partial class sp_bios_candidates_get_Result
    {
        public int IdCandidate { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string SecondLastName { get; set; }
        public System.DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Cellphone { get; set; }
        public Nullable<int> FOJ { get; set; }
        public Nullable<int> Location { get; set; }
        public Nullable<int> Site { get; set; }
        public Nullable<int> Market { get; set; }
    }
}
