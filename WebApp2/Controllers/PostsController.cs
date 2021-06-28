using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WebApp2.Data;
using WebApp2.Models;
using WebApp2.Services;
using WebApp2.ViewModels;

namespace WebApp2.Controllers
{
    public class PostsController : Controller
    {
        
        private readonly IRecaptchaService _recaptcha;
        private UserManager<IdentityUser> userManager;
        private readonly ApplicationDbContext _context;
        private FileUploadService fileUploadService;
        private IHostingEnvironment environment;

        public PostsController(IRecaptchaService recaptcha, UserManager<IdentityUser> userManager, ApplicationDbContext context,
            FileUploadService fileUploadService,
            IHostingEnvironment environment)
        {
            _recaptcha = recaptcha;
            this.userManager = userManager;
            _context = context;
            this.fileUploadService = fileUploadService;
            this.environment = environment;
        }

        // GET: Posts
        public IActionResult Index()
        {
            List<Post> topics = _context.Posts.Include(t => t.User).ToList();
            return View(topics);
            //Post post = _context.Posts.FirstOrDefault()
        }

        // GET: Posts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // GET: Posts/Create
        public IActionResult Create()
        {
           // ViewData["UserId"] = new SelectList(_context.Set<User>(), "Id", "Id");
            return View();
        }

        // POST: Posts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(string UserId, CreatePostModel model)
        {
            
            IdentityUser user = await userManager.FindByIdAsync(UserId);
            // IdentityUser user = _context.Users.FirstOrDefault(u => u.UserName == HttpContext.User.Identity.Name);
            Post post = new Post();
            //{
            //    DateCreated = DateTime.Now,
            //    Caption = model.Caption,
            //    Content = model.Content,
            //    UserId = UserId,
            //    PostImagePath = $"images/{user.Email}/{model.PostImage.FileName}"
            //};
            post.DateCreated = DateTime.Now;
            post.UserId = UserId;
            post.Content = model.Content;
            post.Caption = model.Caption;
            post.PostImagePath = ""; //"/images/image_def.jpg";
            if (model.PostImage != null)
            { 
                post.PostImagePath = $"/images/{user.Email}/{model.PostImage.FileName}";
                _context.Posts.Add(post);

                string path = Path.Combine(
                environment.WebRootPath,//environment.ContentRootPath 
                $"images\\{user.Email}");
                fileUploadService.Upload(path, model.PostImage.FileName, model.PostImage);
                _context.SaveChanges();
            }
            else
            {
                _context.Posts.Add(post);
                _context.SaveChanges();
            }
            return RedirectToAction("Index", "Home");
        }
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            IdentityUser user = _context.Users.FirstOrDefault(u => u.UserName == HttpContext.User.Identity.Name);
            if (id == null)
            {
                return NotFound();
            }

                var post = await _context.Posts.FindAsync(id);
                if (post.UserId == user.Id)
                {
                    EditPostModel model = new EditPostModel();
                    model.Caption = post.Caption;
                    model.Content = post.Content;
                    model.Path_postimg = post.PostImagePath;
                    return View(model);
                }
                
            //ViewData["UserId"] = new SelectList(_context.Set<User>(), "Id", "Id", post.UserId);
            return  RedirectToAction("ErrorAuth", "Posts"); 
        }

        // POST: Posts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(/*int id,  string UserId*/EditPostModel model, int id)
        {
            var post = await _context.Posts.FindAsync(id);
            //if (id != model.Id)
            //{
            //    return NotFound();
            //};
            IdentityUser user = _context.Users.FirstOrDefault(u => u.UserName == HttpContext.User.Identity.Name);
            
            if (ModelState.IsValid)
            {
                try
                {
                    if (model.PostImage != null )
                    {
                        post.PostImagePath = $"/images/{post.User.Email}/{model.PostImage.FileName}";
                       // _context.Posts.Add(post);

                        string path = Path.Combine(
                            environment.WebRootPath,//environment.ContentRootPath 
                            $"images\\{post.User.Email}");
                        fileUploadService.Upload(path, model.PostImage.FileName, model.PostImage);
                        _context.Update(post);
                        _context.SaveChanges();
                        return RedirectToAction("Details", "Posts", new { post.Id });
                    }
                    else
                    {
                        _context.Update(post);
                        await _context.SaveChangesAsync();
                    }
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostExists(post.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Error", "Posts");
            }

           // IdentityUser user = await userManager.FindByIdAsync(UserId);
           // ViewData["UserId"] = new SelectList(_context.Set<User>(), "Id", "Id", post.UserId);
            return RedirectToAction("Details", "Posts", new { post.Id });
        }
        

        // GET: Posts/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // POST: Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            IdentityUser user = _context.Users.FirstOrDefault(u => u.UserName == HttpContext.User.Identity.Name);
            var post = await _context.Posts.FindAsync(id);
            if (post.UserId == user.Id)
            {
                _context.Posts.Remove(post);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction("ErrorAuth", "Posts");
        }

        private bool PostExists(int id)
        {
            return _context.Posts.Any(e => e.Id == id);
        }

        public IActionResult Error()
        {
            return View();
        }
        [HttpPost]
        public string Like(int postId)
        {
            IdentityUser user = _context.Users.FirstOrDefault(u => u.UserName == HttpContext.User.Identity.Name);
            //TdentityUser user = _context.Users.FirstOrDefault(u => u.Login == HttpContext.User.Identity.Name);
            Post post = _context.Posts.FirstOrDefault(p => p.Id == postId);
            Like like = _context.Likes.FirstOrDefault(s => s.PostId == postId && s.UserId==user.Id);
            
            if (like == null)
            {
                _context.Likes.Add(new Like()
                {
                    LikeDate = DateTime.Now,
                    PostId = postId,
                    User = user
                });
                post.Likes++;
            }
            else
            {
                _context.Likes.Remove(like);

                post.Likes--;
            }

            _context.SaveChanges();

            return post.Likes.ToString();//JsonConvert.SerializeObject(post, new JsonSerializerSettings() {ReferenceLoopHandling = ReferenceLoopHandling.Ignore});
        }

        public IActionResult ErrorAuth()
        {
            return View();
        }
        [HttpPost]
        
        public ActionResult CommentsList(int postId)
        {
            IQueryable<Comment> source = _context.Comments.Where(c => c.PostId == postId);
            return PartialView(source);
        }

        [HttpPost]
        public IActionResult AjaxComment(int postId, string login, string content)
        {
            //var captchaResponse = _recaptcha.Validate(Request.Form);

            //if (!captchaResponse.IsCompletedSuccessfully)
            //{
            //    ModelState.AddModelError("", "Подтвердите, что Вы не робот");
            //    //return Content("Подтвердите, что Вы не робот"); 
            //    return RedirectToAction("Index");
            //}код для проверки рекапчи
            Post post = _context.Posts.FirstOrDefault(p => p.Id == postId);
            Comment comment = new Comment() { Text = content, DateCreated = DateTime.Now, PostId = post.Id, Email = login};

            comment.Text = content;
            _context.Comments.Add(comment);
            _context.SaveChanges();


            string com = content;
            return Json(com);

        }
    }
}
