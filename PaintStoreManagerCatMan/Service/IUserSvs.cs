using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintStoreManagerCatMan.Entity;

namespace PaintStoreManagerCatMan.Service
{
    interface IUserSvs
    {
        List<User> GetAllUser();
        void Add(string nama, string username, string pass);
        void Update(int id, string nama, string username, string pass);
        void Delete(int id);
    }
}
