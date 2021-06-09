using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintStoreManagerCatMan.Entity;

namespace PaintStoreManagerCatMan.Service
{
    interface IPaintSvs
    {
        List<Paints> GetAllPaints();
        void Add(string ctg, string nama, string color, string size, int qty, double bp, double sp);
        void Update(int id, string ctg, string nama, string color, string size, int qty, double bp, double sp);
        void Delete(int id);
    }
}
