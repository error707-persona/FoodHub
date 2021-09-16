using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using WebApplication1.Models;
using MySql.Data.MySqlClient;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Food
        [HttpGet]
        public ActionResult Login()
        {
            Login food = new Login();
            return View(food);
   
        }
        [HttpPost]
        public ActionResult Login(Login info)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-NLL40U8;Integrated Security=True; Initial Catalog=ASP");

            con.Open();
            string comstr = "Select * from ACCOUNT where email='"+info.email+"' and pass='"+info.pass+"'";
            SqlCommand com = new SqlCommand(comstr, con);
            int a = com.ExecuteNonQuery();
            
            if (a == 0)
            {
                ViewBag.SuccessMessage = "Invalid Email or password";
            }
            else
            {
                ViewBag.SuccessMessage = "Login Succesfully";
            }
            con.Close();
            
            return View("Login", new Login());
        }
    }
}