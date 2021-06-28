using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebApp2.Models
{
    public class User: IdentityUser
    {
    public List<Comment> Comments { get; set; }
    public List<Post> Posts { get; set; }

    public User()
    {
        Comments = new List<Comment>();
        Posts = new List<Post>();
    }
    }
}
