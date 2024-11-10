using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatalogApi.Migrations
{
    /// <inheritdoc />
    public partial class PopulateCategoriesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Categories(Name, ImageUrl) VALUES('drink', 'drink.jpg')");
            mb.Sql("INSERT INTO Categories(Name, ImageUrl) VALUES('snack', 'snack.jpg')");
            mb.Sql("INSERT INTO Categories(Name, ImageUrl) VALUES('dessert', 'UserId.jpg')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Categories");
        }
    }
}
