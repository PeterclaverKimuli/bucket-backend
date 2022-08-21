using System;
using System.Collections.Generic;

namespace Models
{
    public class User
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public List<Bucketlist> Bucketlists { set; get; }
    }
}
