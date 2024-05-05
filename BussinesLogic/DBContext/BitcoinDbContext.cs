using BussinesLogic.Objects;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace BussinesLogic.DBContext
{

    public class BitcoinDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public BitcoinDbContext()
        {
            _configuration = new ConfigurationBuilder()
                            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                            .Build();
        }

        public BitcoinDbContext(DbContextOptions<BitcoinDbContext> options)
            : base(options)
        {
        }

        public DbSet<BitcoinRate> BitcoinRates { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = _configuration.GetSection("DefaultDB").Value;
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BitcoinRate>(entity =>
            {
                entity.ToTable("BitcoinRate");

                entity.HasKey(e => e.ID).HasName("PK_BitcoinRate");

                entity.Property(e => e.ID).HasColumnName("ID").ValueGeneratedOnAdd();

                entity.Property(e => e.BTC_EUR).HasColumnName("BTC_EUR").HasColumnType("decimal(18, 3)").IsRequired();

                entity.Property(e => e.CZK_EUR).HasColumnName("CZK_EUR").HasColumnType("decimal(18, 3)").IsRequired();

                entity.Property(e => e.BTC_CZK).HasColumnName("BTC_CZK").HasColumnType("decimal(18, 3)").IsRequired();

                entity.Property(e => e.CreateDate).HasColumnName("CreateDate").HasColumnType("datetime").IsRequired();

                entity.Property(e => e.DownloadedDate).HasColumnName("DownloadedDate").HasColumnType("datetime").IsRequired();

                entity.Property(e => e.Note).HasColumnName("Note").HasMaxLength(3000).IsUnicode(false);
            });
        }
    }
}