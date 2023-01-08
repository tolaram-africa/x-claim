﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using XClaim.Web.Server.Data;

#nullable disable

namespace XClaim.Web.Server.Migrations
{
    [DbContext(typeof(ServerContext))]
    partial class ServerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("XClaim.Common.Entities.BankAccountEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<Guid?>("BankId")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("bank_id");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Description")
                        .HasMaxLength(1024)
                        .HasColumnType("TEXT")
                        .HasColumnName("description");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("full_name");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("modified_at");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT")
                        .HasColumnName("number");

                    b.Property<Guid?>("OwnerId")
                        .HasColumnType("TEXT")
                        .HasColumnName("owner_id");

                    b.HasKey("Id")
                        .HasName("pk_bank_accounts");

                    b.HasIndex("BankId")
                        .HasDatabaseName("ix_bank_accounts_bank_id");

                    b.HasIndex("DeletedAt")
                        .HasDatabaseName("ix_bank_accounts_deleted_at");

                    b.HasIndex("OwnerId")
                        .IsUnique()
                        .HasDatabaseName("ix_bank_accounts_owner_id");

                    b.ToTable("bank_accounts", (string)null);
                });

            modelBuilder.Entity("XClaim.Common.Entities.BankEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("deleted_at");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("modified_at");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_banks");

                    b.HasIndex("DeletedAt")
                        .HasDatabaseName("ix_banks_deleted_at");

                    b.ToTable("banks", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("14207e5f-41b5-4884-ba3c-6b55f8af04bd"),
                            Name = "GT Bank"
                        },
                        new
                        {
                            Id = new Guid("a4344c8f-8b2f-4eb4-bc65-d3c5a6ae7e25"),
                            Name = "Zenith Bank"
                        },
                        new
                        {
                            Id = new Guid("522057c2-67da-40bf-9021-443e540d6cbc"),
                            Name = "First Bank"
                        });
                });

            modelBuilder.Entity("XClaim.Common.Entities.CategoryEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("TEXT")
                        .HasColumnName("company_id");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Description")
                        .HasMaxLength(1024)
                        .HasColumnType("TEXT")
                        .HasColumnName("description");

                    b.Property<string>("Icon")
                        .HasMaxLength(64)
                        .HasColumnType("TEXT")
                        .HasColumnName("icon");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("modified_at");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_categories");

                    b.HasIndex("CompanyId")
                        .HasDatabaseName("ix_categories_company_id");

                    b.HasIndex("DeletedAt")
                        .HasDatabaseName("ix_categories_deleted_at");

                    b.ToTable("categories", (string)null);
                });

            modelBuilder.Entity("XClaim.Common.Entities.ClaimEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT")
                        .HasColumnName("amount");

                    b.Property<DateTime?>("ApprovedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("approved_at");

                    b.Property<Guid?>("ApprovedById")
                        .HasColumnType("TEXT")
                        .HasColumnName("approved_by_id");

                    b.Property<Guid?>("CategoryId")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("category_id");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("TEXT")
                        .HasColumnName("company_id");

                    b.Property<DateTime?>("ConfirmedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("confirmed_at");

                    b.Property<Guid?>("ConfirmedById")
                        .HasColumnType("TEXT")
                        .HasColumnName("confirmed_by_id");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("TEXT")
                        .HasColumnName("description");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("modified_at");

                    b.Property<string>("Notes")
                        .HasMaxLength(1024)
                        .HasColumnType("TEXT")
                        .HasColumnName("notes");

                    b.Property<Guid?>("OwnerId")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("owner_id");

                    b.Property<Guid?>("PaymentId")
                        .HasColumnType("TEXT")
                        .HasColumnName("payment_id");

                    b.Property<DateTime?>("ReviewedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("reviewed_at");

                    b.Property<Guid?>("ReviewedById")
                        .HasColumnType("TEXT")
                        .HasColumnName("reviewed_by_id");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER")
                        .HasColumnName("status");

                    b.HasKey("Id")
                        .HasName("pk_claims");

                    b.HasIndex("ApprovedById")
                        .HasDatabaseName("ix_claims_approved_by_id");

                    b.HasIndex("CategoryId")
                        .HasDatabaseName("ix_claims_category_id");

                    b.HasIndex("CompanyId")
                        .HasDatabaseName("ix_claims_company_id");

                    b.HasIndex("ConfirmedById")
                        .HasDatabaseName("ix_claims_confirmed_by_id");

                    b.HasIndex("DeletedAt")
                        .HasDatabaseName("ix_claims_deleted_at");

                    b.HasIndex("OwnerId")
                        .HasDatabaseName("ix_claims_owner_id");

                    b.HasIndex("PaymentId")
                        .HasDatabaseName("ix_claims_payment_id");

                    b.HasIndex("ReviewedById")
                        .HasDatabaseName("ix_claims_reviewed_by_id");

                    b.ToTable("claims", (string)null);
                });

            modelBuilder.Entity("XClaim.Common.Entities.CommentEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<Guid?>("ClaimId")
                        .HasColumnType("TEXT")
                        .HasColumnName("claim_id");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("TEXT")
                        .HasColumnName("content");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("deleted_at");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("modified_at");

                    b.Property<Guid?>("OwnerId")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("owner_id");

                    b.Property<Guid?>("PaymentId")
                        .HasColumnType("TEXT")
                        .HasColumnName("payment_id");

                    b.HasKey("Id")
                        .HasName("pk_comments");

                    b.HasIndex("ClaimId")
                        .HasDatabaseName("ix_comments_claim_id");

                    b.HasIndex("DeletedAt")
                        .HasDatabaseName("ix_comments_deleted_at");

                    b.HasIndex("OwnerId")
                        .HasDatabaseName("ix_comments_owner_id");

                    b.HasIndex("PaymentId")
                        .HasDatabaseName("ix_comments_payment_id");

                    b.ToTable("comments", (string)null);
                });

            modelBuilder.Entity("XClaim.Common.Entities.CompanyEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("TEXT")
                        .HasColumnName("email");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("TEXT")
                        .HasColumnName("full_name");

                    b.Property<Guid?>("ManagerId")
                        .HasColumnType("TEXT")
                        .HasColumnName("manager_id");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("modified_at");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT")
                        .HasColumnName("short_name");

                    b.HasKey("Id")
                        .HasName("pk_companies");

                    b.HasIndex("DeletedAt")
                        .HasDatabaseName("ix_companies_deleted_at");

                    b.HasIndex("ManagerId")
                        .IsUnique()
                        .HasDatabaseName("ix_companies_manager_id");

                    b.ToTable("companies", (string)null);
                });

            modelBuilder.Entity("XClaim.Common.Entities.EventEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<Guid?>("ClaimId")
                        .HasColumnType("TEXT")
                        .HasColumnName("claim_id");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("TEXT")
                        .HasColumnName("description");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("modified_at");

                    b.Property<Guid?>("PaymentId")
                        .HasColumnType("TEXT")
                        .HasColumnName("payment_id");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER")
                        .HasColumnName("type");

                    b.HasKey("Id")
                        .HasName("pk_events");

                    b.HasIndex("ClaimId")
                        .HasDatabaseName("ix_events_claim_id");

                    b.HasIndex("DeletedAt")
                        .HasDatabaseName("ix_events_deleted_at");

                    b.HasIndex("PaymentId")
                        .HasDatabaseName("ix_events_payment_id");

                    b.ToTable("events", (string)null);
                });

            modelBuilder.Entity("XClaim.Common.Entities.FileEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<Guid?>("ClaimId")
                        .HasColumnType("TEXT")
                        .HasColumnName("claim_id");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Extension")
                        .HasMaxLength(8)
                        .HasColumnType("TEXT")
                        .HasColumnName("extension");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("modified_at");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("TEXT")
                        .HasColumnName("path");

                    b.HasKey("Id")
                        .HasName("pk_files");

                    b.HasIndex("ClaimId")
                        .HasDatabaseName("ix_files_claim_id");

                    b.HasIndex("DeletedAt")
                        .HasDatabaseName("ix_files_deleted_at");

                    b.ToTable("files", (string)null);
                });

            modelBuilder.Entity("XClaim.Common.Entities.PaymentEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT")
                        .HasColumnName("amount");

                    b.Property<DateTime?>("CompletedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("completed_at");

                    b.Property<Guid?>("CompletedById")
                        .HasColumnType("TEXT")
                        .HasColumnName("completed_by_id");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("deleted_at");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("modified_at");

                    b.Property<string>("Notes")
                        .HasMaxLength(512)
                        .HasColumnType("TEXT")
                        .HasColumnName("notes");

                    b.Property<Guid?>("OwnerId")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("owner_id");

                    b.HasKey("Id")
                        .HasName("pk_payments");

                    b.HasIndex("CompletedById")
                        .HasDatabaseName("ix_payments_completed_by_id");

                    b.HasIndex("DeletedAt")
                        .HasDatabaseName("ix_payments_deleted_at");

                    b.HasIndex("OwnerId")
                        .HasDatabaseName("ix_payments_owner_id");

                    b.ToTable("payments", (string)null);
                });

            modelBuilder.Entity("XClaim.Common.Entities.TeamEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("TEXT")
                        .HasColumnName("company_id");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("deleted_at");

                    b.Property<Guid?>("ManagerId")
                        .HasColumnType("TEXT")
                        .HasColumnName("manager_id");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("modified_at");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_teams");

                    b.HasIndex("CompanyId")
                        .HasDatabaseName("ix_teams_company_id");

                    b.HasIndex("DeletedAt")
                        .HasDatabaseName("ix_teams_deleted_at");

                    b.HasIndex("ManagerId")
                        .IsUnique()
                        .HasDatabaseName("ix_teams_manager_id");

                    b.ToTable("teams", (string)null);
                });

            modelBuilder.Entity("XClaim.Common.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<decimal>("Balance")
                        .HasColumnType("TEXT")
                        .HasColumnName("balance");

                    b.Property<Guid?>("BankAccountId")
                        .HasColumnType("TEXT")
                        .HasColumnName("bank_account_id");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("TEXT")
                        .HasColumnName("company_id");

                    b.Property<Guid?>("CompanyManagedId")
                        .HasColumnType("TEXT")
                        .HasColumnName("company_managed_id");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("TEXT")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("TEXT")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("TEXT")
                        .HasColumnName("last_name");

                    b.Property<Guid?>("ManagerId")
                        .HasColumnType("TEXT")
                        .HasColumnName("manager_id");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("modified_at");

                    b.Property<int>("Permission")
                        .HasColumnType("INTEGER")
                        .HasColumnName("permission");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT")
                        .HasColumnName("phone");

                    b.Property<Guid?>("TeamId")
                        .HasColumnType("TEXT")
                        .HasColumnName("team_id");

                    b.Property<Guid?>("TeamManagedId")
                        .HasColumnType("TEXT")
                        .HasColumnName("team_managed_id");

                    b.Property<string>("Token")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT")
                        .HasColumnName("token");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("TEXT")
                        .HasColumnName("user_name");

                    b.Property<bool>("Verified")
                        .HasColumnType("INTEGER")
                        .HasColumnName("verified");

                    b.HasKey("Id")
                        .HasName("pk_users");

                    b.HasIndex("CompanyId")
                        .HasDatabaseName("ix_users_company_id");

                    b.HasIndex("DeletedAt")
                        .HasDatabaseName("ix_users_deleted_at");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasDatabaseName("ix_users_email");

                    b.HasIndex("ManagerId")
                        .HasDatabaseName("ix_users_manager_id");

                    b.HasIndex("Phone")
                        .IsUnique()
                        .HasDatabaseName("ix_users_phone");

                    b.HasIndex("TeamId")
                        .HasDatabaseName("ix_users_team_id");

                    b.HasIndex("UserName")
                        .IsUnique()
                        .HasDatabaseName("ix_users_user_name");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("XClaim.Common.Entities.BankAccountEntity", b =>
                {
                    b.HasOne("XClaim.Common.Entities.BankEntity", "Bank")
                        .WithMany()
                        .HasForeignKey("BankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_bank_accounts_banks_bank_id");

                    b.HasOne("XClaim.Common.Entities.UserEntity", "Owner")
                        .WithOne("BankAccount")
                        .HasForeignKey("XClaim.Common.Entities.BankAccountEntity", "OwnerId")
                        .HasConstraintName("fk_bank_accounts_users_owner_id1");

                    b.Navigation("Bank");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("XClaim.Common.Entities.CategoryEntity", b =>
                {
                    b.HasOne("XClaim.Common.Entities.CompanyEntity", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .HasConstraintName("fk_categories_companies_company_id");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("XClaim.Common.Entities.ClaimEntity", b =>
                {
                    b.HasOne("XClaim.Common.Entities.UserEntity", "ApprovedBy")
                        .WithMany()
                        .HasForeignKey("ApprovedById")
                        .HasConstraintName("fk_claims_users_approved_by_id");

                    b.HasOne("XClaim.Common.Entities.CategoryEntity", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_claims_categories_category_id");

                    b.HasOne("XClaim.Common.Entities.CompanyEntity", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .HasConstraintName("fk_claims_companies_company_id");

                    b.HasOne("XClaim.Common.Entities.UserEntity", "ConfirmedBy")
                        .WithMany()
                        .HasForeignKey("ConfirmedById")
                        .HasConstraintName("fk_claims_users_confirmed_by_id");

                    b.HasOne("XClaim.Common.Entities.UserEntity", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_claims_users_owner_id");

                    b.HasOne("XClaim.Common.Entities.PaymentEntity", "Payment")
                        .WithMany("Claims")
                        .HasForeignKey("PaymentId")
                        .HasConstraintName("fk_claims_payments_payment_id");

                    b.HasOne("XClaim.Common.Entities.UserEntity", "ReviewedBy")
                        .WithMany()
                        .HasForeignKey("ReviewedById")
                        .HasConstraintName("fk_claims_users_reviewed_by_id");

                    b.Navigation("ApprovedBy");

                    b.Navigation("Category");

                    b.Navigation("Company");

                    b.Navigation("ConfirmedBy");

                    b.Navigation("Owner");

                    b.Navigation("Payment");

                    b.Navigation("ReviewedBy");
                });

            modelBuilder.Entity("XClaim.Common.Entities.CommentEntity", b =>
                {
                    b.HasOne("XClaim.Common.Entities.ClaimEntity", "Claim")
                        .WithMany("Comments")
                        .HasForeignKey("ClaimId")
                        .HasConstraintName("fk_comments_claims_claim_id");

                    b.HasOne("XClaim.Common.Entities.UserEntity", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_comments_users_owner_id");

                    b.HasOne("XClaim.Common.Entities.PaymentEntity", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentId")
                        .HasConstraintName("fk_comments_payments_payment_id");

                    b.Navigation("Claim");

                    b.Navigation("Owner");

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("XClaim.Common.Entities.CompanyEntity", b =>
                {
                    b.HasOne("XClaim.Common.Entities.UserEntity", "Manager")
                        .WithOne("CompanyManaged")
                        .HasForeignKey("XClaim.Common.Entities.CompanyEntity", "ManagerId")
                        .HasConstraintName("fk_companies_users_manager_id");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("XClaim.Common.Entities.EventEntity", b =>
                {
                    b.HasOne("XClaim.Common.Entities.ClaimEntity", "Claim")
                        .WithMany()
                        .HasForeignKey("ClaimId")
                        .HasConstraintName("fk_events_claims_claim_id");

                    b.HasOne("XClaim.Common.Entities.PaymentEntity", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentId")
                        .HasConstraintName("fk_events_payments_payment_id");

                    b.Navigation("Claim");

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("XClaim.Common.Entities.FileEntity", b =>
                {
                    b.HasOne("XClaim.Common.Entities.ClaimEntity", "Claim")
                        .WithMany("Files")
                        .HasForeignKey("ClaimId")
                        .HasConstraintName("fk_files_claims_claim_id");

                    b.Navigation("Claim");
                });

            modelBuilder.Entity("XClaim.Common.Entities.PaymentEntity", b =>
                {
                    b.HasOne("XClaim.Common.Entities.UserEntity", "CompletedBy")
                        .WithMany()
                        .HasForeignKey("CompletedById")
                        .HasConstraintName("fk_payments_users_completed_by_id");

                    b.HasOne("XClaim.Common.Entities.UserEntity", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_payments_users_owner_id");

                    b.Navigation("CompletedBy");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("XClaim.Common.Entities.TeamEntity", b =>
                {
                    b.HasOne("XClaim.Common.Entities.CompanyEntity", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .HasConstraintName("fk_teams_companies_company_id");

                    b.HasOne("XClaim.Common.Entities.UserEntity", "Manager")
                        .WithOne("TeamManaged")
                        .HasForeignKey("XClaim.Common.Entities.TeamEntity", "ManagerId")
                        .HasConstraintName("fk_teams_users_manager_id");

                    b.Navigation("Company");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("XClaim.Common.Entities.UserEntity", b =>
                {
                    b.HasOne("XClaim.Common.Entities.CompanyEntity", "Company")
                        .WithMany("Members")
                        .HasForeignKey("CompanyId")
                        .HasConstraintName("fk_users_companies_company_id");

                    b.HasOne("XClaim.Common.Entities.UserEntity", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId")
                        .HasConstraintName("fk_users_users_manager_id");

                    b.HasOne("XClaim.Common.Entities.TeamEntity", "Team")
                        .WithMany("Members")
                        .HasForeignKey("TeamId")
                        .HasConstraintName("fk_users_teams_team_id");

                    b.Navigation("Company");

                    b.Navigation("Manager");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("XClaim.Common.Entities.ClaimEntity", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Files");
                });

            modelBuilder.Entity("XClaim.Common.Entities.CompanyEntity", b =>
                {
                    b.Navigation("Members");
                });

            modelBuilder.Entity("XClaim.Common.Entities.PaymentEntity", b =>
                {
                    b.Navigation("Claims");
                });

            modelBuilder.Entity("XClaim.Common.Entities.TeamEntity", b =>
                {
                    b.Navigation("Members");
                });

            modelBuilder.Entity("XClaim.Common.Entities.UserEntity", b =>
                {
                    b.Navigation("BankAccount");

                    b.Navigation("CompanyManaged");

                    b.Navigation("TeamManaged");
                });
#pragma warning restore 612, 618
        }
    }
}
