using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaintStoreManagerCatMan.Entity;
using PaintStoreManagerCatMan.Service;
using System.Data.SqlClient;

namespace PaintStoreManagerCatMan.Forms
{
    public partial class FmCart : Form
    {
        readonly string connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database\PaintStoreDB.mdf;Integrated Security=True;Connect Timeout=30";
        readonly private PaintSvs newPaint = new PaintSvs();
        readonly private CartSvs newCart = new CartSvs();

        public FmCart()
        {
            InitializeComponent();
        }

        private void Btn_Pay_Click(object sender, EventArgs e)
        {

        }

        private void Btn_AddCart_Click(object sender, EventArgs e)
        {
            
            int id = int.Parse(DGV_PaintCart.CurrentRow.Cells[0].Value.ToString());
            string _Brand = "";
            string _Color = "";
            string _category = "";
            string _size = "";
            double _Price = 0;

            string sql = "select * from TblPaints where Id = '" + id + "' ";
            
            SqlConnection con = new SqlConnection(connstring);

            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                _Brand = dr[1].ToString();
                _Color = dr[2].ToString();
                _category = dr[3].ToString();
                _size = dr[4].ToString();
                _Price = double.Parse(dr[6].ToString());
            }
            con.Close();

            newCart.Add(_Brand, _Color,_category, _size, _Price);

            UpdateDgv();
        }

        private void FillCombo()
        {
            SqlConnection con = new SqlConnection(connstring);
            string sql = "SELECT CateName, Id FROM TblCategories";

            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CB_CateCart.Items.Add(dr["CateName"].ToString());
                CB_CateCart.DisplayMember = dr["CateName"].ToString();
                CB_CateCart.ValueMember = dr["Id"].ToString();
            }
            con.Close();
        }

        private void FmCart_Load(object sender, EventArgs e)
        {
            UpdateDgv();
            FillCombo();
        }
        
        private void ClearAll()
        {
            TB_CustomerName.Clear();
            Tb_CustomerCash.Clear();
        }
        public void UpdateDgv()
        {
            List<Paints> dgv = newPaint.GetAllPaints();
            DGV_PaintCart.DataSource = dgv;
            List<Carts> dgvCart = newCart.GetAllCarts();
            DGV_Cart.DataSource = dgvCart;
        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CB_CateCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_CateCart.Text == "All")
            {
                UpdateDgv();
            }
            else
            {
                List<Paints> ListPaints = new List<Paints>();

                SqlConnection con = new SqlConnection(connstring);
                string sql = "SELECT * FROM TblPaints where Category = '" + CB_CateCart.Text + "'";

                con.Open();

                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Paints newPaints = new Paints();

                    newPaints.Id = (int)dr["Id"];
                    newPaints.Brand = dr["Brand"].ToString();
                    newPaints.Color = dr["Color"].ToString();
                    newPaints.Category = dr["Category"].ToString();
                    newPaints.Size = dr["Size"].ToString();
                    newPaints.Quantity = (int)dr["Quantity"];
                    newPaints.BuyPrice = (double)dr["BuyPrice"];
                    newPaints.SellPrice = (double)dr["SellPrice"];

                    ListPaints.Add(newPaints);
                }

                List<Paints> dgv = ListPaints;
                DGV_PaintCart.DataSource = dgv;
            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void Btn_DeleteCart_Click(object sender, EventArgs e)
        {
            int id = int.Parse(DGV_Cart.CurrentRow.Cells[0].Value.ToString());

            newCart.Delete(id);

            UpdateDgv();
        }
    }
}
