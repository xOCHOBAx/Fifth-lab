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

        public bool AddUser(string UserName, string Password, string FullName)
        {
            dal = new DAL.DataAccesLayer();
            return dal.AddUser(UserName, Password, FullName);
        }

        public Entities.User GetUserByName(string UserName)
        {
            dal = new DAL.DataAccesLayer();
            return dal.GetUserByName(UserName);
        }

        public List<Entities.Message> GetMessagesFromById(int Id)
        {
            dal = new DAL.DataAccesLayer();
            return dal.GetMessagesFromById(Id);
        }

        public List<Entities.Message> GetMessagesToById(int Id)
        {
            dal = new DAL.DataAccesLayer();
            return dal.GetMessagesToById(Id);
        }

        public bool Authorize(string UserName,string Password)
        {
            dal = new DAL.DataAccesLayer();
            return dal.Authorize(UserName,Password);
        }

        public bool AddMessage(int MsgFrom, int MsgTo, string Sub, string Body) { return false; }

        public Entities.User GetUser(int Id)
        {
            dal = new DAL.DataAccesLayer();
            return dal.GetUser(Id);
        }
    }
}
