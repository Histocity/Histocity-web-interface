﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Histocity_Website.Models;
using Microsoft.Extensions.Configuration;

namespace Histocity_Website.Controllers
{
    public class QuestionController : Controller
    { 
        MySqlConnection connection = new MySqlConnection("Database=heroku_9a1fa21f73d10db;Data Source=eu-cdbr-west-03.cleardb.net;User Id=bcfe6ec0812a08;Password=0f9c4546");

        public IActionResult Question()
        {
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from questions";
            MySqlDataReader reader = command.ExecuteReader();

            var model = new List<Question>();

            while (reader.Read())
            {
                var question = new Question();
                question.QuestionText = reader["QuestionText"].ToString();
                question.GoodAnswer = reader["GoodAnswer"].ToString();
                question.WrongAnswer1 = reader["WrongAnswer1"].ToString();
                question.WrongAnswer2 = reader["WrongAnswer2"].ToString();
                question.CreatedAt = reader["Created"].ToString();

                model.Add(question);
            }
            reader.Close();

            return View(model);
        }

        [HttpPost]
        public IActionResult Question(string questionText, string goodAnswerText, string badAnswerText1, string badAnswerText2)
        {
            // add question to db
            connection.Open();
            MySqlCommand comm = connection.CreateCommand();
            comm.CommandText = "INSERT INTO questions(QuestionText, GoodAnswer, WrongAnswer1, WrongAnswer2) VALUES(@questionText, @GoodAnswer, @WrongAnswer1, @WrongAnswer2 )";
            comm.Parameters.AddWithValue("@questionText", questionText);
            comm.Parameters.AddWithValue("@GoodAnswer", goodAnswerText);
            comm.Parameters.AddWithValue("@WrongAnswer1", badAnswerText1);
            comm.Parameters.AddWithValue("@WrongAnswer2", badAnswerText2);
            comm.ExecuteNonQuery();

            connection.Close();


            return Question();
        }
    }
}