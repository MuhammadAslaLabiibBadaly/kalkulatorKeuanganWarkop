using KeuanganWarkop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeuanganWarkop.Controllers
{
    public class UserController
    {
        public bool LoginUser(string username, string password)
        {
            return UserModel.Login(username, password);
        }

        public bool RegisterUser(string username, string password)
        {
            return UserModel.Register(username, password);
        }
    }
}
