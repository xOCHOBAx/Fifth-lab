using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class bll
    {
        static DAL.IDataAccesLayer dal;

        public bool AddUser(string UserName, string Password, string FullName)
        {
            if (UserName != null && Password != null && FullName != null)
            {
                dal = new DAL.DataAccesLayer();
                return dal.AddUser(UserName, Password, FullName);
            }
            return false;
        }

        public Entities.User GetUserByName(string UserName)
        {
            if (UserName != null)
            {
                dal = new DAL.DataAccesLayer();
                return dal.GetUserByName(UserName);
            }
            return null;
        }

        public List<Entities.Message> GetMessagesFromById(int Id)
        {
            if (Id < 0) return null;
            dal = new DAL.DataAccesLayer();
            return dal.GetMessagesFromById(Id);
        }

        public List<Entities.Message> GetMessagesToById(int Id)
        {
            if (Id < 0) return null;
            dal = new DAL.DataAccesLayer();
            return dal.GetMessagesToById(Id);
        }

        public bool Authorize(string UserName, string Password)
        {
            if (UserName != null && Password != null)
            {
                dal = new DAL.DataAccesLayer();
                return dal.Authorize(UserName, Password);
            }
            return false;
        }

        public bool AddMessage(int MsgFrom, int MsgTo, string Sub, string Body)
        {
            if (ValidateMessage(Body) && MsgFrom >= 0 && MsgTo >= 0 && ValidateMessage(Sub))
            {
                dal = new DAL.DataAccesLayer();
                return dal.AddMessage(MsgFrom, MsgTo, Sub, Body);
            }
            return false;
        }

        public Entities.User GetUser(int Id)
        {
            dal = new DAL.DataAccesLayer();
            return dal.GetUser(Id);
        }

        public bool ValidateMessage(string Body)
        {
            var regex = new Regex($"(идиот)", RegexOptions.IgnoreCase);
            if (regex.IsMatch(Body)) return false;
            return true;
        }
    }
}
