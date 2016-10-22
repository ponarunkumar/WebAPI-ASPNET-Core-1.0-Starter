using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using dotnet_core_web_api.Controllers;

namespace dotnetcorewebapi.Migrations
{
    [DbContext(typeof(ActionDbContext))]
    partial class ActionDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("dotnet_core_web_api.Models.ActionItem", b =>
                {
                    b.Property<int>("ActionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ActionDesc");

                    b.Property<DateTime>("ActionDueDate");

                    b.HasKey("ActionId");

                    b.ToTable("ActionItems");
                });
        }
    }
}
