using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data;

namespace DAL
{
    public interface IDataAccesLayer
    {
        bool Authorize(string UserName, string Password);
        bool AddUser(string UserName, string Password, string FullName);
        User GetUserByName(string UserName);
        User GetUser(int Id);

        bool AddMessage(int MsgFrom, int MsgTo, string Sub, string Body);
        List<Entities.Message> GetMessagesFromById(int Id);
        List<Entities.Message> GetMessagesToById(int Id);
        Entities.Message GetMessage(int Id);
        Entities.Message FormMessageFromRow(DataRow row);
    }
}
