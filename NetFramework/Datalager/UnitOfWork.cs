using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Threading;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using Entitetslager;
using System.Security.Cryptography.X509Certificates;

namespace Datalager
{
    public class UnitOfWork : DbContext
    {
        #region DbSet
        public DbSet<Anställd> anställda { get; set; }
        public DbSet<Bokning> bokningar { get; set; }
        public DbSet<Skidlektion> skidlektioner { get; set; }
        public DbSet<Uthyrning> uthyrningar { get; set; }
        public DbSet<Utrustning> utrustningar { get; set; }
        public DbSet<Faktura> fakturor { get; set; }
        public DbSet<Företag> företag { get; set; }
        public DbSet<Kund> kunder { get; set; }
        public DbSet<Logi> logier { get; set; }
        public DbSet<Privatperson> privatpersoner { get; set; }


        #endregion
        public UnitOfWork() 
            : base("suht2304") 
        {
           //Reset();
           //Seed();
            
        }

        public void Reset()
        {
            #region Remove Tables
            using (SqlConnection conn = new SqlConnection(Database.Connection.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("EXEC sp_msforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT all'; EXEC sp_msforeachtable 'DROP TABLE ?'", conn))
            {
                conn.Open();
                for (int i = 0; i < 5; i++)
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (System.Exception)
                    {
                        // throw;
                    }
                }
                conn.Close();
            }
            #endregion
        }

        public void Seed()
        {
            Anställd anställd1 = new Anställd(1, "Sasha", "Stojanovic", "123", "Formell/byråkratiskt anställd");
           anställda.Add(anställd1);
           Företag företag1 = new Företag(100, "Apple");
           företag.Add(företag1 );

            SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public override DbSet<TEntity> Set<TEntity>()
        {
            return base.Set<TEntity>();
        }

        public override DbSet Set(Type entityType)
        {
            return base.Set(entityType);
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override bool ShouldValidateEntity(DbEntityEntry entityEntry)
        {
            return base.ShouldValidateEntity(entityEntry);
        }

        protected override DbEntityValidationResult ValidateEntity(DbEntityEntry entityEntry, IDictionary<object, object> items)
        {
            return base.ValidateEntity(entityEntry, items);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
