using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Histocity_Website.Models;

namespace Histocity_Website.Controllers
{
    public class CouplingController : Controller
    {
        MySqlConnection connection = new MySqlConnection("Database=heroku_9a1fa21f73d10db;Data Source=eu-cdbr-west-03.cleardb.net;User Id=bcfe6ec0812a08;Password=0f9c4546");

        public IActionResult Coupling()
        {
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from category_era";
            MySqlDataReader reader = command.ExecuteReader();

            var model = new List<Coupling>();

            while (reader.Read())
            {
                var coupling = new Coupling();
                coupling.CategoryID = reader["CategoryID"].ToString();
                coupling.EraID = reader["EraID"].ToString();

                model.Add(coupling);
            }
            reader.Close();

            var categoryCtrl = new CategoryController();
            ViewBag.Categories = categoryCtrl.GetListItemsOfCategory();

            var eraCtrl = new EraController();
            ViewBag.Era = eraCtrl.GetListItemsOfEra();

            return View(model);
        }
        
        [HttpPost]
        public IActionResult Coupling(string CategoryID, string EraID)
        {
            // add question to db
            connection.Open();
            MySqlCommand comm = connection.CreateCommand();
            comm.CommandText = "INSERT INTO category_era(CategoryID, EraID) VALUES(@Category, @Era)";
            comm.Parameters.AddWithValue("@Category", CategoryID);
            comm.Parameters.AddWithValue("@Era", EraID);
            comm.ExecuteNonQuery();

            connection.Close();

            return Coupling();
        }
    }
}
