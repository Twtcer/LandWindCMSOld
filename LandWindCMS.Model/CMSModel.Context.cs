﻿
 
 //------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace LandWindCMS.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LandWindCMSEntities : DbContext,System.IDisposable
    {
        public LandWindCMSEntities()
            : base("name=LandWindCMSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Resource> Resource { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RoleResource> RoleResource { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserResource> UserResource { get; set; }
    }
}
