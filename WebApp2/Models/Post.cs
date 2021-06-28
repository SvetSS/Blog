using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebApp2.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Название")]
        public string Caption { get; set; }
        [Display(Name = "Содержание")]
        public string Content { get; set; }

        public string PostImagePath { get; set; }
        public int Likes { get; set; }
        
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
        [Display(Name = "Дата")]
        public DateTime DateCreated { get; set; }

        public List<Comment> Comments { get; set; }

        public Post()
        {
            Comments = new List<Comment>();
        }
    }
}
