using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Npgsql;
using System.Configuration;
using tutorial.Models;
namespace tutorial.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register

        myClass obj = new myClass();
        public ActionResult register()
        {
            return View();
        }
        [HttpPost]
        public JsonResult insertData(string fullname,string username, string password)
        {
            Console.WriteLine("<script> console.log('Inside insertData');</script>");
            List<string> lst=new List<string>();
            using(NpgsqlConnection connection=new NpgsqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ToString();
                connection.Open();
                string query = "";
                query = "INSERT INTO employee (fullname,username,password) VALUES ('" + fullname.Trim().ToString() + "'," + " '" + username.Trim().ToString() + "'," + " '" + password.Trim().ToString() + "' )";
                NpgsqlCommand cmd = new NpgsqlCommand(query,connection);
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                lst.Add("Data Inserted.");


            }
            return Json(lst);
        }
    }
}