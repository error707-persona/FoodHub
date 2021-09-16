using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace WebApplication1.Controllers
{
    public class RegisterationController : Controller
    {
        // GET: Registeration
        [HttpGet]
        public ActionResult Registeration()
        {
            Registeration res = new Registeration();

             
            return View(res);
        }
        [HttpPost]
        public ActionResult Registeration(Registeration info)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-NLL40U8;Integrated Security=True; Initial Catalog=ASP");

            con.Open();
            string comstr = "Insert into ACCOUNT(email, pass) values('" + info.email + "','" + info.pass + "')";
            SqlCommand com = new SqlCommand(comstr, con);
            int a = com.ExecuteNonQuery();
            con.Close();
            if (a == 0)
            {
                ViewBag.SuccessMessage = "Something went wrong please try again";
            }
            else
            {
                ViewBag.SuccessMessage = "Registered Succesfully";
            }
            return View();
        }
    }
}