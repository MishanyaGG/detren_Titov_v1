﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WoldProject
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class de41_TItov_v2Entities : DbContext
    {
        private static de41_TItov_v2Entities _context;
        public de41_TItov_v2Entities()
            : base("name=de41_TItov_v2Entities")
        {
        }

        public static de41_TItov_v2Entities GetContext()
        {
            if (_context == null)
                _context = new de41_TItov_v2Entities();

            return _context;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<shifts> shifts { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
