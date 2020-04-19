using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StardewValleyAPI.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Level = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false),
                    Location = table.Column<string>(maxLength: 100, nullable: false),
                    CriticalStrikeChance = table.Column<string>(maxLength: 5, nullable: false),
                    Type = table.Column<string>(nullable: false),
                    Stats = table.Column<string>(nullable: true),
                    Damage = table.Column<string>(nullable: false),
                    SellPrice = table.Column<int>(nullable: false),
                    PurchasePrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "CriticalStrikeChance", "Damage", "Description", "Level", "Location", "Name", "PurchasePrice", "SellPrice", "Stats", "Type" },
                values: new object[,]
                {
                    { new Guid("dc1b48df-c1da-4189-b0ff-b20fd4745025"), ".02", "43953", "A rusty, dull old Sword.", 1, "The Mines entrance", "Rusty Sword", 0, 50, null, "Sword" },
                    { new Guid("e5ac5261-0f9d-420d-b081-00cc210a4883"), ".02", "30-40", "It s unlike anything you ve seen.", 20, "Adventurer s Guild (after obtaining the Galaxy Sword)", "Galaxy Dagger", 35000, 1000, " Speed (+1, Weight (+5)", "Dagger" },
                    { new Guid("41a2cb84-d0a5-4df7-a451-e19fa5128fd4"), ".02", "06/nov", "An old, heavy bone caked in centuries of grime.", 1, "Found while digging outside the mines.", "Femur", 0, 0, " Speed (+2)", "Club" },
                    { new Guid("0c8b4b60-d735-4e15-8b39-ba0bbe8f0019"), ".02", "set/16", "A solid piece of wood, crudely chiseled into a Club shape.", 2, "The Mines (Floors 1-39)", "Wood Club.", 0, 0, null, "Club" },
                    { new Guid("8968da53-53d5-4953-b09d-8682e8898335"), ".02", "15-24", "The solid head packs a punch. Relatively light for a Club.", 2, "The Mines (Floors 40+)", "Wood Mallet", 2000, 0, " Speed (+2, Weight (+2)", "Club" },
                    { new Guid("678723d2-8571-498a-9d60-ace8063549de"), ".02", "18-27", "It s incredibly heavy.", 3, "The Mines (Floors 40+)", "Lead Rod", 0, 0, " Speed (−4)", "Club" },
                    { new Guid("c5dea295-ca95-4f19-8662-ed075940529f"), ".02", "40-55", "An extremely heavy gavel that ll send foes flying.", 5, "Skull Cavern (Floors 40+)", "The Slammer", 0, 0, " Speed (−2)", "Club" },
                    { new Guid("03564d64-fa92-4dee-b7fa-accdfc19a317"), ".02", "70-90", "It s made from an ultra-light material you ve never seen before.", 9, "Adventurer s Guild (after obtaining the Galaxy Sword)", "Galaxy Hammer", 75000, 0, " Speed (+2, Weight (+5)", "Club" },
                    { new Guid("20637718-28d9-40e6-84c6-31c2c57c73cb"), ".02", "01/mar", "The sweet spot is dented from Alex s famous Grand Slam.", 1, "Unobtainable", "Alex s Bat", 0, 50, " Weight (+5)", "Club" },
                    { new Guid("3601697d-ebe4-40ea-aecc-ff63628eb8eb"), ".02", "01/mar", "It s seen better days.", 1, "Unobtainable", "Sam s Old Guitar", 0, 50, " Speed (+1, Weight (+5)", "Club" },
                    { new Guid("699cb176-163c-4648-9c9d-a9dbcc404b0f"), ".04", "03/mai", "Only the nimble hands of an elf could craft this.", 3, "Unobtainable", "Elf Blade", 0, 150, null, "Dagger" },
                    { new Guid("8ea7e6d4-c0cb-4cbb-9c39-1cdd57a644af"), ".02", "27-40", "A brute s companion.", 4, "Unobtainable", "Kudgel", 0, 200, " Speed (−1), Crit. Power (+4), Weight (+2)", "Club" },
                    { new Guid("37cf4560-9a19-4b91-a698-66c3a05eeae7"), ".02", "15-25", "An elegant blade.", 6, "Unobtainable", "Rapier", 0, 300, " Speed (+2)", "Sword" },
                    { new Guid("6aa33dcb-e212-47e4-b2d5-200a3ae7c568"), ".02", "01/mar", "It brings back memories of Harvey s clinic.", 7, "Unobtainable", "Harvey s Mallet", 0, 350, " Speed (+158), Weight (+5)", "Club" },
                    { new Guid("96996b28-232d-4cbf-8d35-122de0a4b014"), ".02", "01/mar", "A big, metal wrench. It smells like Maru.", 7, "Unobtainable", "Maru s Wrench", 0, 350, " Speed (+158), Weight (+5)", "Club" },
                    { new Guid("60b97bfd-1716-4a44-b4a5-162f6a441c14"), ".02", "01/mar", "Penny s favorite frying pan. There s some rubbery gunk stuck to the inside.", 7, "Unobtainable", "Penny s Fryer", 0, 350, " Speed (+158), Weight (+5)", "Club" },
                    { new Guid("f9ccbff5-4e75-41d8-b856-929e814c0a85"), ".02", "01/mar", "One of Sebastian s medieval replicas.", 7, "Unobtainable", "Seb s Lost Mace", 0, 350, " Speed (+158), Weight (+5)", "Club" },
                    { new Guid("7cd589c5-1aab-42d1-a0ff-21322afde4f4"), ".04", "out/20", "When you hold the blade to your ear you can hear 1000 souls shrieking.", 8, "Unobtainable", "Shadow Dagger.", 0, 400, null, "Dagger" },
                    { new Guid("bc327d42-5aae-4dcf-b6fe-0e84e4e5f7a6"), ".02", "26-42", "It s icy cold to the touch.", 9, "Unobtainable", "Yeti Tooth", 0, 450, "Defense (+4), Crit. Power (+10)", "Sword" },
                    { new Guid("3a33488f-d877-48b3-a229-8ff2a07f5ca8"), ".02", "01/mar", "It s searing hot and smells like Haley s hair.", 13, "Unobtainable", "Haley s Iron", 0, 650, " Speed (+154)", "Sword" },
                    { new Guid("7bc928ce-903e-441e-be1d-5a1ef413fcc9"), ".02", "01/mar", "It s made from fine marblewood.", 14, "Unobtainable", "Abby s Planchette", 0, 700, " Speed (+154), Weight (+5)", "Dagger" },
                    { new Guid("7d044764-0ec3-4741-ac93-2725979feccf"), ".02", "01/mar", "Elliott used this to write his book. It s sharp!", 14, "Unobtainable", "Elliott s Pencil", 0, 700, " Speed (+154), Weight (+5)", "Dagger" },
                    { new Guid("0057db11-44a9-4afc-bdd8-eb79f6ae911a"), ".06", "24-30", "The blade is made of an iridium alloy.", 15, "Skull Cavern crates", "Wicked Kris", 0, 750, null, "Dagger" },
                    { new Guid("5624b274-fe25-44d1-a9d6-e42b1a4a2dd0"), ".02", "15-26", "It came from the sea, but it s still sharp.", 11, "Fishing treasure chests", "Broken Trident", 0, 550, null, "Dagger" },
                    { new Guid("50f5e25c-30f2-4537-9381-78b29c5cb425"), ".03", "44108", "The blade is made of purified quartz.", 9, "The Mines floor 60 chest reward", "Crystal Dagger", 0, 450, "Crit. Power.png Crit. Power (+50, Weight (+5)", "Dagger" },
                    { new Guid("11860c22-67e6-41e5-928c-ebd141abc694"), ".04", "44172", "A weapon of choice for the swift and silent.", 8, "Skull Cavern (Serpents and crates)", "Burglar s Shank", 0, 400, "Crit. Power.png Crit. Power (+25)", "Dagger" },
                    { new Guid("f51ffbd1-cab7-4b44-8f15-5924e53290c4"), ".02", "44015", "Not bad for a piece of carved wood.", 2, "Adventurer s Guild", "Wooden Blade", 250, 100, null, "Sword" },
                    { new Guid("8d8c69a4-b8af-40e3-9576-a23200b5b4c4"), ".02", "44047", "A standard metal blade.", 2, "The Mines floor 20 chest reward", "Steel SmallSword", 0, 100, " Speed (+2)", "Sword" },
                    { new Guid("fdc3f253-7240-4fb0-861b-3abe43e4d9e7"), ".02", "42217", "Plated with silver to deter rust.", 3, "Adventurer s Guild (after unlocking the Mines floor 20)", "Silver Saber", 750, 150, "Defense (+1)", "Sword" },
                    { new Guid("a3d8dfd8-82dc-485a-997c-8f853826ab00"), ".02", "41852", "It looks like a pirate owned this once.", 4, "The Mines (Floors 20+)", "Pirate s Sword", 850, 200, " Speed (+2)", "Sword" },
                    { new Guid("0176e4bb-b117-4c4d-aa67-dd823299bb4b"), ".02", "42979", "A finely crafted blade.", 4, "Adventurer s Guild (after unlocking the Mines floor 25)", "Cutlass", 1500, 200, " Speed (+2)", "Sword" },
                    { new Guid("68171d9f-f8dc-4a81-9e6f-90e4caac552b"), ".02", "45992", "A heavy broadsword..", 4, "The Mines (Floors 40+)", "Iron Edge", 0, 200, " Speed (−2), Defense (+1, Weight (+3)", "Sword" },
                    { new Guid("5f62e113-257f-46e2-8575-9a10d24beee5"), ".02", "43313", "Made powerful by forest magic.", 5, "The Mines (Floors 20-60)", "Forest Sword", 0, 250, " Speed (+2), Defense (+1)", "Sword" },
                    { new Guid("c85027b9-4f1a-476a-9fc0-a916305f5959"), ".02", "18-24", "It feels hopeful to wield.", 5, "The Mines (Floors 60+)", "Holy Blade", 0, 250, " Weight (+3)", "Sword" },
                    { new Guid("65ad031e-607a-4f12-91e1-b66724629c41"), ".04", "44105", "Not very pleasant to wield.", 6, "Bug drop", "Insect Head", 10000, 300, " Speed (+2)", "Sword" },
                    { new Guid("ac68854d-c391-4dee-8ff9-d65438c9d18b"), ".02", "20-32", "It s really heavy.", 6, "Adventurer s Guild (after unlocking the Mines floor 45)", "Claymore", 2000, 300, " Speed (−4), Defense (+2, Weight (+3)", "Sword" },
                    { new Guid("dd4fcb78-b4a1-401b-a39f-54231431e0f8"), ".02", "01/mar", "Leah s favorite tool for shaping driftwood.", 14, "Unobtainable", "Leah s Whittler", 0, 700, " Speed (+154), Weight (+5)", "Dagger" },
                    { new Guid("c2424f3e-89a0-4d0b-a5e9-e4c07f1a681d"), "0", "22-29", "It once belonged to an honorable knight.", 6, "Adventurer s Guild (after unlocking the Mines floor 55)", "Templar s Blade", 4000, 300, "Defense (+1)", "Sword" },
                    { new Guid("179b9116-992d-4f89-bd94-8dd3a03d0bf9"), ".02", "18-35", "An heirloom from beyond the Gem Sea.", 7, "Fishing Treasure Chests (Fishing Level 2+)", "Neptune s Glaive", 0, 350, " Speed (−1), Defense (+2, Weight (+4)", "Sword" },
                    { new Guid("1f613fd0-6374-45eb-a216-6acfc53bf5de"), ".02", "29-44", "It looks like it could withstand anything.", 8, "Skull Cavern", "Tempered BroadSword", 0, 400, " Speed (−3), Defense (+3, Weight (+3)", "Sword" },
                    { new Guid("93eb5480-1158-4ab8-a7da-a043793c2cda"), ".02", "30-45", "It s incredibly sharp.", 9, "The Mines floor 90 chest reward", "Obsidian Edge", 0, 450, " Speed (−1), Crit. Power (+10)", "Sword" },
                    { new Guid("4560f39a-2515-4860-9de8-a28a0ef9ac64"), ".02", "20-30", "A very light piece of sharpened bone.", 10, "Adventurer s Guild (after unlocking the Mines floor 75)", "Bone Sword", 6000, 500, " Speed (+4, Weight (+2)", "Sword" },
                    { new Guid("bf1d9eb6-e893-47aa-ae49-847ff286a482"), ".02", "26-38", "Light and powerful.", 14, "Adventurer s Guild (after unlocking the Mines floor 90)", "Steel Falchion", 9000, 700, " Speed (+4), Crit. Power (+20)", "Sword" },
                    { new Guid("4ddf8ba9-ac9c-4eec-9061-4cc6a95b6e81"), ".015", "55-64", "A powerful blade forged in a pool of churning lava.", 15, "Adventurer s Guild (after unlocking the Mines floor 120)", "Lava Katana", 25000, 750, "Defense (+3), Crit. Power (+25, Weight (+3)", "Sword" },
                    { new Guid("74981378-6b4b-4593-b5f2-82988bb1310e"), ".02", "60-80", "It s unlike anything you ve ever seen.", 26, "The Desert (bring a Prismatic Shard to the Three Pillars)", "Galaxy Sword", 50000, 1300, " Speed (+4)", "Sword" },
                    { new Guid("48add9d6-0e2e-4c93-8663-aca12437c88b"), ".04", "43891", "A small, light blade.", 2, "The Mines (Floors 1-20)", "Carving Knife", 0, 100, null, "Dagger" },
                    { new Guid("c939a1f9-79fd-488f-8b90-949d257b52ef"), ".03", "43923", "A common Dagger.", 2, "Adventurer s Guild (after unlocking the Mines floor 15)", "Iron Dirk", 500, 100, null, "Dagger" },
                    { new Guid("7078e480-45c2-444e-8771-d9e1f6d7a0bd"), ".02", "43952", "A swift little blade.", 3, "The Mines (Floors 21-40)", "Wind Spire", 0, 150, "Crit. Power.png Crit. Power (+10, Weight (+5)", "Dagger" },
                    { new Guid("04b92ef1-2bd4-4118-b63d-51a9e11ecf65"), ".05", "30-45", "It s glowing with vampire energy.", 8, "Haunted Skull drop", "Dark Sword", 0, 400, " Speed (-5, Weight (+5) ≈.08 chance of increasing Health, if it is below max.", "Sword" },
                    { new Guid("31f5f91f-8c03-4ddc-988e-60425260a8ad"), ".02", "≈4x that of a regular WeaponType.Slingshot.ToString() using the same ammo", "It looks really powerful.", 0, "Unobtainable", "Galaxy Slingshot", 0, 0, null, "Slingshot" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Weapons");
        }
    }
}
