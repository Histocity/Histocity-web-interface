using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MySql.Data.MySqlClient;
using Histocity_Website.Models;

namespace Histocity_Website.Controllers
{
    public class CategoryController : Controller
    {
        MySqlConnection connection = new MySqlConnection("Database=heroku_9a1fa21f73d10db;Data Source=eu-cdbr-west-03.cleardb.net;User Id=bcfe6ec0812a08;Password=0f9c4546");

        public IActionResult Category()
        {
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from category";
            MySqlDataReader reader = command.ExecuteReader();

            var model = new List<Category>();

            while (reader.Read())
            {
                var category = new Category();
                category.CategoryDescription = reader["CategoryDescription"].ToString();
                category.CategoryDifficulty = reader["CategoryDifficulty"].ToString();

                model.Add(category);
            }
            reader.Close();

            var categoryCtrl = new CategoryController();
            ViewBag.Categories = categoryCtrl.GetListItemsOfCategory();

            var eraCtrl = new EraController();
            ViewBag.Era = eraCtrl.GetListItemsOfEra();

            return View(model);
        }


        public List<SelectListItem> GetListItemsOfCategory()
        {
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from category";
            MySqlDataReader reader = command.ExecuteReader();

            List<SelectListItem> listItems = new List<SelectListItem>();

            while (reader.Read())
            {
                listItems.Add(new SelectListItem
                {
                Text = reader["CategoryID"].ToString(),
                Value = reader["CategoryDescription"].ToString(),
                });
            }
            reader.Close(); ;

            return listItems;
        }
        
    }
}
