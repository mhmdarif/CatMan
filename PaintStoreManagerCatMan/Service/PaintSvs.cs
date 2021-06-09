using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintStoreManagerCatMan.Entity;
using PaintStoreManagerCatMan.Service;
using System.Data.SqlClient;


namespace PaintStoreManagerCatMan.Service
{
    class PaintSvs : IPaintSvs
    {
        readonly string connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database\PaintStoreDB.mdf;Integrated Security=True;Connect Timeout=30";

        public List<Paints> GetAllPaints()
        {
            List<Paints> ListPaint = new List<Paints>();

            SqlConnection con = new SqlConnection(connstring);
            string sql = "SELECT * FROM TblPaints";

            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Paints newPaint = new Paints();

                newPaint.Id = (int)dr["Id"];
                newPaint.Brand = dr["Brand"].ToString();
                newPaint.Color = dr["Color"].ToString();
                newPaint.Category = dr["Category"].ToString();
                newPaint.Size = dr["Size"].ToString();
                newPaint.Quantity = (int)dr["Quantity"];
                newPaint.BuyPrice = (double)dr["BuyPrice"];
                newPaint.SellPrice = (double)dr["SellPrice"];

                ListPaint.Add(newPaint);
            }

            return ListPaint;
        }

        public void Add(string nama, string color, string ctg, string size, int qty, double bp, double sp)
        {
            SqlConnection con = new SqlConnection(connstring);
            string sql = "insert into TblPaints (Category,Brand,Color,Size,Quantity,BuyPrice,SellPrice) values('" + nama + "','" + color + "','" + ctg + "','" + size + "','" + qty + "','" + bp + "','" + sp + "')";

            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Delete(int id)
        {
            SqlConnection con = new SqlConnection(connstring);
            string sql = "delete from Tblpaints where Id = @Id";

            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        public void Update(int id, string ctg, string nama, string color, string size, int qty, double bp, double sp)
        {
            SqlConnection con = new SqlConnection(connstring);
            string sql = "UPDATE TblPaints SET Brand = @Brand , Color = @Color,Category = @Category, Size = @Size , Quantity = @Quantity , BuyPrice = @BuyPrice, SellPrice = @SellPrice where Id = @Id";

            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Brand", nama);
            cmd.Parameters.AddWithValue("@Category", ctg);
            cmd.Parameters.AddWithValue("@Color", color);
            cmd.Parameters.AddWithValue("@Size", size);
            cmd.Parameters.AddWithValue("@Quantity", qty);
            cmd.Parameters.AddWithValue("@BuyPrice", bp);
            cmd.Parameters.AddWithValue("@SellPrice", sp);
            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
