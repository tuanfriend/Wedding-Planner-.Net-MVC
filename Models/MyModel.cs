using System.ComponentModel.DataAnnotations;
using System;
using WeddingProj.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace WeddingProj.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        // MySQL VARCHAR and TEXT types can be represeted by a string
        [Required]
        [MinLength(2, ErrorMessage = "First name has to be atleast 2 characters!")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Last name has to be atleast 2 characters!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter correct email or change other email!")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Password has to be atleast 2 characters!")]
        public string Password { get; set; }
        // The MySQL DATETIME type can be represented by a DateTime
        public DateTime Created_at { get; set; } = DateTime.Now;
        public DateTime Updated_at { get; set; } = DateTime.Now;

        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmPw { get; set; }

        public List<WedConnect> UsertoWed { get; set; }
    }
    public class LoginUser
    {
        // No other fields!
        [Required(ErrorMessage = "Please enter correct email!")]
        [EmailAddress]
        public string LoginEmail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string LoginPassword { get; set; }
    }

    public class Wedding
    {
        [Key]
        public int WeddingId { get; set; }
        [Required]
        public string WedOne { get; set; }
        [Required]
        public string WedTwo { get; set; }
        [Required]
        public DateTime WedDate { get; set; }
        [Required]
        public string WedAddress { get; set; }
        public int UserId {get; set;}

        public DateTime Created_at { get; set; } = DateTime.Now;
        public DateTime Updated_at { get; set; } = DateTime.Now;
        public List<WedConnect> WedtoUser { get; set; }
    }

    public class WedConnect
    {
        [Key]
        public int WedConnectId { get; set; }
        public int UserId { get; set; }
        public int WeddingId { get; set; }
        public User User { get; set; }
        public Wedding Wedding { get; set; }
    }
}