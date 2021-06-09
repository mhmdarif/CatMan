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
    class CategoryServices : ICategorySvs
    {
        readonly string connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database\PaintStoreDB.mdf;Integrated Security=True;Connect Timeout=30";
        
        public List<Category> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public void Add(string catname, string catdesc)
        {
            SqlConnection con = new SqlConnection(connstring);
            string sql = "insert into TblCategories (Catename, CateDesc) values('" + catname"','" +y + "','" + hour + "')";

            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, string catname, string catdesc)
        {
            throw new NotImplementedException();
        }
    }
}
