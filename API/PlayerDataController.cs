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
    public class PlayerDataController : ControllerBase
    {
        MySqlConnection connection = new MySqlConnection(new DatabaseController().getConnectionString());

        [HttpGet("get/histocity/{userId}")]
        public ActionResult<string> GetHistocity(string userId)
        {
            string result = "";
            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT Histocity FROM students WHERE StudentID = " + userId + ";";
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    result = reader["Histocity"].ToString();
                }
                reader.Close();
                connection.Close();

            }
            catch (Exception error)
            {
                throw error;

            }
            Response.Headers.Add("Access-Control-Allow-Origin", "https://histocity.herokuapp.com/");
            return result;
        }

        [HttpPost("post/histocity/{userId}")]
        public string PostHistocity(int userId, [FromBody] string histocity)
        {
            int rowsAffected = 0;
            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "UPDATE students SET Histocity = \'" + histocity + "\' WHERE StudentID = " + userId;
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception error)
            {
                throw error;
            }
            
            // TODO make return type (HttpResult class) -> return OK when 1 row affected, return Error if 0 rows affected and if 2 or more rows affected
            return "{\"rowsAffected: \" : " + rowsAffected + "}"; 
        }


    }
}
