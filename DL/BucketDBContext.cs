using Microsoft.EntityFrameworkCore;
using Models;

namespace DL
{
    public class BucketDBContext : DbContext
    {
        public BucketDBContext() : base() { }
        public BucketDBContext(DbContextOptions options) : base(options) { }
        public DbSet<User> User { set; get; }
        public DbSet<Bucketlist> Bucketlists { set; get; }
        public DbSet<BucketItem> BucketItems { set; get; }
    }
}
