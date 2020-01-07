using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcBasics.Models;

namespace MvcBasics.Controllers
{
    public class TeamMembersController : Controller
    {
        public static List<TeamMember> team = new List<TeamMember>();

        public IActionResult Index()
        {
            ViewData["title"] = "Team members list";
            if(team.Count == 0)
            {
                team.Add(new TeamMember { Email = "ivan@abv.bg", FirstName = "Ivan", LastName = "Ivanov" });
                team.Add(new TeamMember { Email = "gosho@abv.bg", FirstName = "Georgi", LastName = "Petrov" });
            }
            return View(team);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewData["Title"] = "Add team member";
            return View();
        }

        [HttpPost]
        public IActionResult Create(TeamMember created)
        {
            if (!ModelState.IsValid)
            {
                return View(created);
            }

            team.Add(created);
            return RedirectToAction("Index");
        }
    }
}