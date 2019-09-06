using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace RestaurantMenuApp.database_access_layer
{
    public class db
    {
        // daatabase string connection
        string connectionString = @"Data Source=DESKTOP-0N4TJ55\MYSQLSERVER;Initial Catalog=Restaurant;Integrated Security=True";
        // get the main menu category
        public DataSet getCategory()
        {
            using(SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                string query = "Select * From Category";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;

            }
            
        }

        // get the main menu subcategory
        public DataSet getSubCategory(int catId)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                string query = "SELECT * FROM Subcategory WHERE Category_id=@catId";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@catId", catId);
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;

            }

        }

        // get the main menu SubCategorysub
        public DataSet getSubCategorysub(int subcatId)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                string query = "SELECT * FROM Subcategorysub WHERE Subcat_id=@subcatId";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@subcatId", subcatId);
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;

            }

        }
    }
}