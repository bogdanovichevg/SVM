using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SWM_APP.Models;
using SWM_APP.Models.DdContext;
using SWM_APP.Models.DdContext.Entity;
using SWM_APP.Models.Req;

namespace SWM_APP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DatabaseContext _context;
        public HomeController(ILogger<HomeController> logger, DatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var wsrefs = _context.WSREF.OrderByDescending(el=>el.Id).ToList();
            return View(wsrefs);
        }

        [HttpGet("filterform")]
        public IActionResult GetFilter()
        {
            return PartialView("_Filter");
        }


        [HttpGet("signIn")]
        public IActionResult signIn()
        {
            return View("_SignIn");
        }

        [HttpPost("signInCheck")]
        public IActionResult signInCheck(AuthModel model)
        {
            if (model.ChecAdmin())
            {
                HttpContext.Session.SetString("IsAdmin", true.ToString());
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost("signInReset")]
        public IActionResult SignInReset()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet("filter")]
        public IActionResult Filter(string name)
        {
            name = name ?? "";
            var wsrefs = _context.WSREF.Where(el=>el.Description.ToLower().Contains(name.ToLower())).OrderByDescending(el => el.Id).ToList();
            return View("Index",wsrefs);
        }

        [HttpGet("Insert")]
        public IActionResult Insert()
        {
            return PartialView("_Insert");
        }

        [HttpGet("Update/{id}")]
        public IActionResult Update(int id)
        {
            var user = _context.WSREF.Find(id);
            return PartialView("_Update",user);
        }

        [HttpGet("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var user = _context.WSREF.Find(id);
            return PartialView("_Delete", user);
        }

        [HttpPost("Delete/{id}")]
        public IActionResult DeleteById(int id)
        {
            var user = _context.WSREF.Find(id);
            _context.WSREF.Remove(user);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost("Insert")]
        public IActionResult Insert(ReqWsref req)
        {
            var newWsREF = new WSREF()
            {
                Url = req.Url,
                Description = req.Description
            };
            _context.Add(newWsREF);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost("Update/{id}")]
        public IActionResult Update(int id, ReqWsref req)
        {
            var user = _context.WSREF.Find(id);
            user.Url = req.Url;
            user.Description = req.Description;
            _context.Update(user);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost("AddInc")]
        public IActionResult AddInc(int id)
        {
            var user = _context.WSREF.Find(id);
            user.Plus = ++user.Plus;
            _context.Update(user);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost("RemInc")]
        public IActionResult RemInc(int id)
        {
            var user = _context.WSREF.Find(id);
            user.Minus = ++user.Minus;
            _context.Update(user);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet("Comments/{idWsref}")]
        public IActionResult Comments(int idWsref)
        {
            var user = _context.WSREF.Find(idWsref);
            return PartialView("_Comments",user);
        }

        [HttpGet("CommentsInsert/{idWsref}")]
        public IActionResult CommentsInsert(int idWsref)
        {
            var user = _context.WSREF.Find(idWsref);
            return PartialView("_CommentsInsert",user);
        }

        [HttpPost("CommentsInsert/{idWsref}")]
        public IActionResult CommentsInsert(WSREFCOMMENT comment)
        {
            comment.Stamp = DateTime.UtcNow;
            var user = _context.WSREFComment.Add(comment);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost("CommentsUpdate")]
        public IActionResult CommentsUpdate(WSREFCOMMENT comment)
        {
            var commentd = _context.WSREFComment.Find(comment.Id);
            commentd.Stamp = DateTime.UtcNow;
            commentd.Comtext = comment.Comtext;
            _context.Update(commentd);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet("CommentsDelete")]
        public IActionResult CommentsDelete(int id)
        {
            var comment = _context.WSREFComment.Find(id);
            _context.Remove(comment);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet("CommentsGetFormDelete/{id}")]
        public IActionResult GetFormDeleteComment(int id)
        {
            var comment = _context.WSREFComment.Find(id);
            return PartialView("_CommentsGetFormDelete", comment);
        }

        [HttpGet("CommentsGetFormUpdate/{id}")]
        public IActionResult GetFormDeleteUpdate(int id)
        {
            var comment = _context.WSREFComment.Find(id);
            return PartialView("_CommentsGetFormUpdate", comment);
        }
    }
}
