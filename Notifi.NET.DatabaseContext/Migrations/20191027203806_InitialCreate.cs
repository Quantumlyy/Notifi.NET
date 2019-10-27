using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Notifi.NET.DatabaseContext.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TowicchoSubscriptions",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    twitch_id = table.Column<string>(nullable: false),
                    streaming_status = table.Column<bool>(nullable: false),
                    at_creat = table.Column<DateTime>(nullable: false),
                    at_fetch = table.Column<DateTime>(nullable: false),
                    at_expire = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TowicchoSubscriptions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TowicchoSubscriberGuild",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    guild_id = table.Column<string>(nullable: false),
                    channel_id = table.Column<string>(nullable: false),
                    subscribing_user_id = table.Column<string>(nullable: false),
                    game_whitelist = table.Column<List<string>>(nullable: false),
                    game_blacklist = table.Column<List<string>>(nullable: false),
                    notification_offline = table.Column<bool>(nullable: false),
                    embed_hash = table.Column<string>(nullable: false),
                    language = table.Column<int>(nullable: false),
                    TowicchoSubscriptionID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TowicchoSubscriberGuild", x => x.id);
                    table.ForeignKey(
                        name: "FK_TowicchoSubscriberGuild_TowicchoSubscriptions_TowicchoSubsc~",
                        column: x => x.TowicchoSubscriptionID,
                        principalTable: "TowicchoSubscriptions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TowicchoSubscriberGuild_TowicchoSubscriptionID",
                table: "TowicchoSubscriberGuild",
                column: "TowicchoSubscriptionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TowicchoSubscriberGuild");

            migrationBuilder.DropTable(
                name: "TowicchoSubscriptions");
        }
    }
}
