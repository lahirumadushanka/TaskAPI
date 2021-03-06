// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskAPI.DatabaseAccess;

namespace TaskAPI.DatabaseAccess.Migrations
{
    [DbContext(typeof(TodoDBContext))]
    [Migration("20210817022205_JobRoleAddedToAuthor")]
    partial class JobRoleAddedToAuthor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TaskAPI.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressNo")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("JobRole")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Street")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressNo = "No 260/8",
                            City = "Hungama",
                            FullName = "Lahiru Madushanka",
                            JobRole = "Developer",
                            Street = "Ginigallanda"
                        },
                        new
                        {
                            Id = 2,
                            AddressNo = "No 300/8",
                            City = "Doranagoda",
                            FullName = "Manoshi Ramanayake",
                            JobRole = "Cloud Assistant",
                            Street = "Kelum Uyana"
                        },
                        new
                        {
                            Id = 3,
                            AddressNo = "No 255/4",
                            City = "Galle",
                            FullName = "Nansara Piyumal",
                            JobRole = "Machanical Engineer",
                            Street = "Watareka"
                        },
                        new
                        {
                            Id = 4,
                            AddressNo = "No 27/2",
                            City = "deldeniya",
                            FullName = "Nimal Premarathne",
                            JobRole = "Teacher",
                            Street = "udapita"
                        });
                });

            modelBuilder.Entity("TaskAPI.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Due")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Created = new DateTime(2021, 8, 17, 7, 52, 4, 915, DateTimeKind.Local).AddTicks(4444),
                            Description = "Get some text books for school",
                            Due = new DateTime(2021, 8, 22, 7, 52, 4, 916, DateTimeKind.Local).AddTicks(422),
                            Status = 0,
                            Title = "Get books for School - DB "
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            Created = new DateTime(2021, 8, 17, 7, 52, 4, 916, DateTimeKind.Local).AddTicks(2090),
                            Description = "Get vegetable for week",
                            Due = new DateTime(2021, 8, 19, 7, 52, 4, 916, DateTimeKind.Local).AddTicks(2098),
                            Status = 0,
                            Title = "Get vegetable"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 2,
                            Created = new DateTime(2021, 8, 17, 7, 52, 4, 916, DateTimeKind.Local).AddTicks(2111),
                            Description = "Water all the plants quickly",
                            Due = new DateTime(2021, 8, 18, 7, 52, 4, 916, DateTimeKind.Local).AddTicks(2112),
                            Status = 0,
                            Title = "Water the plants"
                        });
                });

            modelBuilder.Entity("TaskAPI.Models.Todo", b =>
                {
                    b.HasOne("TaskAPI.Models.Author", "Author")
                        .WithMany("Todos")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("TaskAPI.Models.Author", b =>
                {
                    b.Navigation("Todos");
                });
#pragma warning restore 612, 618
        }
    }
}
