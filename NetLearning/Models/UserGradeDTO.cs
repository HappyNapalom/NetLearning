using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Grade.Models
{
    public class ExpandedUserGradeDTO
    {
        [Key]
        [Display(Name = "Sections")]
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [Display(Name = "Lockout End Date Utc")]
        public DateTime? LockoutEndDateUtc { get; set; }
        public int AccessFailedCount { get; set; }
        public string PhoneNumber { get; set; }
        public IEnumerable<UserGradeDTO> Roles { get; set; }
    }

    public class UserGradesDTO
    {
        [Key]
        [Display(Name = "Grade Number")]
        public string GradeNo { get; set; }
    }

    public class UserGradeDTO
    {
        [Key]
        [Display(Name = "Grade Number")]
        public string GradeNo { get; set; }
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }
    }

    public class GradeDTO
    {
        [Key]
        public string Id { get; set; }
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }
    }

    public class UserAndGradeDTO
    {
        [Key]
        [Display(Name = "Grade Number")]
        public string GradeNo { get; set; }
        public List<UserGradeDTO> colUserGradeDTO { get; set; }
    }
}