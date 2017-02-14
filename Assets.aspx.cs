using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Assets : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {





            //DropDownList1.Items.Add(new ListItem("--Select Employee--", ""));
            //DropDownList1.AppendDataBoundItems = true;
            //String strConnString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            //String strQuery = "select assetID from assets";
            //SqlConnection con = new SqlConnection(strConnString);
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = strQuery;
            //cmd.Connection = con;
            //try
            //{
            //    con.Open();
            //    //  DropDownList1.DataSource = cmd.ExecuteReader();
            //    // DropDownList1.DataTextField = "employeeID";
            //    // DropDownList1.DataValueField = "assetID";

            //    TextBox3.Text = 
            //    DropDownList1.DataBind();
            //}
            //catch (Exception ex)
            //{
            //    // throw ex;
            //}
            //finally
            //{
            //    con.Close();
            //    con.Dispose();
            //}





        }

    }

    protected void TextBox2_TextChanged1(object sender, EventArgs e)
    {

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        String strConnString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        String strQuery = "SELECT assetID from assets where employeeID = assetID";
        SqlConnection con = new SqlConnection(strConnString);
        SqlCommand cmd = new SqlCommand();
       //cmd.Parameters.AddWithValue("@assetID", DropDownList1.SelectedItem.Value);
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = strQuery;
        cmd.Connection = con;
        try
        {
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {

                // object dsYourDataSet = null;
                //  TextBox2.DataBinding.Add("Text", dsYourDataSet, "EMployees.employeeID");
                bool done = false;

                do
                {
                    done = true;
                    for (int i = 0; i < DropDownList1.Items.Count; i++)
                    {

                        if (String.IsNullOrWhiteSpace(DropDownList1.Items[i].Value))
                        {
                            DropDownList1.Items.RemoveAt(i);
                            done = false;
                            break;
                        }

                    }
                } while (!done);
                TextBox2.Text = DropDownList1.SelectedValue.ToString();

            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            con.Close();
            con.Dispose();
        }

    }






    // code below is for testing

   



}



