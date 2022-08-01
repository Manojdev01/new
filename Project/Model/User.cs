﻿namespace Project.Model
{
    public class User2
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        
        public string Email { get; set; } = string.Empty;  
        public byte[] PasswordHash { get; set; } = new byte[32];
        public byte[] PasswordSalt { get; set; } = new byte[32]; 
        public string? VerificationToken { get; set; }
        public DateTime? VerifiedAt { get; set; }   
        public string? PasswordRestToken { get; set; }  
        public DateTime? ResetTokenExpires { get; set; }
        public long? PhoneNumber { get; set; } 

    }
}
