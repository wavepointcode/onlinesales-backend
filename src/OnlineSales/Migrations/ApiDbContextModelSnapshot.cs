﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using OnlineSales.Data;

#nullable disable

namespace OnlineSales.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    partial class ApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("OnlineSales.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Approved")
                        .HasColumnType("integer")
                        .HasColumnName("approved");

                    b.Property<string>("AuthorEmail")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("author_email");

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("author_name");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("content");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("CreatedByIP")
                        .HasColumnType("text")
                        .HasColumnName("created_by_ip");

                    b.Property<string>("CreatedByUserAgent")
                        .HasColumnType("text")
                        .HasColumnName("created_by_user_agent");

                    b.Property<int?>("ParentId")
                        .HasColumnType("integer")
                        .HasColumnName("parent_id");

                    b.Property<int>("PostId")
                        .HasColumnType("integer")
                        .HasColumnName("post_id");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<string>("UpdatedByIP")
                        .HasColumnType("text")
                        .HasColumnName("updated_by_ip");

                    b.Property<string>("UpdatedByUserAgent")
                        .HasColumnType("text")
                        .HasColumnName("updated_by_user_agent");

                    b.HasKey("Id")
                        .HasName("pk_comments");

                    b.HasIndex("ParentId")
                        .HasDatabaseName("ix_comments_parent_id");

                    b.HasIndex("PostId")
                        .HasDatabaseName("ix_comments_post_id");

                    b.ToTable("comments", (string)null);
                });

            modelBuilder.Entity("OnlineSales.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("address1");

                    b.Property<string>("Address2")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("address2");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("company_name");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("CreatedByIP")
                        .HasColumnType("text")
                        .HasColumnName("created_by_ip");

                    b.Property<string>("CreatedByUserAgent")
                        .HasColumnType("text")
                        .HasColumnName("created_by_user_agent");

                    b.Property<string>("Culture")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("culture");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("last_name");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("location");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phone");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("state");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<string>("UpdatedByIP")
                        .HasColumnType("text")
                        .HasColumnName("updated_by_ip");

                    b.Property<string>("UpdatedByUserAgent")
                        .HasColumnType("text")
                        .HasColumnName("updated_by_user_agent");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("zip");

                    b.HasKey("Id")
                        .HasName("pk_customers");

                    b.ToTable("customers", (string)null);
                });

            modelBuilder.Entity("OnlineSales.Entities.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("AllowComments")
                        .HasColumnType("boolean")
                        .HasColumnName("allow_comments");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("author");

                    b.Property<string>("Categories")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("categories");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("content");

                    b.Property<string>("CoverImageAlt")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("cover_image_alt");

                    b.Property<string>("CoverImageUrl")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("cover_image_url");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("CreatedByIP")
                        .HasColumnType("text")
                        .HasColumnName("created_by_ip");

                    b.Property<string>("CreatedByUserAgent")
                        .HasColumnType("text")
                        .HasColumnName("created_by_user_agent");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Lang")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("lang");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("slug");

                    b.Property<string>("Tags")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("tags");

                    b.Property<string>("Template")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("template");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<string>("UpdatedByIP")
                        .HasColumnType("text")
                        .HasColumnName("updated_by_ip");

                    b.Property<string>("UpdatedByUserAgent")
                        .HasColumnType("text")
                        .HasColumnName("updated_by_user_agent");

                    b.HasKey("Id")
                        .HasName("pk_posts");

                    b.ToTable("posts", (string)null);
                });

            modelBuilder.Entity("OnlineSales.Entities.Comment", b =>
                {
                    b.HasOne("OnlineSales.Entities.Comment", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId")
                        .HasConstraintName("fk_comments_comments_parent_id");

                    b.HasOne("OnlineSales.Entities.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_comments_posts_post_id");

                    b.Navigation("Parent");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("OnlineSales.Entities.Post", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
