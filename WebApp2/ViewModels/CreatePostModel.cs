using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace WebApp2.ViewModels
{
    public class CreatePostModel
    {
        public IFormFile PostImage { get; set; }
        [Required]
        [Display(Name = "Название")]
        public string Caption { get; set; }
        [Required]
        [Display(Name = "Содержание")]
        public string Content { get; set; }
        public string UserId { get; set; }
        //123P0@nb
    }
}
