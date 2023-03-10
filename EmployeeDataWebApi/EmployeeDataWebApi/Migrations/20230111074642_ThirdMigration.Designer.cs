// <auto-generated />
using EmployeeDataWebApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeDataWebApi.Migrations
{
    [DbContext(typeof(EmployeeDbConext))]
    [Migration("20230111074642_ThirdMigration")]
    partial class ThirdMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EmployeeDataWebApi.Models.Employee", b =>
                {
                    b.Property<int>("EmpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EmpID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpId"), 1L, 1);

                    b.Property<string>("DateOfBirth")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Designation")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("EmpId");

                    b.ToTable("Employee", (string)null);
                });

            modelBuilder.Entity("EmployeeDataWebApi.Models.UserInfo", b =>
                {
                    b.Property<string>("DisplayName")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.Property<string>("UserName")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.ToTable("UserInfo", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
