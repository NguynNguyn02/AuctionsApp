﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Auctions.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        [Required]
        public string? IdentityUserId { get; set; }
        [ForeignKey("IdentityUserId")]
        public IdentityUser? User { get; set; }
        public List<Bid>? Bids { get; set; }
        public List<Comment>? Comments { get; set; }
    }
}