using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using EasyCrud.Contexts;

namespace EasyCrud.Migrations
{
public partial class init : Migration
{
protected override void Up(MigrationBuilder migrationBuilder)
{
        migrationBuilder.CreateTable(
                name: "Availability",
                columns: table => new
                        {
                                Id = table.Column<long>(type: "bigint", nullable: false)
                                     .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                                Op1 = table.Column<bool>(type: "bit", nullable: false),
                                Op2 = table.Column<bool>(type: "bit", nullable: false),
                                Op3 = table.Column<bool>(type: "bit", nullable: false),
                                Op4 = table.Column<bool>(type: "bit", nullable: false),
                                Op5 = table.Column<bool>(type: "bit", nullable: false)
                        },
                constraints: table =>
                        {
                                table.PrimaryKey("PK_Availability", x => x.Id);
                        });

        migrationBuilder.CreateTable(
                name: "BankInfo",
                columns: table => new
                        {
                                Id = table.Column<long>(type: "bigint", nullable: false)
                                     .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                                AccNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                AccType = table.Column<int>(type: "int", nullable: false),
                                Agency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                Bank = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                Cpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                        },
                constraints: table =>
                        {
                                table.PrimaryKey("PK_BankInfo", x => x.Id);
                        });

        migrationBuilder.CreateTable(
                name: "BestTime",
                columns: table => new
                        {
                                Id = table.Column<long>(type: "bigint", nullable: false)
                                     .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                                Op1 = table.Column<bool>(type: "bit", nullable: false),
                                Op2 = table.Column<bool>(type: "bit", nullable: false),
                                Op3 = table.Column<bool>(type: "bit", nullable: false),
                                Op4 = table.Column<bool>(type: "bit", nullable: false),
                                Op5 = table.Column<bool>(type: "bit", nullable: false)
                        },
                constraints: table =>
                        {
                                table.PrimaryKey("PK_BestTime", x => x.Id);
                        });

        migrationBuilder.CreateTable(
                name: "Knoledge",
                columns: table => new
                        {
                                Id = table.Column<long>(type: "bigint", nullable: false)
                                     .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                                Android = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                Angular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                Aspnet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                Bootstrap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                C = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                Cake = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                Cpp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                Css = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                Django = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                Html = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                Illustrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                Ionic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                Ios = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                Java = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                Jquery = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                Majento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                Mysql = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                Other = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                Photoshop = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                Php = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                Python = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                Ruby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                Salesforce = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                Seo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                Sqls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                Wordpress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                        },
                constraints: table =>
                        {
                                table.PrimaryKey("PK_Knoledge", x => x.Id);
                        });

        migrationBuilder.CreateTable(
                name: "Programmer",
                columns: table => new
                        {
                                Id = table.Column<long>(type: "bigint", nullable: false)
                                     .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                                AvailabilityId = table.Column<long>(type: "bigint", nullable: true),
                                Bank = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                BankInfoId = table.Column<long>(type: "bigint", nullable: true),
                                BestTimeId = table.Column<long>(type: "bigint", nullable: true),
                                City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                KnoledgeId = table.Column<long>(type: "bigint", nullable: true),
                                Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                Linkedin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                Portfolio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                Salary = table.Column<int>(type: "int", nullable: false),
                                Skype = table.Column<string>(type: "nvarchar(max)", nullable: true),
                                State = table.Column<string>(type: "nvarchar(max)", nullable: true)
                        },
                constraints: table =>
                        {
                                table.PrimaryKey("PK_Programmer", x => x.Id);
                                table.ForeignKey(
                                        name: "FK_Programmer_Availability_AvailabilityId",
                                        column: x => x.AvailabilityId,
                                        principalTable: "Availability",
                                        principalColumn: "Id",
                                        onDelete: ReferentialAction.Restrict);
                                table.ForeignKey(
                                        name: "FK_Programmer_BankInfo_BankInfoId",
                                        column: x => x.BankInfoId,
                                        principalTable: "BankInfo",
                                        principalColumn: "Id",
                                        onDelete: ReferentialAction.Restrict);
                                table.ForeignKey(
                                        name: "FK_Programmer_BestTime_BestTimeId",
                                        column: x => x.BestTimeId,
                                        principalTable: "BestTime",
                                        principalColumn: "Id",
                                        onDelete: ReferentialAction.Restrict);
                                table.ForeignKey(
                                        name: "FK_Programmer_Knoledge_KnoledgeId",
                                        column: x => x.KnoledgeId,
                                        principalTable: "Knoledge",
                                        principalColumn: "Id",
                                        onDelete: ReferentialAction.Restrict);
                        });

        migrationBuilder.CreateIndex(
                name: "IX_Programmer_AvailabilityId",
                table: "Programmer",
                column: "AvailabilityId");

        migrationBuilder.CreateIndex(
                name: "IX_Programmer_BankInfoId",
                table: "Programmer",
                column: "BankInfoId");

        migrationBuilder.CreateIndex(
                name: "IX_Programmer_BestTimeId",
                table: "Programmer",
                column: "BestTimeId");

        migrationBuilder.CreateIndex(
                name: "IX_Programmer_KnoledgeId",
                table: "Programmer",
                column: "KnoledgeId");
}

protected override void Down(MigrationBuilder migrationBuilder)
{
        migrationBuilder.DropTable(
                name: "Programmer");

        migrationBuilder.DropTable(
                name: "Availability");

        migrationBuilder.DropTable(
                name: "BankInfo");

        migrationBuilder.DropTable(
                name: "BestTime");

        migrationBuilder.DropTable(
                name: "Knoledge");
}
}
}
