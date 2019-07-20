﻿// <auto-generated />
using BLL.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BLL.Migrations
{
    [DbContext(typeof(UserReporsitory))]
    partial class UserReporsitoryModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BLL.Email", b =>
                {
                    b.Property<string>("EmailID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Code");

                    b.Property<bool>("IsActivate");

                    b.HasKey("EmailID");

                    b.ToTable("Email");
                });

            modelBuilder.Entity("BLL.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailID");

                    b.Property<int>("Integral");

                    b.Property<string>("PassWord");

                    b.Property<string>("UserName");

                    b.HasKey("ID");

                    b.HasIndex("EmailID");

                    b.ToTable("users");
                });

            modelBuilder.Entity("BLL.User", b =>
                {
                    b.HasOne("BLL.Email", "Email")
                        .WithMany()
                        .HasForeignKey("EmailID");
                });
#pragma warning restore 612, 618
        }
    }
}
