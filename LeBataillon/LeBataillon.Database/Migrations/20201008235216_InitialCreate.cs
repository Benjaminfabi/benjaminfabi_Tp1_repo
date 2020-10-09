using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeBataillon.Database.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(nullable: false),
                    CaptainId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameDateTime = table.Column<DateTime>(nullable: false),
                    TeamDefendantId = table.Column<int>(nullable: true),
                    TeamAttackerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_Teams_TeamAttackerId",
                        column: x => x.TeamAttackerId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Games_Teams_TeamDefendantId",
                        column: x => x.TeamDefendantId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NickName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Level = table.Column<int>(nullable: false),
                    TeamId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Level", "NickName", "PhoneNumber", "TeamId" },
                values: new object[,]
                {
                    { 1, "Adrian@bataillonMail.com", "Krissy", "Jonkruojis", 0, "AdrianAlias", "214-764-3816", null },
                    { 72, "Ralph@bataillonMail.com", "Arielle", "Vadtälje", 0, "RalphAlias", "381-864-2587", null },
                    { 71, "Jamal@bataillonMail.com", "Ralph", "Nuugaatrapaluk", 0, "JamalAlias", "764-635-6174", null },
                    { 70, "Pat@bataillonMail.com", "Jamal", "Steinstrand", 0, "PatAlias", "336-476-3561", null },
                    { 69, "Krissy@bataillonMail.com", "Pat", "Reidcoln", 0, "KrissyAlias", "718-337-7156", null },
                    { 68, "Adrian@bataillonMail.com", "Krissy", "Jonkruojis", 0, "AdrianAlias", "373-188-3543", null },
                    { 67, "Johana@bataillonMail.com", "Adrian", "Enbo", 0, "JohanaAlias", "645-741-8138", null },
                    { 66, "Debi@bataillonMail.com", "Johana", "Jaunli", 0, "DebiAlias", "228-612-4525", null },
                    { 65, "Sheridan@bataillonMail.com", "Debi", "Hammervåg", 0, "SheridanAlias", "682-453-1112", null },
                    { 64, "Pierre@bataillonMail.com", "Sheridan", "Akssandur", 0, "PierreAlias", "255-214-5587", null },
                    { 63, "Tyson@bataillonMail.com", "Pierre", "Balniai", 0, "TysonAlias", "637-165-2175", null },
                    { 62, "Antonetta@bataillonMail.com", "Tyson", "Rovanola", 0, "AntonettaAlias", "111-726-6562", null },
                    { 61, "Sherlene@bataillonMail.com", "Antonetta", "Salkile", 0, "SherleneAlias", "564-567-2157", null },
                    { 60, "Marcella@bataillonMail.com", "Sherlene", "Kalvee", 0, "MarcellaAlias", "146-338-7544", null },
                    { 59, "Jane@bataillonMail.com", "Marcella", "Ólafsholt", 0, "JaneAlias", "521-271-3131", null },
                    { 58, "Mariella@bataillonMail.com", "Jane", "Dragstrup", 0, "MariellaAlias", "173-842-8526", null },
                    { 57, "Marcie@bataillonMail.com", "Mariella", "Nittinen", 0, "MarcieAlias", "555-683-4113", null },
                    { 56, "Liliana@bataillonMail.com", "Marcie", "Boswood", 0, "LilianaAlias", "828-544-8588", null },
                    { 55, "Alejandro@bataillonMail.com", "Liliana", "Mõisali", 0, "AlejandroAlias", "482-315-5175", null },
                    { 54, "Roma@bataillonMail.com", "Alejandro", "Guasabaro", 0, "RomaAlias", "865-156-1562", null },
                    { 53, "Vi@bataillonMail.com", "Roma", "Ulhus", 0, "ViAlias", "437-728-6157", null },
                    { 52, "Tad@bataillonMail.com", "Vi", "Ixtatla", 0, "TadAlias", "811-661-2544", null },
                    { 73, "Arielle@bataillonMail.com", "Troy", "Eqalunavik", 0, "ArielleAlias", "727-223-5112", null },
                    { 51, "Troy@bataillonMail.com", "Tad", "Norrviken", 0, "TroyAlias", "374-422-7131", null },
                    { 74, "Troy@bataillonMail.com", "Marcell", "Lystrup", 0, "TroyAlias", "454-352-1525", null },
                    { 76, "Simonne@bataillonMail.com", "Sherise", "Haapsa", 0, "SimonneAlias", "418-758-8543", null },
                    { 97, "Steven@bataillonMail.com", "Roma", "Ulhus", 0, "StevenAlias", "435-313-3181", null },
                    { 96, "Tad@bataillonMail.com", "Steven", "Eqalunavik", 0, "TadAlias", "887-154-8576", null },
                    { 95, "Emely@bataillonMail.com", "Tad", "Norrviken", 0, "EmelyAlias", "362-715-4163", null },
                    { 94, "Jamal@bataillonMail.com", "Emely", "Nuugaatrapaluk", 0, "JamalAlias", "744-566-1558", null },
                    { 93, "Cathryn@bataillonMail.com", "Jamal", "Breksos", 0, "CathrynAlias", "317-427-5145", null },
                    { 92, "Eugenie@bataillonMail.com", "Cathryn", "Reidcoln", 0, "EugenieAlias", "771-268-2532", null },
                    { 91, "Marlon@bataillonMail.com", "Eugenie", "Lazmerge", 0, "MarlonAlias", "354-831-6127", null },
                    { 90, "Ernestine@bataillonMail.com", "Marlon", "Clarehurst", 0, "ErnestineAlias", "626-772-2514", null },
                    { 89, "Debi@bataillonMail.com", "Ernestine", "Kulli", 0, "DebiAlias", "288-543-7181", null },
                    { 88, "Leida@bataillonMail.com", "Debi", "Kungstuna", 0, "LeidaAlias", "663-384-3576", null },
                    { 87, "Derick@bataillonMail.com", "Leida", "Ísafholt", 0, "DerickAlias", "235-245-8163", null },
                    { 86, "Bianca@bataillonMail.com", "Derick", "Brønnøyden", 0, "BiancaAlias", "618-816-4558", null },
                    { 85, "Nicholas@bataillonMail.com", "Bianca", "Rovanola", 0, "NicholasAlias", "272-657-8145", null },
                    { 84, "Sherlene@bataillonMail.com", "Nicholas", "Kedainkai", 0, "SherleneAlias", "544-428-5532", null },
                    { 83, "Conrad@bataillonMail.com", "Sherlene", "Kalvee", 0, "ConradAlias", "127-361-1128", null },
                    { 82, "Berniece@bataillonMail.com", "Conrad", "Ketne", 0, "BernieceAlias", "581-122-6515", null },
                    { 81, "Tonita@bataillonMail.com", "Berniece", "Dragstrup", 0, "TonitaAlias", "154-773-2182", null },
                    { 80, "Sheryl@bataillonMail.com", "Tonita", "Hókrókur", 0, "SherylAlias", "536-634-7577", null },
                    { 79, "Liliana@bataillonMail.com", "Sheryl", "Boswood", 0, "LilianaAlias", "888-475-3174", null },
                    { 78, "Angelina@bataillonMail.com", "Liliana", "Kalatee", 0, "AngelinaAlias", "463-246-7561", null },
                    { 77, "Sherise@bataillonMail.com", "Angelina", "Guasabaro", 0, "SheriseAlias", "845-887-4156", null },
                    { 75, "Marcell@bataillonMail.com", "Simonne", "Apatcruz", 0, "MarcellAlias", "872-511-5138", null },
                    { 98, "Roma@bataillonMail.com", "Simonne", "Apatcruz", 0, "RomaAlias", "853-442-7514", null },
                    { 50, "Eugenio@bataillonMail.com", "Troy", "Uummanqaq", 0, "EugenioAlias", "746-273-3526", null },
                    { 48, "Palmira@bataillonMail.com", "Cathryn", "Flatwood", 0, "PalmiraAlias", "783-785-4588", null },
                    { 22, "Debi@bataillonMail.com", "Ernestine", "Kulli", 0, "DebiAlias", "232-327-7464", null },
                    { 21, "Leida@bataillonMail.com", "Debi", "Hammervåg", 0, "LeidaAlias", "684-168-3851", null },
                    { 20, "Derick@bataillonMail.com", "Leida", "Ísafholt", 0, "DerickAlias", "266-721-7446", null },
                    { 19, "Tyson@bataillonMail.com", "Derick", "Brønnøyden", 0, "TysonAlias", "641-572-4833", null },
                    { 18, "Nicholas@bataillonMail.com", "Tyson", "Rovanola", 0, "NicholasAlias", "213-433-8428", null },
                    { 17, "Sherlene@bataillonMail.com", "Nicholas", "Kedainkai", 0, "SherleneAlias", "576-284-5815", null },
                    { 16, "Conrad@bataillonMail.com", "Sherlene", "Kalvee", 0, "ConradAlias", "158-845-1482", null },
                    { 15, "Berniece@bataillonMail.com", "Conrad", "Ketne", 0, "BernieceAlias", "523-786-6877", null },
                    { 14, "Mariella@bataillonMail.com", "Berniece", "Dragstrup", 0, "MariellaAlias", "185-557-2464", null },
                    { 13, "Sheryl@bataillonMail.com", "Mariella", "Hókrókur", 0, "SherylAlias", "567-318-6851", null },
                    { 12, "Liliana@bataillonMail.com", "Sheryl", "Boswood", 0, "LilianaAlias", "832-151-3446", null },
                    { 11, "Angelina@bataillonMail.com", "Liliana", "Kalatee", 0, "AngelinaAlias", "414-822-7833", null },
                    { 10, "Sherise@bataillonMail.com", "Angelina", "Guasabaro", 0, "SheriseAlias", "877-663-4428", null },
                    { 9, "Vi@bataillonMail.com", "Sherise", "Haapsa", 0, "ViAlias", "441-434-8815", null },
                    { 8, "Marcell@bataillonMail.com", "Vi", "Ixtatla", 0, "MarcellAlias", "823-375-4482", null },
                    { 7, "Troy@bataillonMail.com", "Marcell", "Lystrup", 0, "TroyAlias", "476-136-1877", null },
                    { 6, "Arielle@bataillonMail.com", "Troy", "Eqalunavik", 0, "ArielleAlias", "758-787-5464", null },
                    { 5, "Ralph@bataillonMail.com", "Arielle", "Vadtälje", 0, "RalphAlias", "333-648-2851", null },
                    { 4, "Palmira@bataillonMail.com", "Ralph", "Nuugaatrapaluk", 0, "PalmiraAlias", "785-411-6446", null },
                    { 3, "Pat@bataillonMail.com", "Palmira", "Steinstrand", 0, "PatAlias", "367-252-3834", null },
                    { 2, "Krissy@bataillonMail.com", "Pat", "Reidcoln", 0, "KrissyAlias", "742-813-7421", null },
                    { 23, "Ernestine@bataillonMail.com", "Adrian", "Enbo", 0, "ErnestineAlias", "657-456-2877", null },
                    { 49, "Cathryn@bataillonMail.com", "Eugenio", "Breksos", 0, "CathrynAlias", "321-134-7113", null },
                    { 24, "Adrian@bataillonMail.com", "Eugenie", "Lazmerge", 0, "AdrianAlias", "375-615-6481", null },
                    { 26, "Cathryn@bataillonMail.com", "Jamal", "Breksos", 0, "CathrynAlias", "348-183-5427", null },
                    { 47, "Marlon@bataillonMail.com", "Palmira", "Steinstrand", 0, "MarlonAlias", "355-546-8175", null },
                    { 46, "Krissy@bataillonMail.com", "Marlon", "Clarehurst", 0, "KrissyAlias", "738-487-5562", null },
                    { 45, "Rosetta@bataillonMail.com", "Krissy", "Jonkruojis", 0, "RosettaAlias", "212-258-1157", null },
                    { 44, "Leida@bataillonMail.com", "Rosetta", "Kungstuna", 0, "LeidaAlias", "665-811-5544", null },
                    { 43, "Barbie@bataillonMail.com", "Leida", "Jaunli", 0, "BarbieAlias", "247-652-2132", null },
                    { 42, "Bianca@bataillonMail.com", "Barbie", "Brønnøyden", 0, "BiancaAlias", "622-523-6527", null },
                    { 41, "Pierre@bataillonMail.com", "Bianca", "Akssandur", 0, "PierreAlias", "274-364-3114", null },
                    { 40, "Adell@bataillonMail.com", "Pierre", "Kedainkai", 0, "AdellAlias", "556-135-7581", null },
                    { 39, "Conrad@bataillonMail.com", "Adell", "Siukoski", 0, "ConradAlias", "131-876-4176", null },
                    { 38, "Dina@bataillonMail.com", "Conrad", "Ketne", 0, "DinaAlias", "583-637-8563", null },
                    { 37, "Tonita@bataillonMail.com", "Dina", "Loktu", 0, "TonitaAlias", "166-488-4158", null },
                    { 36, "Jane@bataillonMail.com", "Tonita", "Hókrókur", 0, "JaneAlias", "548-241-1545", null },
                    { 35, "Magen@bataillonMail.com", "Jane", "Albro", 0, "MagenAlias", "112-112-5132", null },
                    { 34, "Angelina@bataillonMail.com", "Magen", "Nittinen", 0, "AngelinaAlias", "475-753-2427", null },
                    { 33, "Jeanetta@bataillonMail.com", "Angelina", "Mensmere", 0, "JeanettaAlias", "857-514-6814", null },
                    { 32, "Simonne@bataillonMail.com", "Jeanetta", "Mõisali", 0, "SimonneAlias", "422-465-2481", null },
                    { 31, "Roma@bataillonMail.com", "Simonne", "Apatcruz", 0, "RomaAlias", "884-226-7876", null },
                    { 30, "Steven@bataillonMail.com", "Roma", "Ulhus", 0, "StevenAlias", "456-877-3463", null },
                    { 29, "Arielle@bataillonMail.com", "Steven", "Eqalunavik", 0, "ArielleAlias", "831-638-8858", null },
                    { 28, "Emely@bataillonMail.com", "Arielle", "Norrviken", 0, "EmelyAlias", "313-571-4445", null },
                    { 27, "Jamal@bataillonMail.com", "Emely", "Nuugaatrapaluk", 0, "JamalAlias", "766-342-1832", null },
                    { 25, "Eugenie@bataillonMail.com", "Cathryn", "Reidcoln", 0, "EugenieAlias", "722-844-1814", null },
                    { 99, "Simonne@bataillonMail.com", "Jeanetta", "Mõisali", 0, "SimonneAlias", "478-681-3127", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_TeamAttackerId",
                table: "Games",
                column: "TeamAttackerId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_TeamDefendantId",
                table: "Games",
                column: "TeamDefendantId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamId",
                table: "Players",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_CaptainId",
                table: "Teams",
                column: "CaptainId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Players_CaptainId",
                table: "Teams",
                column: "CaptainId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Teams_TeamId",
                table: "Players");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
