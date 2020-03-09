using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AssignmentOnDB
{
    class Program
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A63MUHA\SQLEXPRESS;Initial Catalog=ProductDB;User ID=sa;Password=pass@word1");
        SqlCommand cmd = null;
        public void Add(int id,string name,int price,int stock)
        {
            try
            {
                cmd = new SqlCommand("Insert into Product values(@id,@name,@price,@stock)", con);
                
                cmd.Parameters.AddWithValue("@id",id);
                cmd.Parameters.AddWithValue("@name",name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@stock", stock);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void GetProductById(int id)
        {
            try
            {
                cmd = new SqlCommand("Select * from Product where id=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();//execute select statement
                if (dr.HasRows)
                {
                    //Read Records in datareader
                    dr.Read(); //read only one record
                    Console.WriteLine("ID:{0} Name:{1} Price:{2} Stock:{3}",
                        dr["id"], dr["name"], dr["price"], dr["stock"]);
                }
                else
                    Console.WriteLine("Invalid Product ID");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();//close connection
            }
        }
        public void GetAllProducts()
        {
            try
            {
                cmd = new SqlCommand("Select * from Product", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Console.WriteLine("ID:{0} Name:{1} Price:{2} Stock:{3}",
                         dr["id"], dr["name" +
                         ""], dr["price"], dr["stock"]);
                    }
                }
                else
                    Console.WriteLine("Invalid Product ID");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();//close connection
            }
        }
        public void DelProductById(int id)
        {
            try
            {
                cmd = new SqlCommand("Delete from Product where id=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Record DELETED");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();//close connection
            }
        }
        public void Update(int id, int price, int stock)
        {
            try
            {
                cmd = new SqlCommand("Update Product set price=@price,stock=@stock where id=@id", con);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@stock", stock);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        static void Main(string[] args)
        {

            Program obj = new Program();
            Console.WriteLine("Enter Product Details to insert");
            int id = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            int price = int.Parse(Console.ReadLine());
            int stock= int.Parse(Console.ReadLine());
            obj.Add(id, name, price, stock);
            //obj.Add(1,"Headset",2000,2);
            //obj.Add(2, "Bluetooth",1000, 1);
            //obj.Add(3, "Smartphone", 18000, 5);
            obj.GetProductById(id);
            obj.GetAllProducts();
            //Console.WriteLine("Enter Product id to delete");
            //obj.DelProductById(id);
            obj.Update(3,16000,7);

            Console.ReadKey();
        }
    }
}
