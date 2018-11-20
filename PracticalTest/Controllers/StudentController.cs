﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PracticalTest.Models;

namespace PracticalTest.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentCourseContext _context;

        public StudentController(StudentCourseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SaveStudent()
        {
            StudentModel smodel = new StudentModel
            {
                FirstName = HttpContext.Request.Form["Firstname"].ToString(),
                Surname = HttpContext.Request.Form["Surname"].ToString(),
                EmailAddress = HttpContext.Request.Form["EmailAddress"].ToString(),
                IDNumber = HttpContext.Request.Form["IDNumber"].ToString()
            };

            if (smodel.FirstName != null && smodel.Surname != null)
            {
                _context.Add(smodel);
                _context.SaveChanges();
            }
            else
            {
                return View("Index");
            }
            
            return View("Index");
        }
    }
}