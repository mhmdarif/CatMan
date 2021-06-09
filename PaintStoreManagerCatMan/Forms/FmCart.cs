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

        public FmCart()
        {
            InitializeComponent();
        }

        private void Btn_Pay_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void Btn_AddCart_Click(object sender, EventArgs e)
        {

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


        private int GetId()
        {
            return int.Parse(DGV_PaintCart.CurrentRow.Cells[0].Value.ToString());
        }
        private void ClearAll()
        {
            TB_CustomerEmail.Clear();
            TB_CustomerName.Clear();
            Tb_CustomerCash.Clear();
        }
        public void UpdateDgv()
        {
            List<Paints> dgv = newPaint.GetAllPaints();
            DGV_PaintCart.DataSource = dgv;
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
    }
}
