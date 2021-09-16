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
    public class OrderFinalController : Controller
    {
        // GET: OrderFinal
        [HttpGet]
        public ActionResult OrderFinal(string id)
        {   
            
            
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-NLL40U8;Integrated Security=True; Initial Catalog=ASP");

            con.Open();
            string comstr = "Select * from food where Foodname='" + id + "'";
            SqlCommand com = new SqlCommand(comstr, con);
            SqlDataReader dr = com.ExecuteReader();
            
            List<OrderFinal> o = new List<OrderFinal>();
            while (dr.Read())
            {
                o.Add(new OrderFinal
                {
                    Image = dr["Image"].ToString(),
                    Foodname = dr["Foodname"].ToString(),
                    Description = dr["Description"].ToString(),
                    Price = dr["Price"].ToString(),
                    Brandname = dr["Brandname"].ToString(),
                    date = dr["Dateadded"].ToString()

                });
            }
            con.Close();
            return View(o);
        }
    }
}