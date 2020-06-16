using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Text;
using blog.Entities;


namespace blog
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        
        public Context(DbContextOptions<Context> dbContext) : base(dbContext)
        {
        
            
        }


        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Comment>().HasOne<User>().WithMany().HasForeignKey(hj => hj.UserID);
            mb.Entity<Comment>().HasOne<Post>().WithMany(x => x.Comments).HasForeignKey(y => y.PostID);
            //mb.Entity<Post>().HasOne<User>().WithMany(x => x.Posts).HasForeignKey(y => y.AuthorID).OnDelete(DeleteBehavior.NoAction);
        }

    }
}
