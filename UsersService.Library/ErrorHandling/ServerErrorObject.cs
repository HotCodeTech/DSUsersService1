using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersService.Library.ErrorHandling
{
    public class ServerErrorObject
    {
        public string Message { get; set; }
        public DateTime Time { get; set; }
        public ServerErrorObject()
        {
            Message = "Internal server error. We could not process your request at this time. Please try again later.";
            Time = DateTime.Now;
        }
        public ServerErrorObject(String message)
            : this()
        {
            Message = message;
        }
    }
}
