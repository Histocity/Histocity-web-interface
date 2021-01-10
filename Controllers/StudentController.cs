using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Histocity_Website.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace Histocity_Website.Controllers
{
    public class StudentController : Controller
    {
        MySqlConnection connection = new MySqlConnection(new DatabaseController().getConnectionString());
        public IActionResult List()
        {
            IEnumerable<Student> studentList;
            if (HttpContext.Session.GetString("userID") == null)
            {
                ViewBag.IsLoggedIn = false;
                return RedirectToAction("Login", "User");
            }
            else
            {
                ViewBag.IsLoggedIn = true;
                ViewBag.TeacherID = HttpContext.Session.GetString("userID");

                try
                {
                    using (WebClient wc = new WebClient())
                    {
                        var json = wc.DownloadString("https://histocity.herokuapp.com/api/player/all");

                        studentList = (List<Student>)JsonConvert.DeserializeObject(json, typeof(List<Student>));

                    }
                }
                catch (Exception e)
                {
                    studentList = Enumerable.Empty<Student>();
                    ModelState.AddModelError(string.Empty, e.ToString());
                }
                return View(studentList);
            }
            
        }

        [HttpGet]
        public ActionResult Add(string teacherID)
        {
            ViewBag.Teacher = teacherID;
            return View();
        }

        [HttpPost]
        public IActionResult Add(string teacherID, string firstName, string lastName, string userName, string password, string confirmPassword)
        {
            //Check if userName already exist
            var isExist = IsUserNameExist(userName);
            if (isExist)
            {
                ViewBag.ErrorMessage = "Deze gebruikersnaam is al in gebruik. Kies een andere gebruikersnaam.";
                ViewBag.Teacher = teacherID;
                return View();
            }

            //Save to DB
            try
            {
                using (MySqlConnection connection = new MySqlConnection("Database=heroku_9a1fa21f73d10db;Data Source=eu-cdbr-west-03.cleardb.net;User Id=bcfe6ec0812a08;Password=0f9c4546; Pooling=false"))
                {
                    connection.Open();
                    MySqlCommand comm = connection.CreateCommand();

                    comm.CommandText = "INSERT INTO students(FirstName, LastName, Username, Password, TeacherID) VALUES(@Firstname, @Lastname, @Username, @Password, @TeacherID)";
                    comm.Parameters.AddWithValue("@Firstname", firstName);
                    comm.Parameters.AddWithValue("@Lastname", lastName);
                    comm.Parameters.AddWithValue("@UserName", userName);
                    comm.Parameters.AddWithValue("@Password", Crypto.Hash(password));
                    comm.Parameters.AddWithValue("@TeacherID", teacherID);
                    comm.ExecuteNonQuery();

                    connection.Close();

                    ViewBag.SuccessMessage = "Account is aangemaakt. Je kunt nu inloggen in het spel.";
                }
            }
            catch (Exception e)
            {
                ViewBag.ErrorMessage = "Er is iets misgegaan met de database connectie" + e;
            }
            return View();

        }

        [NonAction]
        public bool IsUserNameExist(string userName)
        {
            bool userNameExist;
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT UserName From students WHERE UserName = @userName; ";
            command.Parameters.AddWithValue("@userName", userName);

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                userNameExist = true;
            }
            else
            {
                userNameExist = false;
            }
            reader.Close();
            connection.Close();

            return userNameExist;
        }
    }
}
