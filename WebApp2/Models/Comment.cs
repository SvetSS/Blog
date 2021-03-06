using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp2.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }


        public int PostId { get; set; }
        public Post Post { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
