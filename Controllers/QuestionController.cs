using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Histocity_Website.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using Histocity_Website.Controllers;
using System;

namespace Histocity_Website.Controllers
{
    public class QuestionController : Controller
    { 
        MySqlConnection connection = new MySqlConnection("Database=heroku_9a1fa21f73d10db;Data Source=eu-cdbr-west-03.cleardb.net;User Id=bcfe6ec0812a08;Password=0f9c4546");

        public IActionResult List()
        {
            var model = new List<Question>();

            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT  Questions.QuestionID, Questions.QuestionText, Questions.GoodAnswer, Questions.WrongAnswer1, Questions.WrongAnswer2, Questions.Created, Questions.Difficulty, Questions.ActiveInGame, Eras.EraName From Questions INNER JOIN Eras on Questions.EraID = Eras.EraID; ";
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var question = new Question();
                    question.QuestionID = reader["QuestionID"].ToString();
                    question.QuestionText = reader["QuestionText"].ToString();
                    question.GoodAnswer = reader["GoodAnswer"].ToString();
                    question.WrongAnswer1 = reader["WrongAnswer1"].ToString();
                    question.WrongAnswer2 = reader["WrongAnswer2"].ToString();
                    question.CreatedAt = reader["Created"].ToString();
                    question.EraName = reader["EraName"].ToString();
                    question.Difficulty = reader["Difficulty"].ToString();
                    question.ActiveInGame = reader["ActiveInGame"].ToString() == "True" ? "Ja" : "Nee";
                    
                     model.Add(question);
                }
                reader.Close();
                
            }
            catch (Exception e)
            {
                TempData["Error"] = "Er is iets misgegaan, probeer het opnieuw";
               
            }
            return View(model);
        }

         public IActionResult Create()
        {
            var eraCtrl = new EraController();
            ViewBag.Era = eraCtrl.GetListItemsOfEra();

            return View();
        }

        [HttpPost]
        public IActionResult Create(string eraID, int difficulty, string questionText, string goodAnswerText, string badAnswerText1, string badAnswerText2, string questionActive)
        {
            try
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
            catch(Exception e)
            {
                TempData["Error"] = "Er is iets misgegaan, probeer het opnieuw";
            }

            return RedirectToAction("Create", "Question");
        }

        [HttpPost]
        public ActionResult Delete(String QuestionID)
        {
            try
            {
                connection.Open();
                MySqlCommand comm = connection.CreateCommand();

                comm.CommandText = "DELETE FROM Questions WHERE QuestionID = @QuestionID; ";
                comm.Parameters.AddWithValue("@QuestionID", QuestionID);
                comm.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception e)
            {
                TempData["ErrorDelete"] = "Er is iets misgegaan, probeer het later opnieuw";
            }

            return RedirectToAction("List", "Question");
        }

    }
}
