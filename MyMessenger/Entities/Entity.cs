using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{

    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
    }

    public class Message
    {
        public int Id { get; set; }
        public int MsgFrom { get; set; }
        public int MsgTo { get; set; }
        public string Sub { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
    }
}
