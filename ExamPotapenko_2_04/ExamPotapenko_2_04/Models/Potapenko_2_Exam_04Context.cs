using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ExamPotapenko_2_04.Models
{
    public partial class Potapenko_2_Exam_04Context : DbContext
    {
        public Potapenko_2_Exam_04Context()
        {
        }

        public Potapenko_2_Exam_04Context(DbContextOptions<Potapenko_2_Exam_04Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AssortimentPizzaPrice> AssortimentPizzaPrice { get; set; }
        public virtual DbSet<AssortmentPizza> AssortmentPizza { get; set; }
        public virtual DbSet<Ingridient> Ingridient { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderAssigment> OrderAssigment { get; set; }
        public virtual DbSet<PizzaIngridient> PizzaIngridient { get; set; }
        public virtual DbSet<PizzaSize> PizzaSize { get; set; }

        // Unable to generate entity type for table 'dbo.Pizza'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=hqvla3302s01\\KITP;Initial Catalog=Potapenko_2_Exam_04;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssortimentPizzaPrice>(entity =>
            {
                entity.HasKey(e => e.IdAssortimentPizzaPrice);

                entity.ToTable("Assortiment_Pizza_Price");

                entity.Property(e => e.IdAssortimentPizzaPrice)
                    .HasColumnName("ID_Assortiment_Pizza_Price")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<AssortmentPizza>(entity =>
            {
                entity.HasKey(e => e.IdAssortimentPizza);

                entity.ToTable("Assortment_Pizza");

                entity.Property(e => e.IdAssortimentPizza)
                    .HasColumnName("ID_Assortiment_Pizza")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdAssortimentPizzaPrice).HasColumnName("ID_Assortiment_Pizza_Price");

                entity.Property(e => e.IdPizza).HasColumnName("ID_Pizza");

                entity.Property(e => e.IdPizzaSize).HasColumnName("ID_Pizza_Size");

                entity.HasOne(d => d.IdAssortimentPizzaPriceNavigation)
                    .WithMany(p => p.AssortmentPizza)
                    .HasForeignKey(d => d.IdAssortimentPizzaPrice)
                    .HasConstraintName("FK_Assortment_Pizza_Assortiment_Pizza_Price");
            });

            modelBuilder.Entity<Ingridient>(entity =>
            {
                entity.HasKey(e => e.IdIngridient);

                entity.Property(e => e.IdIngridient)
                    .HasColumnName("ID_Ingridient")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.IdOrder);

                entity.Property(e => e.IdOrder).HasColumnName("ID_Order");

                entity.Property(e => e.ClientFname)
                    .HasColumnName("Client_Fname")
                    .HasMaxLength(255);

                entity.Property(e => e.ClientLname)
                    .HasColumnName("Client_Lname")
                    .HasMaxLength(255);

                entity.Property(e => e.ClientSname)
                    .HasColumnName("Client_Sname")
                    .HasMaxLength(255);

                entity.Property(e => e.DeliveryApartment)
                    .HasColumnName("Delivery_Apartment")
                    .HasMaxLength(255);

                entity.Property(e => e.DeliveryHome).HasColumnName("Delivery_Home");

                entity.Property(e => e.DeliveryStreet)
                    .HasColumnName("Delivery_Street")
                    .HasMaxLength(255);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Phone).HasMaxLength(255);
            });

            modelBuilder.Entity<OrderAssigment>(entity =>
            {
                entity.HasKey(e => e.IdOrderAssortment);

                entity.ToTable("Order_Assigment");

                entity.Property(e => e.IdOrderAssortment)
                    .HasColumnName("ID_Order_Assortment")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdAssortiment).HasColumnName("ID_Assortiment");

                entity.Property(e => e.IdOrder).HasColumnName("ID_Order");
            });

            modelBuilder.Entity<PizzaIngridient>(entity =>
            {
                entity.HasKey(e => e.IdPizzaIngridient);

                entity.ToTable("Pizza_Ingridient");

                entity.Property(e => e.IdPizzaIngridient)
                    .HasColumnName("ID_Pizza_Ingridient")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdIngridient).HasColumnName("ID_Ingridient");

                entity.Property(e => e.IdPizza).HasColumnName("ID_Pizza");
            });

            modelBuilder.Entity<PizzaSize>(entity =>
            {
                entity.HasKey(e => e.IdPizzaSize);

                entity.ToTable("Pizza_Size");

                entity.Property(e => e.IdPizzaSize)
                    .HasColumnName("ID_Pizza_Size")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(255);
            });
        }
    }
}
