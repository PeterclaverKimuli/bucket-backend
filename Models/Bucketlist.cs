using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Bucketlist
    {
        public int Id { set; get; }
        public int Name { set; get; }
        public int UserId { set; get; }
        public List<BucketItem> BucketItems { set; get; }
        public DateTime DateCreated { set; get; }
    }
}
