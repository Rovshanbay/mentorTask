using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mentorTask.Migrations
{
    public partial class AddedPricingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PricingOffers_pricings_PricingId",
                table: "PricingOffers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pricings",
                table: "pricings");

            migrationBuilder.RenameTable(
                name: "pricings",
                newName: "Pricing");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pricing",
                table: "Pricing",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PricingOffers_Pricing_PricingId",
                table: "PricingOffers",
                column: "PricingId",
                principalTable: "Pricing",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PricingOffers_Pricing_PricingId",
                table: "PricingOffers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pricing",
                table: "Pricing");

            migrationBuilder.RenameTable(
                name: "Pricing",
                newName: "pricings");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pricings",
                table: "pricings",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PricingOffers_pricings_PricingId",
                table: "PricingOffers",
                column: "PricingId",
                principalTable: "pricings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
