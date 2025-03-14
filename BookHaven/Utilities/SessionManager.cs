using BookHaven.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Utilities
{
    public static class SessionManager
    {
        public static UserModel LoggedInUser { get; set; }
    }
}
