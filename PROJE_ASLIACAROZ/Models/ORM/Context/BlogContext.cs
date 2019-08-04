using PROJE_ASLIACAROZ.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PROJE_ASLIACAROZ.Models.ORM.Context
{
    public class BlogContext : DbContext
   {
        public BlogContext()
        {

            Database.Connection.ConnectionString = "Server = DESKTOP-16TBRT6\\ASLISQL; Database = AsliMVCBlogProject; UID = sa; PWD= 1234";
  
        }

        public DbSet<AdminUser> AdminUsers { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }

        public DbSet<SiteMenu> SiteMenus { get; set; }

        public DbSet<PostImages> PostImages { get; set; }

        public DbSet<PostLikes> PostLikes { get; set; }

        public DbSet<WebUser> webUsers { get; set; }
    }
}