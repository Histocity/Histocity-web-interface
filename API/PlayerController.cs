using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Histocity_Website.Controllers;
using Histocity_Website.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace Histocity_Website.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        MySqlConnection connection = new MySqlConnection(new DatabaseController().getConnectionString());

        [HttpGet("all")]
        public ActionResult<List<Student>> GetAll()
        {

            var model = new List<Student>();
            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT FirstName, LastName, Username FROM students;";
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var student = new Student();
                    student.FirstName = reader["FirstName"].ToString();
                    student.LastName = reader["LastName"].ToString();
                    student.UserName = reader["Username"].ToString();

                    model.Add(student);
                }
                reader.Close();
                connection.Close();

            }
            catch (Exception e)
            {
                throw e;

            }
            Response.Headers.Add("Access-Control-Allow-Origin", "https://histocity.herokuapp.com/");
            return model;
        }

        public ActionResult<string> Login(string username, string password)
        {
            string result = "";
            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM students WHERE Username = @username";
                command.Parameters.AddWithValue("@username", username);
                MySqlDataReader reader = command.ExecuteReader();
                var hashedPassword = Crypto.Hash(password);

                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (string.Compare(hashedPassword, reader["password"].ToString()) == 0)
                        {
                            result = reader["StudentID"].ToString();
                        }
                        else
                        {
                            result = "WRONG PASSWORD";
                        }
                    }
                } else
                {
                    result = "WRONG USERNAME";
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
    }
}
