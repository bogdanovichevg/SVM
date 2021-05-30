using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
            var user = _context.WSREFComment.Find(comment.Id);
            user.Stamp = DateTime.UtcNow;
            user.Comtext = comment.Comtext;
            _context.Update(user);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet("CommentsDelete")]
        public IActionResult CommentsDelete(int id)
        {
            var user = _context.WSREFComment.Find(id);
            _context.Remove(user);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
