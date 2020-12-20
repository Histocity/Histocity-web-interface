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
using System.Web.Http.Cors;

namespace Histocity_Website.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        MySqlConnection connection = new MySqlConnection(new DatabaseController().getConnectionString());

        [EnableCors(origins: "https://histocity.herokuapp.com/", headers: "*", methods: "*")]
        [HttpGet("all")]
        public ActionResult<List<Question>> GetAll()
        {

            var model = new Questions();
            model.questions = new List<Question>();
            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT  Questions.QuestionID, Questions.QuestionText, Questions.GoodAnswer, Questions.WrongAnswer1, Questions.WrongAnswer2, Questions.Created, Questions.Difficulty, Questions.ActiveInGame, Eras.EraName From Questions INNER JOIN Eras on Questions.EraID = Eras.EraID; ";
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var question = new Question();
                    question.questionID = reader["QuestionID"].ToString();
                    question.questionText = reader["QuestionText"].ToString();
                    question.goodAnswer = reader["GoodAnswer"].ToString();
                    question.wrongAnswer1 = reader["WrongAnswer1"].ToString();
                    question.wrongAnswer2 = reader["WrongAnswer2"].ToString();
                    question.createdAt = reader["Created"].ToString();
                    question.eraName = reader["EraName"].ToString();
                    question.difficulty = reader["Difficulty"].ToString();
                    question.activeInGame = reader["ActiveInGame"].ToString() == "True" ? "Ja" : "Nee";

                    model.questions.Add(question);
                }
                reader.Close();

            }
            catch (Exception e)
            {
                throw e;

            }
            return model.questions;
        }

        [HttpGet("get/{id}")]
        public ActionResult<Question> GetQuestionByID(string id)
        {

            var question = new Question();
            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT  Questions.QuestionID, Questions.QuestionText, Questions.GoodAnswer, Questions.WrongAnswer1, Questions.WrongAnswer2, Questions.Created, Questions.Difficulty, Questions.ActiveInGame, Eras.EraName From Questions INNER JOIN Eras on Questions.EraID = Eras.EraID WHERE Questions.QuestionID = @id; ";
                command.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    question.questionID = reader["QuestionID"].ToString();
                    question.questionText = reader["QuestionText"].ToString();
                    question.goodAnswer = reader["GoodAnswer"].ToString();
                    question.wrongAnswer1 = reader["WrongAnswer1"].ToString();
                    question.wrongAnswer2 = reader["WrongAnswer2"].ToString();
                    question.createdAt = reader["Created"].ToString();
                    question.eraName = reader["EraName"].ToString();
                    question.difficulty = reader["Difficulty"].ToString();
                    question.activeInGame = reader["ActiveInGame"].ToString() == "True" ? "Ja" : "Nee";
                }
                reader.Close();

            }
            catch (Exception e)
            {
                throw e;

            }
            return question;
        }

        [HttpGet("active")]
        public ActionResult<List<Question>> GetActive()
        {

            var model = new Questions();
            model.questions = new List<Question>();

            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT  Questions.QuestionID, Questions.QuestionText, Questions.GoodAnswer, Questions.WrongAnswer1, Questions.WrongAnswer2, Questions.Created, Questions.Difficulty, Questions.ActiveInGame, Eras.EraName From Questions INNER JOIN Eras on Questions.EraID = Eras.EraID WHERE Questions.ActiveInGame = 1; ";
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var question = new Question();
                    question.questionID = reader["QuestionID"].ToString();
                    question.questionText = reader["QuestionText"].ToString();
                    question.goodAnswer = reader["GoodAnswer"].ToString();
                    question.wrongAnswer1 = reader["WrongAnswer1"].ToString();
                    question.wrongAnswer2 = reader["WrongAnswer2"].ToString();
                    question.createdAt = reader["Created"].ToString();
                    question.eraName = reader["EraName"].ToString();
                    question.difficulty = reader["Difficulty"].ToString();
                    question.activeInGame = reader["ActiveInGame"].ToString() == "True" ? "Ja" : "Nee";

                    model.questions.Add(question);
                }
                reader.Close();

            }
            catch (Exception e)
            {
                throw e;

            }
            return model.questions;
        }

        [HttpGet("active/{tijdperk}")]
        public ActionResult<List<Question>> GetActive(string tijdperk)
        {

            var model = new Questions();
            model.questions = new List<Question>();

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
                    question.questionID = reader["QuestionID"].ToString();
                    question.questionText = reader["QuestionText"].ToString();
                    question.goodAnswer = reader["GoodAnswer"].ToString();
                    question.wrongAnswer1 = reader["WrongAnswer1"].ToString();
                    question.wrongAnswer2 = reader["WrongAnswer2"].ToString();
                    question.createdAt = reader["Created"].ToString();
                    question.eraName = reader["EraName"].ToString();
                    question.difficulty = reader["Difficulty"].ToString();
                    question.activeInGame = reader["ActiveInGame"].ToString() == "True" ? "Ja" : "Nee";

                    model.questions.Add(question);
                }
                reader.Close();

            }
            catch (Exception e)
            {
                throw e;

            }
            return model.questions;
        }

        [HttpGet("delete/id")]
        public ActionResult Delete(string id)
        {
            try
            {
                connection.Open();
                MySqlCommand comm = connection.CreateCommand();

                comm.CommandText = "DELETE FROM Questions WHERE QuestionID = @QuestionID; ";
                comm.Parameters.AddWithValue("@QuestionID", id);
                comm.ExecuteNonQuery();

                connection.Close();
            } catch (Exception e)
            {
                throw e;
            }
            return RedirectToAction("List");
        }
    }
}
