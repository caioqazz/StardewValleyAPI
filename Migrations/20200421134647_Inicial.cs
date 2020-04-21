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
                    Image = table.Column<string>(nullable: true),
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
                columns: new[] { "Id", "CriticalStrikeChance", "Damage", "Description", "Image", "Level", "Location", "Name", "PurchasePrice", "SellPrice", "Stats", "Type" },
                values: new object[,]
                {
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba01"), ".02", "2-5", "A rusty, dull old Sword.", "/images/Rusty_Sword.png", 1, "The Mines entrance", "Rusty Sword", 0, 50, null, "Sword" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba29"), ".02", "6-11", "An old, heavy bone caked in centuries of grime.", "/images/Femur.png", 1, "Found while digging outside the mines.", "Femur", 0, 0, " Speed (+2)", "Club" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba30"), ".02", "9-16", "A solid piece of wood, crudely chiseled into a Club shape.", "/images/Wood_Club.png", 2, "The Mines (Floors 1-39)", "Wood Club.", 0, 0, null, "Club" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba31"), ".02", "15-24", "The solid head packs a punch. Relatively light for a Club.", "/images/Wood_Mallet.png", 2, "The Mines (Floors 40+)", "Wood Mallet", 2000, 0, " Speed (+2, Weight (+2)", "Club" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba32"), ".02", "18-27", "It s incredibly heavy.", "/images/Lead_Rod.png", 3, "The Mines (Floors 40+)", "Lead Rod", 0, 0, " Speed (−4)", "Club" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba33"), ".02", "40-55", "An extremely heavy gavel that ll send foes flying.", "/images/The_Slammer.png", 5, "Skull Cavern (Floors 40+)", "The Slammer", 0, 0, " Speed (−2)", "Club" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba34"), ".02", "70-90", "It s made from an ultra-light material you ve never seen before.", "/images/Galaxy_Hammer.png", 9, "Adventurer s Guild (after obtaining the Galaxy Sword)", "Galaxy Hammer", 75000, 0, " Speed (+2, Weight (+5)", "Club" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba35"), ".02", "1-3", "The sweet spot is dented from Alex s famous Grand Slam.", "/images/Alex%27s_Bat.png", 1, "Unobtainable", "Alex s Bat", 0, 50, " Weight (+5)", "Club" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba36"), ".02", "1-3", "It s seen better days.", "/images/Sam%27s_Old_Guitar.png", 1, "Unobtainable", "Sam s Old Guitar", 0, 50, " Speed (+1), Weight (+5)", "Club" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba37"), ".04", "3-5", "Only the nimble hands of an elf could craft this.", "/images/Elf_Blade.png", 3, "Unobtainable", "Elf Blade", 0, 150, null, "Dagger" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba38"), ".02", "27-40", "A brute s companion.", "/images/Kudgel.png", 4, "Unobtainable", "Kudgel", 0, 200, " Speed (−1), Crit. Power (+4), Weight (+2)", "Club" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba28"), ".02", "30-40", "It s unlike anything you ve seen.", "/images/Galaxy_Dagger.png", 20, "Adventurer s Guild (after obtaining the Galaxy Sword)", "Galaxy Dagger", 35000, 1000, " Speed (+1), Weight (+5)", "Dagger" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba39"), ".02", "15-25", "An elegant blade.", "/images/Rapier.png", 6, "Unobtainable", "Rapier", 0, 300, " Speed (+2)", "Sword" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba41"), ".02", "1-3", "A big, metal wrench. It smells like Maru.", "/images/Maru%27s_Wrench.png", 7, "Unobtainable", "Maru s Wrench", 0, 350, " Speed (+158), Weight (+5)", "Club" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba42"), ".02", "1-3", "Penny s favorite frying pan. There s some rubbery gunk stuck to the inside.", "/images/Penny%27s_Fryer.png", 7, "Unobtainable", "Penny s Fryer", 0, 350, " Speed (+158), Weight (+5)", "Club" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba43"), ".02", "1-3", "One of Sebastian s medieval replicas.", "/images/Seb%27s_Lost_Mace.png", 7, "Unobtainable", "Seb s Lost Mace", 0, 350, " Speed (+158), Weight (+5)", "Club" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba44"), ".04", "10-20", "When you hold the blade to your ear you can hear 1000 souls shrieking.", "/images/Shadow_Dagger.png", 8, "Unobtainable", "Shadow Dagger.", 0, 400, null, "Dagger" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba45"), ".02", "26-42", "It s icy cold to the touch.", "/images/Yeti_Tooth.png", 9, "Unobtainable", "Yeti Tooth", 0, 450, "Defense (+4), Crit. Power (+10)", "Sword" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba46"), ".02", "1-3", "It s searing hot and smells like Haley s hair.", "/images/Haley%27s_Iron.png", 13, "Unobtainable", "Haley s Iron", 0, 650, " Speed (+154)", "Sword" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba47"), ".02", "1-3", "It s made from fine marblewood.", "/images/Abby%27s_Planchette.png", 14, "Unobtainable", "Abby s Planchette", 0, 700, " Speed (+154), Weight (+5)", "Dagger" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba48"), ".02", "1-3", "Elliott used this to write his book. It s sharp!", "/images/Elliott%27s_Pencil.png", 14, "Unobtainable", "Elliott s Pencil", 0, 700, " Speed (+154), Weight (+5)", "Dagger" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba49"), ".02", "1-3", "Leah s favorite tool for shaping driftwood.", "/images/Leah%27s_Whittler.png", 14, "Unobtainable", "Leah s Whittler", 0, 700, " Speed (+154), Weight (+5)", "Dagger" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba50"), ".02", "≈4x that of a regular Slingshot using the same ammo", "It looks really powerful.", "/images/Galaxy_Slingshot.png", 0, "Unobtainable", "Galaxy Slingshot", 0, 0, null, "Slingshot" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba40"), ".02", "1-3", "It brings back memories of Harvey s clinic.", "/images/Harvey%27s_Mallet.png", 7, "Unobtainable", "Harvey s Mallet", 0, 350, " Speed (+158), Weight (+5)", "Club" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba27"), ".06", "24-30", "The blade is made of an iridium alloy.", "/images/Wicked_Kris.png", 15, "Skull Cavern crates", "Wicked Kris", 0, 750, null, "Dagger" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba26"), ".02", "15-26", "It came from the sea, but it s still sharp.", "/images/Broken_Trident.png", 11, "Fishing treasure chests", "Broken Trident", 0, 550, null, "Dagger" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba25"), ".03", "4-10", "The blade is made of purified quartz.", "/images/Crystal_Dagger.png", 9, "The Mines floor 60 chest reward", "Crystal Dagger", 0, 450, " Crit. Power (+50, Weight (+5)", "Dagger" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba02"), ".02", "3-7", "Not bad for a piece of carved wood.", "/images/Wooden_Blade.png", 2, "Adventurer s Guild", "Wooden Blade", 250, 100, null, "Sword" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba03"), ".02", "4-8", "A standard metal blade.", "/images/Steel_Smallsword.png", 2, "The Mines floor 20 chest reward", "Steel SmallSword", 0, 100, " Speed (+2)", "Sword" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba04"), ".02", "8-15", "Plated with silver to deter rust.", "/images/Silver_Saber.png", 3, "Adventurer s Guild (after unlocking the Mines floor 20)", "Silver Saber", 750, 150, "Defense (+1)", "Sword" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba05"), ".02", "8-14", "It looks like a pirate owned this once.", "/images/Pirate%27s_Sword.png", 4, "The Mines (Floors 20+)", "Pirate s Sword", 850, 200, " Speed (+2)", "Sword" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba06"), ".02", "9-17", "A finely crafted blade.", "/images/Cutlass.png", 4, "Adventurer s Guild (after unlocking the Mines floor 25)", "Cutlass", 1500, 200, " Speed (+2)", "Sword" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba07"), ".02", "12-25", "A heavy broadsword..", "/images/Iron_Edge.png", 4, "The Mines (Floors 40+)", "Iron Edge", 0, 200, " Speed (−2), Defense (+1), Weight (+3)", "Sword" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba08"), ".02", "8-18", "Made powerful by forest magic.", "/images/Forest_Sword.png", 5, "The Mines (Floors 20-60)", "Forest Sword", 0, 250, " Speed (+2), Defense (+1)", "Sword" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba09"), ".02", "18-24", "It feels hopeful to wield.", "/images/Holy_Blade.png", 5, "The Mines (Floors 60+)", "Holy Blade", 0, 250, " Weight (+3)", "Sword" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba10"), ".04", "10-20", "Not very pleasant to wield.", "/images/Insect_Head.png", 6, "Bug drop", "Insect Head", 10000, 300, " Speed (+2)", "Sword" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba11"), ".02", "20-32", "It s really heavy.", "/images/Claymore.png", 6, "Adventurer s Guild (after unlocking the Mines floor 45)", "Claymore", 2000, 300, " Speed (−4), Defense (+2, Weight (+3)", "Sword" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba12"), "0", "22-29", "It once belonged to an honorable knight.", "/images/Templar%27s_Blade.png", 6, "Adventurer s Guild (after unlocking the Mines floor 55)", "Templar s Blade", 4000, 300, "Defense (+1)", "Sword" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba13"), ".05", "30-45", "It s glowing with vampire energy.", "/images/Dark_Sword.png", 8, "Haunted Skull drop", "Dark Sword", 0, 400, " Speed (-5, Weight (+5) ≈.08 chance of increasing Health, if it is below max.", "Sword" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba14"), ".02", "18-35", "An heirloom from beyond the Gem Sea.", "/images/Neptune%27s_Glaive.png", 7, "Fishing Treasure Chests (Fishing Level 2+)", "Neptune s Glaive", 0, 350, " Speed (−1), Defense (+2, Weight (+4)", "Sword" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba15"), ".02", "29-44", "It looks like it could withstand anything.", "/images/Tempered_Broadsword.png", 8, "Skull Cavern", "Tempered BroadSword", 0, 400, " Speed (−3), Defense (+3, Weight (+3)", "Sword" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba16"), ".02", "30-45", "It s incredibly sharp.", "/images/Obsidian_Edge.png", 9, "The Mines floor 90 chest reward", "Obsidian Edge", 0, 450, " Speed (−1), Crit. Power (+10)", "Sword" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba17"), ".02", "20-30", "A very light piece of sharpened bone.", "/images/Bone_Sword.png", 10, "Adventurer s Guild (after unlocking the Mines floor 75)", "Bone Sword", 6000, 500, " Speed (+4, Weight (+2)", "Sword" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba18"), ".02", "28-46", "Light and powerful.", "/images/Steel_Falchion.png", 14, "Adventurer s Guild (after unlocking the Mines floor 90)", "Steel Falchion", 9000, 700, " Speed (+4), Crit. Power (+20)", "Sword" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba19"), ".015", "55-64", "A powerful blade forged in a pool of churning lava.", "/images/Lava_Katana.png", 15, "Adventurer s Guild (after unlocking the Mines floor 120)", "Lava Katana", 25000, 750, "Defense (+3), Crit. Power (+25, Weight (+3)", "Sword" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba20"), ".02", "60-80", "It s unlike anything you ve ever seen.", "/images/Galaxy_Sword.png", 26, "The Desert (bring a Prismatic Shard to the Three Pillars)", "Galaxy Sword", 50000, 1300, " Speed (+4)", "Sword" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba21"), ".04", "1-3", "A small, light blade.", "/images/Carving_Knife.png", 2, "The Mines (Floors 1-20)", "Carving Knife", 0, 100, null, "Dagger" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba22"), ".03", "2-4", "A common Dagger.", "/images/Iron_Dirk.png", 2, "Adventurer s Guild (after unlocking the Mines floor 15)", "Iron Dirk", 500, 100, null, "Dagger" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba23"), ".02", "1-5", "A swift little blade.", "/images/Wind_Spire.png", 3, "The Mines (Floors 21-40)", "Wind Spire", 0, 150, " Crit. Power (+10), Weight (+5)", "Dagger" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba24"), ".04", "7-12", "A weapon of choice for the swift and silent.", "/images/Burglar%27s_Shank.png", 8, "Skull Cavern (Serpents and crates)", "Burglar s Shank", 0, 400, " Crit. Power (+25)", "Dagger" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba51"), ".02", "Depends on ammo used", "Requires stones for ammo.", "/images/Slingshot.png", 0, "The Mines (Floor 40 chest reward)", "Slingshot", 0, 0, null, "Slingshot" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba52"), ".02", "Depends on ammo used", "Requires stones for ammo.", "/images/Master_Slingshot.png", 0, "The Mines (Floor 70 chest reward)", "Master Slingshot", 0, 0, null, "Slingshot" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Weapons");
        }
    }
}
