﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaintStoreManagerCatMan.Service;
using System.Data.SqlClient;
using PaintStoreManagerCatMan.Entity;

namespace PaintStoreManagerCatMan.Forms
{
    public partial class FmProducts : Form
    {
        readonly string connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database\PaintStoreDB.mdf;Integrated Security=True;Connect Timeout=30";
        readonly private PaintSvs newItems = new PaintSvs();
        public FmProducts()
        {
            InitializeComponent();
        }

        private void FmProducts_Load(object sender, EventArgs e)
        {
            UpdateDgv();
            FillCombo();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (TB_Brand.Text != "" || Tb_Color.Text != ""|| TB_Size.Text != "" || TB_Quantity.Text != "" || TB_BuyPrice.Text != "" || TB_SellPrice.Text != "" || CB_CatePaint.SelectedIndex > -1)
            {
                newItems.Add(CB_CatePaint.Text, TB_Brand.Text,Tb_Color.Text,TB_Size.Text, int.Parse(TB_Quantity.Text) , double.Parse(TB_BuyPrice.Text), double.Parse(TB_SellPrice.Text));
            }
            else
            {
                MessageBox.Show("Missing Information");
            }

            UpdateDgv();
            ClearAll();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            int id = GetId();

            if (TB_Brand.Text != "" || Tb_Color.Text != "" || TB_Size.Text != "" || TB_Quantity.Text != "" || TB_BuyPrice.Text != "" || TB_SellPrice.Text != "" || CB_CatePaint.SelectedIndex > -1)
            {
                newItems.Update(id, CB_CatePaint.Text, TB_Brand.Text, Tb_Color.Text, TB_Size.Text, int.Parse(TB_Quantity.Text), double.Parse(TB_BuyPrice.Text), double.Parse(TB_SellPrice.Text));
            }
            else
            {
                MessageBox.Show("Missing Information");
            }


            UpdateDgv();
            ClearAll();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(DGV_Paint.CurrentRow.Cells[0].Value.ToString());
            newItems.Delete(id);

            UpdateDgv();
            ClearAll();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private int GetId()
        {
            return int.Parse(DGV_Paint.CurrentRow.Cells[0].Value.ToString());
        }
        private void ClearAll()
        {
            TB_Brand.Clear();
            Tb_Color.Clear();
            TB_Size.Clear();
            TB_Quantity.Clear();
            TB_SellPrice.Clear();
            TB_BuyPrice.Clear();

        }
        public void UpdateDgv()
        {
            List<Paints> dgv = newItems.GetAllPaints();
            DGV_Paint.DataSource = dgv;
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
                CB_CatePaint.Items.Add(dr["CateName"].ToString());
                CB_CatePaint.DisplayMember = dr["CateName"].ToString();
                CB_CatePaint.ValueMember = dr["Id"].ToString();
            }
            con.Close();
        }
    }
}
