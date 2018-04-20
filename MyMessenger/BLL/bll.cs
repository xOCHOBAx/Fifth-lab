using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class bll
    {
        static DAL.DataAccesLayer dal = new DAL.DataAccesLayer();

        public bool AddUser(string UserName,string Password,string FullName)
        {
            return dal.AddUser(UserName,Password,FullName);
        }

        public bool AddMessage(int MsgFrom,int MsgTo,string Sub,string Body) { return false; }
    }
}
