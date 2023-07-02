using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZaferTurizm.DataAccess.Migrations
{
    public partial class SeedDataAddCity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "Adıyaman" },
                    { 3, "Afyonkarahisar" },
                    { 4, "Ağrı" },
                    { 5, "Amasya" },
                    { 8, "Artvin" },
                    { 9, "Aydın" },
                    { 10, "Balıkesir" },
                    { 11, "Bilecik" },
                    { 12, "Bingöl" },
                    { 13, "Bitlis" },
                    { 14, "Bolu" },
                    { 15, "Burdur" },
                    { 17, "Çanakkale" },
                    { 18, "Çankırı" },
                    { 19, "Çorum" },
                    { 20, "Denizli" },
                    { 21, "Diyarbakır" },
                    { 22, "Edirne" },
                    { 23, "Elazığ" },
                    { 24, "Erzincan" },
                    { 25, "Erzurum" },
                    { 26, "Eskişehir" },
                    { 27, "Gaziantep" },
                    { 28, "Giresun" },
                    { 29, "Gümüşhane" },
                    { 30, "Hakkari" },
                    { 31, "Hatay" },
                    { 32, "Isparta" },
                    { 33, "Mersin" },
                    { 36, "Kars" },
                    { 37, "Kastamonu" },
                    { 38, "Kayseri" },
                    { 39, "Kırklareli" },
                    { 40, "Kırşehir" },
                    { 41, "Kocaeli" },
                    { 42, "Konya" },
                    { 43, "Kütahya" },
                    { 44, "Malatya" },
                    { 45, "Manisa" },
                    { 46, "Kahramanmaraş" },
                    { 47, "Mardin" },
                    { 48, "Muğla" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 49, "Muş" },
                    { 50, "Nevşehir" },
                    { 51, "Niğde" },
                    { 52, "Ordu" },
                    { 53, "Rize" },
                    { 54, "Sakarya" },
                    { 55, "Samsun" },
                    { 56, "Siirt" },
                    { 57, "Sinop" },
                    { 58, "Sivas" },
                    { 59, "Tekirdağ" },
                    { 60, "Tokat" },
                    { 61, "Trabzon" },
                    { 62, "Tunceli" },
                    { 63, "Şanlıurfa" },
                    { 64, "Uşak" },
                    { 65, "Van" },
                    { 66, "Yozgat" },
                    { 67, "Zonguldak" },
                    { 68, "Aksaray" },
                    { 69, "Bayburt" },
                    { 70, "Karaman" },
                    { 71, "Kırıkkale" },
                    { 72, "Batman" },
                    { 73, "Şırnak" },
                    { 74, "Bartın" },
                    { 75, "Ardahan" },
                    { 76, "Iğdır" },
                    { 77, "Yalova" },
                    { 78, "Karabük" },
                    { 79, "Kilis" },
                    { 80, "Osmaniye" },
                    { 81, "Düzce" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 81);
        }
    }
}
