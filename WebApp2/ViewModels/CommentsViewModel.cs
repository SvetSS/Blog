using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp2.Models;

namespace WebApp2.ViewModels
{
    public class CommentsViewModel
    {
        public int PostId { get; set; }
        public List<Comment> Comments { get; set; }
        public Comment NewComment { get; set; }
    }
}
