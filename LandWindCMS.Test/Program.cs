using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandWindCMS.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  EF Test   
            using (var cnx = new Model.LandWindCMSEntities())
            { 
                //read 
                var userList = cnx.User.OrderByDescending(a=>a.Id).Take(3);
                foreach (var user in userList)
                {
                    Console.WriteLine($"userId{user.Id}{user.UserName}{user.RealName}");
                }
                //123

            }

            #endregion
        }
    }
}
