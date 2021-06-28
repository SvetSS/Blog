using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace WebApp2.ViewModels
{
    public class EditPostModel
    {
        public int Id { get; set; }
        public IFormFile PostImage { get; set; }
        [Required]
        [Display(Name = "Название")]
        public string Caption { get; set; }
        public string Path_postimg { get; set; }
        [Required]
        [Display(Name = "Содержание")]
        public string Content { get; set; }
        public string UserId { get; set; }
    }
}
