using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Data.Repositories;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class StudentsController : Controller
    {
        private readonly StudentRepository studentRepository;
        private readonly CourseRepository courseRepository;

        public StudentsController(StudentRepository studentRepository, CourseRepository courseRepository)
        {
            this.studentRepository = studentRepository;
            this.courseRepository = courseRepository;
        }

        // GET: Students
        public async Task<IActionResult> Index()
        {
            return View(await studentRepository.GetAllAsync());
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await studentRepository.GetAsync((int)id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            // var courses = _context.Courses
            //     .Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Name })
            //     .ToList();
            // ViewData["allCourses"] = courses;
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Age,Email,CourseId")] Student student)
        {
            if (ModelState.IsValid)
            {
                await this.studentRepository.AddAsync(student);
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await this.studentRepository.GetAsync((int)id);
            if (student == null)
            {
                return NotFound();
            }

            // var courses = _context.Courses
            //     .Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Name })
            //     .ToList();
            // ViewData["allCourses"] = courses;
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Age,Email,CourseId")] Student student)
        {
            if (id != student.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await this.studentRepository.UpdateAsync(student);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.Id))
                    {
                        //ModelState.AddModelError("Id", "Student with this id was not found");
                        ViewData["error"] = $"Student with id {id} was not found in the DB";
                        return View(student);
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await this.studentRepository.GetAsync((int)id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await this.studentRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(int id)
        {
            // return _context.Students.Any(e => e.Id == id);
            return true;
        }
    }
}
