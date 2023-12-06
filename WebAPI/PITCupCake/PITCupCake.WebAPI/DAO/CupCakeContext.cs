using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Reflection.Metadata;

using Microsoft.EntityFrameworkCore;

using Newtonsoft.Json;

namespace PITCupCake.WebAPI.DAO
{
   public class CupCakeContext : DbContext
   {
      public DbSet<CupCake> CupCake { get; set; }

     
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
         IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
         optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
      }
   }
   public class CupCake
   {
      public long Id { get; set; }

      public string Name { get; set; }

      public decimal Price { get; set; }

      public string Description { get; set; }

      public string ImageURL { get; set; }

      public string ImageAlt { get; set; }

      public string ImageCredit { get; set; }
   }
}