using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SampleEcommerce.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "A telephone directory, commonly called a telephone book, telephone address book, phonebook, or the white and yellow pages, is a listing of telephone subscribers in a geographical area or subscribers to services provided by the organization that publishes the directory. Its purpose is to allow the telephone number of a subscriber identified by name and address to be found.", "https://upload.wikimedia.org/wikipedia/commons/thumb/6/63/Unused_Phonebooks.JPG/330px-Unused_Phonebooks.JPG", 9.99m, "Telephone directory" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "A telephone directory, commonly called a telephone book, telephone address book, phonebook, or the white and yellow pages, is a listing of telephone subscribers in a geographical area or subscribers to services provided by the organization that publishes the directory. Its purpose is to allow the telephone number of a subscriber identified by name and address to be found.", "https://upload.wikimedia.org/wikipedia/commons/thumb/6/63/Unused_Phonebooks.JPG/330px-Unused_Phonebooks.JPG", 9.99m, "Telephone directory" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
