using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeautyShop.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddNewPropertyToProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductReview_Product_ProductEntityId",
                table: "ProductReview");

            migrationBuilder.DropIndex(
                name: "IX_ProductReview_ProductEntityId",
                table: "ProductReview");

            migrationBuilder.DropColumn(
                name: "ProductEntityId",
                table: "ProductReview");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ProductReview",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProductReview_ProductId",
                table: "ProductReview",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductReview_Product_ProductId",
                table: "ProductReview",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductReview_Product_ProductId",
                table: "ProductReview");

            migrationBuilder.DropIndex(
                name: "IX_ProductReview_ProductId",
                table: "ProductReview");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductReview");

            migrationBuilder.AddColumn<int>(
                name: "ProductEntityId",
                table: "ProductReview",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductReview_ProductEntityId",
                table: "ProductReview",
                column: "ProductEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductReview_Product_ProductEntityId",
                table: "ProductReview",
                column: "ProductEntityId",
                principalTable: "Product",
                principalColumn: "Id");
        }
    }
}
