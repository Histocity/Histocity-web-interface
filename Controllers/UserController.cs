using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Histocity_Website.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Http;
using System.Net.Mail;
using System.Net;
using RestSharp;
using System.Security.Claims;
using Synercoding.FormsAuthentication;
using Microsoft.AspNetCore.Authentication;

namespace Histocity_Website.Controllers
{
    public class UserController : Controller
    {
        MySqlConnection connection = new MySqlConnection(new DatabaseController().getConnectionString());

        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registration(string firstName, string lastName, string email, string password, string confirmPassword)
        {
            var user = new User();
            bool status = false;
            string message = "";

            //Check if email already exist
            var isExist = IsEmailExist(email);
            if(isExist)
            {
                ModelState.AddModelError("EmailExist", "Dit emailadres is al in gebruik");
                return View();
            }

            //User
            user.FirstName = firstName;
            user.LastName = lastName;
            user.EmailID = email;
            user.ActivationCode = Guid.NewGuid();
            user.Password = Crypto.Hash(password);
            user.ConfirmPassword = Crypto.Hash(confirmPassword);
            user.isEmailVerified = false;

            //Save to DB
            try
            {
                using (MySqlConnection connection = new MySqlConnection("Database=heroku_9a1fa21f73d10db;Data Source=eu-cdbr-west-03.cleardb.net;User Id=bcfe6ec0812a08;Password=0f9c4546; Pooling=false"))
                {
                    connection.Open();
                    MySqlCommand comm = connection.CreateCommand();

                    comm.CommandText = "INSERT INTO users(FirstName, LastName, EmailID, Password, IsEmailVerified, ActivationCode) VALUES(@Firstname, @Lastname, @EmailID, @Password, @IsEmailVerified, @ActivationCode)";
                    comm.Parameters.AddWithValue("@Firstname", user.FirstName);
                    comm.Parameters.AddWithValue("@Lastname", user.LastName);
                    comm.Parameters.AddWithValue("@EmailID", user.EmailID);
                    comm.Parameters.AddWithValue("@Password", user.Password);
                    comm.Parameters.AddWithValue("@IsEmailVerified", user.isEmailVerified);
                    comm.Parameters.AddWithValue("@ActivationCode", user.ActivationCode);
                    comm.ExecuteNonQuery();

                    connection.Close();

                    //Send Email
                    SendVerificationLinkEmail(email, user.ActivationCode.ToString());
                    message = "Registratie is geslaag. Er is een bevestigingsmail gestuurd naar: " + user.EmailID;
                    status = true;
                }
            }
            catch (Exception e)
            {
                message = "Er is iets misgegaan met de database connectie" + e;
            }


            ViewBag.Message = message;
            ViewBag.Status = status;
            return View();

        }

        [HttpGet]
        public ActionResult VerifyAccount(string id)
        {
            bool status = false;

            try
            {
                using (MySqlConnection connection = new MySqlConnection("Database=heroku_9a1fa21f73d10db;Data Source=eu-cdbr-west-03.cleardb.net;User Id=bcfe6ec0812a08;Password=0f9c4546; Pooling=false"))
                {
                    connection.Open();
                    MySqlCommand comm = connection.CreateCommand();

                    comm.CommandText = "UPDATE users SET IsEmailVerified = true WHERE ActivationCode = @ActivationCode";
                    comm.Parameters.AddWithValue("@ActivationCode", id);
                    comm.ExecuteNonQuery();

                    connection.Close();
                    status = true;
                }
            }
            catch (Exception e)
            {
                ViewBag.Message = "Er is iets misgegaan met de database connectie" + e;
            }

            ViewBag.Status = status;
            return RedirectToAction("Login", "User");
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            string message = "";

            try
            {
                using (MySqlConnection connection = new MySqlConnection("Database=heroku_9a1fa21f73d10db;Data Source=eu-cdbr-west-03.cleardb.net;User Id=bcfe6ec0812a08;Password=0f9c4546; Pooling=false"))
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "SELECT * FROM users WHERE EmailID = @email";
                    command.Parameters.AddWithValue("@email", email);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader["IsEmailVerified"].ToString() != "1")
                        {
                            ViewBag.Message = "Dit account is nog niet bevestigd";
                            return View();
                        }
                            if (string.Compare(Crypto.Hash(password), reader["password"].ToString()) == 0)
                            {
                            HttpContext.Session.SetString("userID", reader["UserID"].ToString());
                            reader.Close();
                            connection.Close();
                            return RedirectToAction("List", "Question");                  
                        } 
                            else
                            {
                            reader.Close();
                            connection.Close();
                            message = "Uw gebruikersnaam en/of wachtwoord is niet juist. Probeer opnieuw.";
                            ViewBag.Message = message;
                            return View();
                        }
                        
                    }
                }
            }
            catch (Exception e)
            {
                connection.Close();
                message = e.ToString();
                ViewBag.Message = message;
                return View();

            }
            ViewBag.Message = message;
            return View();
        }
        [HttpGet]
        public ActionResult Logout()
        {
            HttpContext.Session.Remove("userID");
            return RedirectToAction("Login", "User");
        }

        [NonAction]
        public bool IsEmailExist(string email)
        {
            bool emailExist;
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT EmailID From Users WHERE EmailID = @email; ";
            command.Parameters.AddWithValue("@email", email);

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                emailExist = true;
            } 
            else
            {
                emailExist = false;
            }                
            reader.Close();
            connection.Close();

            return emailExist;
        }

        [NonAction]
        public void SendVerificationLinkEmail(string email, string activationCode)
        {

            var UriBuilder = new UriBuilder
            {
                Scheme = Request.Scheme,
                Host = "localhost:44374",
                Path = $"/user/verifyaccount/{activationCode}"
            };

            var link = UriBuilder.ToString().Replace("[", "").Replace("]","");

            var fromEmail = new MailAddress("praktijkopdracht.histocity@gmail.com", "Histocity");
            var toEmail = new MailAddress(email);
            var fromEmailPassword = "Unity2020";
            string subject = "Je Histocity-account is succesvol aangemaakt";

            string body = "<br/><br/>Uw Histocity docenten-account is succesvol aangemaakt. <br>" +
            "Klik op onderstaande link om uw account te bevestigen:" +
            " <br/><br/><a href='" + link + "'>" + link + "</a> ";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromEmail.Address, fromEmailPassword)
            };

            using (var message = new MailMessage(fromEmail, toEmail)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            })
                smtp.Send(message);
        }
    }
}
