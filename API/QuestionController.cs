using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Histocity_Website.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using MySql.Data.MySqlClient;
using Histocity_Website.Controllers;

namespace Histocity_Website.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        MySqlConnection connection = new MySqlConnection(new DatabaseController().getConnectionString());

        [HttpGet("all")]
        public ActionResult<List<Question>> GetAll()
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
                throw e;

            }
            return model;
        }

        [HttpGet("active")]
        public ActionResult<List<Question>> GetActive()
        {

            var model = new List<Question>();

            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT  Questions.QuestionID, Questions.QuestionText, Questions.GoodAnswer, Questions.WrongAnswer1, Questions.WrongAnswer2, Questions.Created, Questions.Difficulty, Questions.ActiveInGame, Eras.EraName From Questions INNER JOIN Eras on Questions.EraID = Eras.EraID WHERE Questions.ActiveInGame = 1; ";
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
                throw e;

            }
            return model;
        }

        [HttpGet("active/{tijdperk}")]
        public ActionResult<List<Question>> GetActive(string tijdperk)
        {

            var model = new List<Question>();

            try
            {
                string decodedTijdperk = HttpUtility.UrlDecode(tijdperk);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT  Questions.QuestionID, Questions.QuestionText, Questions.GoodAnswer, Questions.WrongAnswer1, Questions.WrongAnswer2, Questions.Created, Questions.Difficulty, Questions.ActiveInGame, Eras.EraName From Questions INNER JOIN Eras on Questions.EraID = Eras.EraID WHERE Eras.EraName = '" + decodedTijdperk + "' AND Questions.ActiveInGame = 1;";
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
                throw e;

            }
            return model;
        }
    }
}
