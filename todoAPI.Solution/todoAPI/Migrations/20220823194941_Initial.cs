﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace todoapi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ToDos",
                columns: table => new
                {
                    ToDoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    PP = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Description = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Image = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDos", x => x.ToDoId);
                });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "ToDoId", "Category", "Description", "Image", "Name", "PP" },
                values: new object[,]
                {
                    { 1, "Personal", "Walks your dog", "https://cdn.discordapp.com/attachments/1011292802468032512/1011680146673123339/wakawaka.png", "Waka-Waka", 68 },
                    { 27, "Personal", "Gives you one free massage", "https://cdn.discordapp.com/attachments/1011292802468032512/1011716974822305842/hamassage.png", "Hamassage", 51 },
                    { 28, "Food", "Makes you eat a ghost pepper", "https://cdn.discordapp.com/attachments/1011292802468032512/1011390601897455686/ghostgarper.png", "Ghostgarper", 0 },
                    { 29, "Home", "Flips your mattress for no reason", "https://cdn.discordapp.com/attachments/1011292802468032512/1011686784633143346/FlipMonChan.png", "Flipmonchan", 0 },
                    { 30, "Home", "Takes out your trash", "https://cdn.discordapp.com/attachments/1011292802468032512/1011684166254993498/trashpinch.png", "Trashpinch", 0 },
                    { 31, "Home", "Gets your mail - shreds it", "https://cdn.discordapp.com/attachments/1011292802468032512/1011682850715750460/mailapod.png", "Mailapod", 0 },
                    { 32, "Home", "Cleans your dishes without soap", "https://cdn.discordapp.com/attachments/1011292802468032512/1011395918093893722/MR_Dirty.png", "Mr. Dirty", 0 },
                    { 33, "Food", "Bakes cookies - burns them", "https://cdn.discordapp.com/attachments/1011292802468032512/1011687059389427732/CookieTron.png", "Cookietron", 0 },
                    { 34, "Personal", "Plans Carl's funeral", "https://cdn.discordapp.com/attachments/1011292802468032512/1011687190692106360/CarlsDad.png", "Carl's Dad", 3 },
                    { 35, "School", "Makes your README file - never credits you", "https://cdn.discordapp.com/attachments/1011292802468032512/1011718304840294481/SeekZaTenShun.png", "Seekzatenshun", 0 },
                    { 36, "School", "Updates your resume with their name and contact info", "https://cdn.discordapp.com/attachments/1011292802468032512/1011720274082791494/resumoocher.png", "Jobbofind", 0 },
                    { 37, "Home", "Mops your floor with too much soap", "https://cdn.discordapp.com/attachments/1011292802468032512/1011686475169026048/Moprog.png", "Moprog", 0 },
                    { 38, "Personal", "You must speed run Darksouls", "https://cdn.discordapp.com/attachments/1011292802468032512/1011415353122889879/you_died.png", "You Died", 0 },
                    { 39, "Personal", "Takes a bath - you no longer have a bath", "https://cdn.discordapp.com/attachments/1011292802468032512/1011417800079847494/scrubadubdub.png", "Scrubadubdub", 0 },
                    { 40, "Health", "Time to get your flu shot", "https://cdn.discordapp.com/attachments/1011292802468032512/1011686915407360000/JustALittlePrick.png", "Justa 'Lil Prick", 0 },
                    { 41, "Work", "Rings whenever you forget a semicolon", "https://cdn.discordapp.com/attachments/1011292802468032512/1011686999729639585/Remiu.png", "Remiu", 0 },
                    { 42, "Food", "Cleans out your fridge entirely", "https://cdn.discordapp.com/attachments/1011292802468032512/1011687090943168552/Clefridgy.png", "Clefridgy", 0 },
                    { 43, "Personal", "Teaches you how to dance", "https://cdn.discordapp.com/attachments/1011292802468032512/1011417750452830228/unknown.png", "ChaCha-mon", 0 },
                    { 44, "Personal", "Invests in bitcoin and in your future", "https://cdn.discordapp.com/attachments/1011292802468032512/1011401474997223455/unknown.png", "MoneyBanks", 0 },
                    { 45, "Food", "Eats your whole roll of Cookiedough as fast as he can", "https://cdn.discordapp.com/attachments/1011292802468032512/1011686842841698314/SantasHelper.png", "Santa's Helper", 0 },
                    { 46, "Food", "Solves world hunger; doesn't tell you how", "https://cdn.discordapp.com/attachments/1011292802468032512/1011419920761892904/unknown.png", "Grincheon", 0 },
                    { 47, "Work", "Simply walks into Mordor", "https://cdn.discordapp.com/attachments/1011292802468032512/1011685949102628905/wondusnot.png", "Wondusnot", 0 },
                    { 26, "Car", "Washes your car with a dirty rag", "https://cdn.discordapp.com/attachments/1011292802468032512/1011349207539515453/Carwash.png", "WashyCar", 76 },
                    { 48, "Personal", "Finds Nemo - doesn't tell you where", "https://cdn.discordapp.com/attachments/1011292802468032512/1011361910991630467/Find_nemo.png", "Marlout", 0 },
                    { 25, "Home", "Replaces batteries in smoke detectors", "https://cdn.discordapp.com/attachments/1011292802468032512/1011393369731248220/smokey.png", "Smokey", 90 },
                    { 23, "School", "Makes you do a technical interview", "https://cdn.discordapp.com/attachments/1011292802468032512/1011686543003504750/WhiteBoardPuff.png", "Whiteboardpuff", 15 },
                    { 2, "Home", "Does your laundry", "https://cdn.discordapp.com/attachments/1011292802468032512/1011687033116299284/waashmo.png", "Waashmo", 2 },
                    { 3, "Personal", "Does your taxes", "https://cdn.discordapp.com/attachments/1011292802468032512/1011386221441847326/irirs.png", "Irirs", 67 },
                    { 4, "Food", "Buys you groceries", "https://cdn.discordapp.com/attachments/1011292802468032512/1011342412297281606/munchakoopa.png", "Munchakoopa", 7 },
                    { 5, "School", "Does your Epicodus homework", "https://cdn.discordapp.com/attachments/1011292802468032512/1011344877369425930/monyay.png", "Monyay", 70 },
                    { 6, "Personal", "Your own personal trainer", "https://cdn.discordapp.com/attachments/1011292802468032512/1011682719232704632/swolium.png", "Swolium", 89 },
                    { 7, "Home", "Waters your indoor plants", "https://cdn.discordapp.com/attachments/1011292802468032512/1011688286126870598/cannowat.png", "Cannowat", 15 },
                    { 8, "Personal", "Cuts your hair", "https://cdn.discordapp.com/attachments/1011292802468032512/1011347425161654292/snips.png", "Snips", 80 },
                    { 9, "Car", "Changes your oil", "https://cdn.discordapp.com/attachments/1011292802468032512/1011368404504031342/jiffyum.png", "Jiffyum", 93 },
                    { 10, "Home", "Pays your rent", "https://cdn.discordapp.com/attachments/1011292802468032512/1011387943673397318/arm_and_leg.png", "Arm and Leg", 27 },
                    { 11, "Home", "Vacuums your house", "https://cdn.discordapp.com/attachments/1011292802468032512/1011348731750252655/Suckuebus.png", "Suckuebus", 53 },
                    { 12, "Car", "Goes to the DMV", "https://cdn.discordapp.com/attachments/1011292802468032512/1011689057723613305/waiterus.png", "Waiterus", 42 },
                    { 13, "Personal", "Plans the wedding", "https://cdn.discordapp.com/attachments/1011292802468032512/1011722626709860442/wedder.png", "Wedder", 33 },
                    { 14, "Food", "Preps all your meals", "https://cdn.discordapp.com/attachments/1011292802468032512/1011670067211153439/DinDin.png", "DinDin", 48 },
                    { 15, "Personal", "Goes to the library", "https://cdn.discordapp.com/attachments/1011292802468032512/1011686587882549341/Booksi.png", "Booksi", 61 },
                    { 16, "Car", "Fills your tank a little", "https://cdn.discordapp.com/attachments/1011292802468032512/1011340622675845281/50_bucks.png", "50 Bucks", 57 },
                    { 17, "Personal", "Forces you to watch Hotrod", "https://cdn.discordapp.com/attachments/1011292802468032512/1011359277492998294/rodded.png", "Rodded", 88 },
                    { 18, "Health", "Extracts and donates your blood", "https://cdn.discordapp.com/attachments/1011292802468032512/1011357411883364512/vamps.png", "Vamp", 65 },
                    { 19, "Home", "Mows your lawn", "https://cdn.discordapp.com/attachments/1011292802468032512/1011686667708551189/Momo.png", "Momo", 34 },
                    { 20, "Home", "Fixes your sink", "https://cdn.discordapp.com/attachments/1011292802468032512/1011687294954110986/PlumpPlumber.png", "Plump Plumber", 11 },
                    { 21, "Health", "Meditates ... or just sleeps", "https://cdn.discordapp.com/attachments/1011292802468032512/1011420092384428133/medichu.png", "Medichu", 100 },
                    { 22, "Health", "Manditory colonoscopy: you must make a copy of your colons", "https://cdn.discordapp.com/attachments/1011292802468032512/1011362297127649351/CloseCall.png", "Close Call", 34 },
                    { 24, "Personal", "Checks your credit score - damages your credit", "https://cdn.discordapp.com/attachments/1011292802468032512/1011686725837406280/Loanio.png", "Loanio", 67 },
                    { 49, "Health", "Kills Sarah Connor - legally", "https://cdn.discordapp.com/attachments/1011292802468032512/1011680839869927575/unknown.png", "B-back 7000", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToDos");
        }
    }
}
