using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintStoreManagerCatMan.Entity
{
    class Category
    {
        // properties
        public int CatId { get; set; }
        public string CatName { get; set; }
        public string CatDesc { get; set; }


        // constructor
        public Category()
        {

        }
        public Category(int id, string name, string desc)
        {
            CatId = id;
            CatName = name;
            CatDesc = desc;
        }

    }
}
