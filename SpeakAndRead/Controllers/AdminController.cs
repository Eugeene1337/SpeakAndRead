using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SpeakAndRead.Data;
using SpeakAndRead.Models;

namespace SpeakAndRead.Controllers
{
    public class AdminController : Controller
    {
        ApplicationDbContext _context;
        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            var users = _context.Users.ToList();

            return View(users);
        }

        [Authorize(Roles = "Admin, Teacher")]
        public IActionResult CreateEnroll()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "UserName");
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseName");
            return View();
        }

        [Authorize(Roles = "Admin, Teacher")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateEnroll([Bind("UserId,CourseId")] CourseUser courseUser)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.CourseUsers.Add(courseUser);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(nameof(Index));
            }
            catch (DbUpdateException)
            {
                TempData["Error"] = "Duplicate enrollment";
                return RedirectToAction(nameof(CreateEnroll));
            }
        }
    }
}
