using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PureFood.Data.Migrations
{
    /// <inheritdoc />
    public partial class addRelationshipbetweenOrderAndPromotion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PromotionId",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PromotionId",
                table: "Orders",
                column: "PromotionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Promotions_PromotionId",
                table: "Orders",
                column: "PromotionId",
                principalTable: "Promotions",
                principalColumn: "PromotionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Promotions_PromotionId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_PromotionId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PromotionId",
                table: "Orders");
        }
    }
}
