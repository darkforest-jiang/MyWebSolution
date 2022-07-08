using DfConfig.Service.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DfConfig.Service.Context
{
    /// <summary>
    /// Mysql数据库Context
    /// </summary>
    public partial class MysqlDbContext : DbContextBase
    {
        public MysqlDbContext() { }

        public MysqlDbContext(DbContextOptions<MysqlDbContext> options)
          : base(options)
        {

        }

        public virtual DbSet<TAppKey> TAppKeys { get; set; } = null!;
        public virtual DbSet<TAppOwnRes> TAppOwnRes { get; set; } = null!;
        public virtual DbSet<TAppRes> TAppRes { get; set; } = null!;
        public virtual DbSet<TAppsetting> TAppsettings { get; set; } = null!;
        public virtual DbSet<TDic> TDics { get; set; } = null!;
        public virtual DbSet<TUser> TUsers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseMySql(ConnStr, Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.29-mysql"));
                optionsBuilder.UseMySql(ConnStr, Microsoft.EntityFrameworkCore.ServerVersion.AutoDetect(ConnStr));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<TAppKey>(entity =>
            {
                entity.HasKey(e => e.AppKey)
                    .HasName("PRIMARY");

                entity.ToTable("tappkey");

                entity.Property(e => e.AppKey)
                    .HasMaxLength(32)
                    .HasComment("主键 应用的key");

                entity.Property(e => e.AppName)
                    .HasMaxLength(50)
                    .HasComment("应用名称");
            });

            modelBuilder.Entity<TAppOwnRes>(entity =>
            {
                entity.ToTable("tappownres");

                entity.Property(e => e.Id).HasComment("主键Id 自增");

                entity.Property(e => e.AppKey)
                    .HasMaxLength(32)
                    .HasComment("appkey");

                entity.Property(e => e.AppResId).HasComment("资源Id");

                entity.Property(e => e.RuntimeEnv)
                    .HasMaxLength(10)
                    .HasComment("运行环境：Dev Test Prd");
            });

            modelBuilder.Entity<TAppRes>(entity =>
            {
                entity.ToTable("tappres");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasComment("主键Id 自增");

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .HasComment("文件名");

                entity.Property(e => e.FileType)
                    .HasMaxLength(255)
                    .HasComment("文件类型：Appsetting File");

                entity.Property(e => e.ResName)
                    .HasMaxLength(20)
                    .HasComment("资源名称");

                entity.Property(e => e.ResType)
                    .HasMaxLength(10)
                    .HasComment("资源类型：数据库 服务中心 其它");

                entity.Property(e => e.ResValue)
                    .HasColumnType("text")
                    .HasComment("资源值");

                entity.Property(e => e.RuntimeEnv)
                    .HasMaxLength(10)
                    .HasComment("运行环境:Dev Test Prd");
            });

            modelBuilder.Entity<TAppsetting>(entity =>
            {
                entity.HasKey(e => e.AppKey)
                    .HasName("PRIMARY");

                entity.ToTable("tappsetting");

                entity.Property(e => e.AppKey)
                    .HasMaxLength(32)
                    .HasComment("主键 AppKey");

                entity.Property(e => e.Appsetting)
                    .HasColumnType("text")
                    .HasComment("App配置文件");

                entity.Property(e => e.RuntimeEnv)
                    .HasMaxLength(10)
                    .HasComment("运行环境：Dev Test Prd");

                entity.Property(e => e.Version)
                    .HasMaxLength(10)
                    .HasComment("版本号");
            });

            modelBuilder.Entity<TDic>(entity =>
            {
                entity.ToTable("tdic");

                entity.Property(e => e.Id).HasComment("主键Id 自增");

                entity.Property(e => e.DicCode)
                    .HasMaxLength(20)
                    .HasComment("字典编码");

                entity.Property(e => e.DicName)
                    .HasMaxLength(20)
                    .HasComment("字典名称");

                entity.Property(e => e.DicType)
                    .HasMaxLength(20)
                    .HasComment("字典类型");

                entity.Property(e => e.Memo)
                    .HasMaxLength(20)
                    .HasComment("备注");
            });

            modelBuilder.Entity<TUser>(entity =>
            {
                entity.ToTable("tuser");

                entity.Property(e => e.Id).HasComment("主键Id 自增");

                entity.Property(e => e.LoginId)
                    .HasMaxLength(10)
                    .HasComment("登录账号");

                entity.Property(e => e.Name)
                    .HasMaxLength(32)
                    .HasComment("名称");

                entity.Property(e => e.Password)
                    .HasMaxLength(64)
                    .HasComment("登录密码");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
