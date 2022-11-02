using System;
using System.Collections.Generic;
using System.Text;

namespace RealWorldApp.Models
{
    public class Token
    {
        public string AccessToken { get; set; }
        public string TokenType { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int ExpiresIn { get; set; }
        public int CreationTime { get; set; }
        public int ExpirationTime { get; set; }
    }
}
