using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MySql.Data.MySqlClient;

namespace Histocity_Website.Controllers
{
    public class EraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public List<SelectListItem> GetListItemsOfEra()
        {
            using (MySqlConnection connection = new MySqlConnection("Database=heroku_9a1fa21f73d10db;Data Source=eu-cdbr-west-03.cleardb.net;User Id=bcfe6ec0812a08;Password=0f9c4546; Pooling=false"))
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "select * from eras";
                MySqlDataReader reader = command.ExecuteReader();

                List<SelectListItem> listItems = new List<SelectListItem>();

                while (reader.Read())
                {
                    listItems.Add(new SelectListItem
                    {
                        Text = reader["EraID"].ToString(),
                        Value = reader["EraName"].ToString(),
                    });
                }
                reader.Close(); ;
                command.Dispose();
                connection.Close();

                return listItems;
            }
        }
    }
}
