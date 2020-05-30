using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GANDO.Controllers
{
    public class Class : Controller
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //lblErrorMessage.Visible = false;
        }

        protected void Button1(object sender, EventArgs e)
        {



            using (SqlConnection sqlCon = new SqlConnection("Server= localhost; Database= Dele_default; Integrated Security=True;"))
            {
                sqlCon.Open();
                string Login = "Select Count(1) from Micro Where username=@username And password=@password";
                SqlCommand sqlcmd = new SqlCommand(Login, sqlCon);
                sqlcmd.Parameters.AddWithValue("@Username", TextBox1.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@Password", pwd.Text.Trim());
                int count = Convert.ToInt32(sqlcmd.ExecuteScalar());
                if (count == 1)
                {
                    Response.Redirect("Privacy.cshtml");
                }

                else
                {
                    Response.Redirect("Password Don't match!");
                }
            }


        }
        protected void Button7_Click(object sender, EventArgs e)
        {
            var NPage = "RegistrationPage.aspx";

            if (NPage == "RegistrationPage.aspx")
            {
                Response.Redirect("RegistrationPage.aspx");
            }

            else
            {
                Response.Redirect("Page Down!");
            }
        }
    }
}