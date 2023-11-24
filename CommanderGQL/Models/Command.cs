﻿using System.ComponentModel.DataAnnotations;

namespace CommanderGQL.Models
{
    public class Command
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string HowTo { get; set; } = string.Empty;
        [Required]
        public string CommandLine { get; set; } = string.Empty;
        [Required]
        public int PlatformId { get; set; }
        public Platform Platform { get; set; }
    }
}
