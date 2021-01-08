using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Histocity_Website.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using Histocity_Website.Controllers;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace Histocity_Website.Controllers
{
    public class QuestionController : Controller
    {
        IEnumerable<Question> questionList;

        public IActionResult List()
        {
            if (HttpContext.Session.GetString("userID") == null)
            {
                ViewBag.IsLoggedIn = false;
                return RedirectToAction("Login", "User");
            }
            else
            {
                ViewBag.IsLoggedIn = true;
                try
                {
                    using (WebClient wc = new WebClient())
                    {
                        var json = wc.DownloadString("https://histocity.herokuapp.com/api/question/all");

                        questionList = (List<Question>)JsonConvert.DeserializeObject(json, typeof(List<Question>));

                    }
                }
                catch (Exception e)
                {
                    questionList = Enumerable.Empty<Question>();
                    ModelState.AddModelError(string.Empty, e.ToString());
                }
                return View(questionList);
            }
        }

         public IActionResult Create()
        {
            if (HttpContext.Session.GetString("userID") == null)
            {
                ViewBag.IsLoggedIn = false;
                return RedirectToAction("Login", "User");
            }
            else
            {
                ViewBag.IsLoggedIn = true;
                var eraCtrl = new EraController();
                ViewBag.Era = eraCtrl.GetListItemsOfEra();

                return View();
            }
        }

        [HttpPost]
        public IActionResult Create(string eraID, int difficulty, string questionText, string goodAnswerText, string badAnswerText1, string badAnswerText2, string questionActive)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection("Database=heroku_9a1fa21f73d10db;Data Source=eu-cdbr-west-03.cleardb.net;User Id=bcfe6ec0812a08;Password=0f9c4546; Pooling=false"))
                {
                    connection.Open();
                    MySqlCommand comm = connection.CreateCommand();

                    comm.CommandText = "INSERT INTO questions(QuestionText, GoodAnswer, WrongAnswer1, WrongAnswer2, EraID, ActiveInGame, Difficulty) VALUES(@QuestionText, @GoodAnswer, @WrongAnswer1, @WrongAnswer2, @Era, @ActiveInGame, @Difficulty)";
                    comm.Parameters.AddWithValue("@QuestionText", questionText);
                    comm.Parameters.AddWithValue("@GoodAnswer", goodAnswerText);
                    comm.Parameters.AddWithValue("@WrongAnswer1", badAnswerText1);
                    comm.Parameters.AddWithValue("@WrongAnswer2", badAnswerText2);
                    comm.Parameters.AddWithValue("@Era", eraID);
                    comm.Parameters.AddWithValue("@ActiveInGame", questionActive != null ? true : false);
                    comm.Parameters.AddWithValue("@difficulty", difficulty);
                    comm.ExecuteNonQuery();

                    connection.Close();
                    TempData["Success"] = "De vraag is opgeslagen";
                }
            }
            catch(Exception e)
            {
                TempData["Error"] = "Er is iets misgegaan, probeer het opnieuw";
            }

            return RedirectToAction("Create", "Question");
        }

        [HttpGet]
        public IActionResult Edit(string id)
        {
            if (HttpContext.Session.GetString("userID") == null)
            {
                ViewBag.IsLoggedIn = false;
                return RedirectToAction("Login", "User");
            }
            else
            {
                ViewBag.IsLoggedIn = true;
                Question question;

                try
                {
                    using (WebClient wc = new WebClient())
                    {
                        var json = wc.DownloadString("https://histocity.herokuapp.com/api/question/get/" + id);

                        question = (Question)JsonConvert.DeserializeObject(json, typeof(Question));

                    }

                    var eraCtrl = new EraController();
                    var eraList = eraCtrl.GetListItemsOfEra();
                    var idSelectedEra = eraList.Where(x => x.Value == question.eraName).First().Text;

                    question.eraID = idSelectedEra;
                    ViewBag.Era = eraList;
                }
                catch (Exception e)
                {
                    question = null;
                    ModelState.AddModelError(string.Empty, e.ToString());
                }

                return View(question);
            }
        }


        [HttpPost]
        public IActionResult Edit(string eraID, int difficulty, string questionText, string goodAnswerText, string badAnswerText1, string badAnswerText2, string questionActive, string questionID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection("Database=heroku_9a1fa21f73d10db;Data Source=eu-cdbr-west-03.cleardb.net;User Id=bcfe6ec0812a08;Password=0f9c4546; Pooling=false"))
                {
                    connection.Open();
                    MySqlCommand comm = connection.CreateCommand();

                    comm.CommandText = "UPDATE questions SET QuestionText = @QuestionText, GoodAnswer = @GoodAnswer, WrongAnswer1 = @WrongAnswer1, WrongAnswer2 = @WrongAnswer2, EraID = @Era, ActiveInGame = @ActiveInGame, Difficulty = @Difficulty WHERE QuestionID = @QuestionID ";
                    comm.Parameters.AddWithValue("@QuestionText", questionText);
                    comm.Parameters.AddWithValue("@GoodAnswer", goodAnswerText);
                    comm.Parameters.AddWithValue("@WrongAnswer1", badAnswerText1);
                    comm.Parameters.AddWithValue("@WrongAnswer2", badAnswerText2);
                    comm.Parameters.AddWithValue("@Era", eraID);
                    comm.Parameters.AddWithValue("@ActiveInGame", questionActive != null ? true : false);
                    comm.Parameters.AddWithValue("@Difficulty", difficulty);
                    comm.Parameters.AddWithValue("@QuestionID", questionID);
                    comm.ExecuteNonQuery();

                    comm.Dispose();
                    connection.Close();
                    TempData["Success"] = "De vraag is opgeslagen";
                }
            }
            catch (Exception e)
            {
                TempData["Error"] = "Er is iets misgegaan, probeer het opnieuw";
            }

            return RedirectToAction("List", "Question");
        }
    }
}
