﻿using System.ComponentModel.DataAnnotations;

namespace EmpCRUD.Shared.Model
{
    public class Emp
    {
        public int Id { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public decimal? Salary { get; set; }
    }
}
