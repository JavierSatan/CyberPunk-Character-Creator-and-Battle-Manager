using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CyberPunk2020.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Round = table.Column<int>(type: "int", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecialAbility = table.Column<int>(type: "int", nullable: true),
                    SpecialAbilityLvl = table.Column<int>(type: "int", nullable: true),
                    WildernessSurvival = table.Column<int>(type: "int", nullable: true),
                    PersonalGrooming = table.Column<int>(type: "int", nullable: true),
                    WardrobeAndStyle = table.Column<int>(type: "int", nullable: true),
                    Endurance = table.Column<int>(type: "int", nullable: true),
                    StrengthFeat = table.Column<int>(type: "int", nullable: true),
                    Swimming = table.Column<int>(type: "int", nullable: true),
                    Interrogation = table.Column<int>(type: "int", nullable: true),
                    Intimidate = table.Column<int>(type: "int", nullable: true),
                    Oratory = table.Column<int>(type: "int", nullable: true),
                    ResistTortureOrDrugs = table.Column<int>(type: "int", nullable: true),
                    Streetwise = table.Column<int>(type: "int", nullable: true),
                    HumanPerception = table.Column<int>(type: "int", nullable: true),
                    Interview = table.Column<int>(type: "int", nullable: true),
                    Leadership = table.Column<int>(type: "int", nullable: true),
                    Social = table.Column<int>(type: "int", nullable: true),
                    PersuasionAndFastTalk = table.Column<int>(type: "int", nullable: true),
                    Perform = table.Column<int>(type: "int", nullable: true),
                    Seduction = table.Column<int>(type: "int", nullable: true),
                    Accounting = table.Column<int>(type: "int", nullable: true),
                    Anthropology = table.Column<int>(type: "int", nullable: true),
                    AwarenessOrNotice = table.Column<int>(type: "int", nullable: true),
                    Biology = table.Column<int>(type: "int", nullable: true),
                    Botany = table.Column<int>(type: "int", nullable: true),
                    Chemistry = table.Column<int>(type: "int", nullable: true),
                    Composition = table.Column<int>(type: "int", nullable: true),
                    DiagnoseIllness = table.Column<int>(type: "int", nullable: true),
                    EducationAndGeneralKnowledge = table.Column<int>(type: "int", nullable: true),
                    Expert = table.Column<int>(type: "int", nullable: true),
                    Gamble = table.Column<int>(type: "int", nullable: true),
                    Geology = table.Column<int>(type: "int", nullable: true),
                    HideOrEvade = table.Column<int>(type: "int", nullable: true),
                    History = table.Column<int>(type: "int", nullable: true),
                    KnowLanguages = table.Column<int>(type: "int", nullable: true),
                    LibrarySearch = table.Column<int>(type: "int", nullable: true),
                    Mathematics = table.Column<int>(type: "int", nullable: true),
                    Physics = table.Column<int>(type: "int", nullable: true),
                    Programming = table.Column<int>(type: "int", nullable: true),
                    ShadowOrTrack = table.Column<int>(type: "int", nullable: true),
                    StockMarket = table.Column<int>(type: "int", nullable: true),
                    SystemKnowledge = table.Column<int>(type: "int", nullable: true),
                    Teaching = table.Column<int>(type: "int", nullable: true),
                    Zoology = table.Column<int>(type: "int", nullable: true),
                    WeaponsTech = table.Column<int>(type: "int", nullable: true),
                    Archery = table.Column<int>(type: "int", nullable: true),
                    Athletic = table.Column<int>(type: "int", nullable: true),
                    Brawling = table.Column<int>(type: "int", nullable: true),
                    Dance = table.Column<int>(type: "int", nullable: true),
                    DodgeAndEscape = table.Column<int>(type: "int", nullable: true),
                    Driving = table.Column<int>(type: "int", nullable: true),
                    Fencing = table.Column<int>(type: "int", nullable: true),
                    Handgun = table.Column<int>(type: "int", nullable: true),
                    HeavyWeapons = table.Column<int>(type: "int", nullable: true),
                    MartialArts = table.Column<int>(type: "int", nullable: true),
                    Melee = table.Column<int>(type: "int", nullable: true),
                    Motorcycle = table.Column<int>(type: "int", nullable: true),
                    OperateHeavyMachinery = table.Column<int>(type: "int", nullable: true),
                    PilotGyro = table.Column<int>(type: "int", nullable: true),
                    PilotFixedWing = table.Column<int>(type: "int", nullable: true),
                    PilotDirigible = table.Column<int>(type: "int", nullable: true),
                    PilotVectThrustVehicle = table.Column<int>(type: "int", nullable: true),
                    Rifle = table.Column<int>(type: "int", nullable: true),
                    Stealth = table.Column<int>(type: "int", nullable: true),
                    Submachinegun = table.Column<int>(type: "int", nullable: true),
                    AeroTech = table.Column<int>(type: "int", nullable: true),
                    AVTech = table.Column<int>(type: "int", nullable: true),
                    BasicTech = table.Column<int>(type: "int", nullable: true),
                    CryotankOperation = table.Column<int>(type: "int", nullable: true),
                    CyberdeckDesign = table.Column<int>(type: "int", nullable: true),
                    CyberTech = table.Column<int>(type: "int", nullable: true),
                    Demolitions = table.Column<int>(type: "int", nullable: true),
                    Disguise = table.Column<int>(type: "int", nullable: true),
                    Electronics = table.Column<int>(type: "int", nullable: true),
                    ElectSecurity = table.Column<int>(type: "int", nullable: true),
                    FirstAid = table.Column<int>(type: "int", nullable: true),
                    Forgery = table.Column<int>(type: "int", nullable: true),
                    GyroTech = table.Column<int>(type: "int", nullable: true),
                    PaintOrDraw = table.Column<int>(type: "int", nullable: true),
                    PhotoAndFilm = table.Column<int>(type: "int", nullable: true),
                    Pharmaceuticals = table.Column<int>(type: "int", nullable: true),
                    PickLock = table.Column<int>(type: "int", nullable: true),
                    PickPocket = table.Column<int>(type: "int", nullable: true),
                    PlayInstrument = table.Column<int>(type: "int", nullable: true),
                    Weaponsmith = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    INT = table.Column<int>(type: "int", nullable: false),
                    REF = table.Column<int>(type: "int", nullable: false),
                    TECH = table.Column<int>(type: "int", nullable: false),
                    COOL = table.Column<int>(type: "int", nullable: false),
                    ATTR = table.Column<int>(type: "int", nullable: false),
                    LUCK = table.Column<int>(type: "int", nullable: false),
                    MA = table.Column<int>(type: "int", nullable: false),
                    BODY = table.Column<int>(type: "int", nullable: false),
                    EMP = table.Column<int>(type: "int", nullable: false),
                    Humanity = table.Column<int>(type: "int", nullable: false),
                    Run = table.Column<int>(type: "int", nullable: false),
                    Leap = table.Column<double>(type: "float", nullable: false),
                    Lift = table.Column<int>(type: "int", nullable: false),
                    Carry = table.Column<int>(type: "int", nullable: false),
                    Save = table.Column<int>(type: "int", nullable: false),
                    BTM = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Npc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HP = table.Column<int>(type: "int", nullable: true),
                    BTM = table.Column<int>(type: "int", nullable: true),
                    GameId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Npc", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Npc_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HP = table.Column<int>(type: "int", nullable: true),
                    BTM = table.Column<int>(type: "int", nullable: true),
                    GameId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatPoints = table.Column<int>(type: "int", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    StatstId = table.Column<int>(type: "int", nullable: true),
                    SkillId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Characters_Statuses_StatstId",
                        column: x => x.StatstId,
                        principalTable: "Statuses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_SkillId",
                table: "Characters",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_StatstId",
                table: "Characters",
                column: "StatstId");

            migrationBuilder.CreateIndex(
                name: "IX_Npc_GameId",
                table: "Npc",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_GameId",
                table: "Players",
                column: "GameId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Npc");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
