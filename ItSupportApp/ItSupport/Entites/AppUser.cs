﻿using System.ComponentModel.DataAnnotations;

namespace ItSupport.Entites
{
	public class AppUser
	{
        public int Id { get; set; }
        [Required]
        public string? Username { get; set; }
        [Required]
        public byte[]? PasswordHash { get; set; }
		[Required]
  		public byte[]? PasswordSalt { get; set; }

    }
}
