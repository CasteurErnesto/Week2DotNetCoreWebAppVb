using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyHowest;
namespace DotNetCoreWebAppVb.Controllers
{
    public class HomeController : Controller
    {
        private string[] groenten = { "Rode kool", "Spruitjes", "Wortel", "Spinazie" };

        public ViewResult Index(string name)
        {
            ViewBag.Groet = DateTime.Now.Hour < 12 ? "Goedemorgen" : "GoedeMiddag";
            return View();
        }

        public ViewResult Groenten(string zoekGroente)
        {
            ViewBag.Groenten = groenten;
            if (!string.IsNullOrEmpty(zoekGroente))
            {
                ViewBag.Zoekresultaat = $"de gezochte groente is {Array.IndexOf(groenten, zoekGroente) + 1}e uit de lijst ";

            }
            return View();
        }
        public ViewResult Student()
        {
            List<Student> studenten = new List<Student>
            {
                new Student {Id=23,Naam="Jefke", AfstudeerGraad = Graad.Onderscheiding },
                new Student {Id=24 , Naam="Ernesto" , AfstudeerGraad = Graad.Voldoening},
            };
            ViewBag.Studenten = studenten;
            return View();
        }
    }
}