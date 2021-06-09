﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintStoreManagerCatMan.Entity;
using PaintStoreManagerCatMan.Service;
using System.Data.SqlClient;

namespace PaintStoreManagerCatMan.Service
{
    class CartSvs : ICartSvs
    {
        readonly string connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database\PaintStoreDB.mdf;Integrated Security=True;Connect Timeout=30";

        public List<Carts> GetAllCarts()
        {
            List<Carts> ListCart = new List<Carts>();

            SqlConnection con = new SqlConnection(connstring);
            string sql = "SELECT * FROM TblCarts";

            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Carts newCart = new Carts();

                newCart.Id = (int)dr["Id"];
                newCart.Brand = dr["Brand"].ToString();
                newCart.Color = dr["Color"].ToString();
                newCart.Category = dr["Category"].ToString();
                newCart.Size = dr["Size"].ToString();
                newCart.BuyPrice = (double)dr["BuyPrice"];               

                ListCart.Add(newCart);
            }

            return ListCart;
        }
        public void Add(string nama, string color, string ctg, string size, double bp)
        {
            SqlConnection con = new SqlConnection(connstring);
            string sql = "insert into TblCarts (Category,Brand,Color,Size,BuyPrice) values('" + nama + "','" + color + "','" + ctg + "','" + size + "','" + bp + "')";

            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Delete(int id)
        {
            SqlConnection con = new SqlConnection(connstring);
            string sql = "delete from TblCart where Id = @Id";

            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        public void Update(int id, string nama, string color, string ctg, int qty, double bp)
        {
            SqlConnection con = new SqlConnection(connstring);
            string sql = "UPDATE TblCarts SET Brand = @Brand , Color = @Color,Category = @Category, Size = @Size, BuyPrice = @BuyPrice where Id = @Id";

            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Brand", nama);
            cmd.Parameters.AddWithValue("@Category", ctg);
            cmd.Parameters.AddWithValue("@Color", color);
            cmd.Parameters.AddWithValue("@Quantity", qty);
            cmd.Parameters.AddWithValue("@BuyPrice", bp);
            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
