using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CookBookWebSQL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.CreateTable(
            //     name: "Categories",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Categories", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "Cuisines",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Cuisines", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "Recipes",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //         Instructions = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //         CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         CuisineId = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Recipes", x => x.Id);
            //         table.ForeignKey(
            //             name: "FK_Recipes_Cuisines_CuisineId",
            //             column: x => x.CuisineId,
            //             principalTable: "Cuisines",
            //             principalColumn: "Id");
            //     });

            // migrationBuilder.CreateTable(
            //     name: "CategoryRecipe",
            //     columns: table => new
            //     {
            //         CategoriesId = table.Column<int>(type: "int", nullable: false),
            //         RecipesId = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_CategoryRecipe", x => new { x.CategoriesId, x.RecipesId });
            //         table.ForeignKey(
            //             name: "FK_CategoryRecipe_Categories_CategoriesId",
            //             column: x => x.CategoriesId,
            //             principalTable: "Categories",
            //             principalColumn: "Id",
            //             onDelete: ReferentialAction.Cascade);
            //         table.ForeignKey(
            //             name: "FK_CategoryRecipe_Recipes_RecipesId",
            //             column: x => x.RecipesId,
            //             principalTable: "Recipes",
            //             principalColumn: "Id",
            //             onDelete: ReferentialAction.Cascade);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "RecipeImages",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //         RecipeId = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_RecipeImages", x => x.Id);
            //         table.ForeignKey(
            //             name: "FK_RecipeImages_Recipes_RecipeId",
            //             column: x => x.RecipeId,
            //             principalTable: "Recipes",
            //             principalColumn: "Id");
            //     });

            // migrationBuilder.CreateIndex(
            //     name: "IX_CategoryRecipe_RecipesId",
            //     table: "CategoryRecipe",
            //     column: "RecipesId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_RecipeImages_RecipeId",
            //     table: "RecipeImages",
            //     column: "RecipeId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Recipes_CuisineId",
            //     table: "Recipes",
            //     column: "CuisineId");
        }

        /// <inheritdoc />
        // protected override void Down(MigrationBuilder migrationBuilder)
        // {
        //     migrationBuilder.DropTable(
        //         name: "CategoryRecipe");

        //     migrationBuilder.DropTable(
        //         name: "RecipeImages");

        //     migrationBuilder.DropTable(
        //         name: "Categories");

        //     migrationBuilder.DropTable(
        //         name: "Recipes");

        //     migrationBuilder.DropTable(
        //         name: "Cuisines");
        // }
    }
}
