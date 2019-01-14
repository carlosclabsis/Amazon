using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Amazon.Migrations
{
    public partial class UpdateCategoryColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: "FED7E365-A0FB-407D-9459-08D6652EEAFE",
                column: "Category",
                value: "Technology"
            );
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: "2176B78E-36A3-41C6-945A-08D6652EEAFE",
                column: "Category",
                value: "Technology"
            );
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: "ABD6EF94-F158-49B6-945B-08D6652EEAFE",
                column: "Category",
                value: "Technology"
            );
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: "8ABAD787-8622-4F4D-945C-08D6652EEAFE",
                column: "Category",
                value: "Education"
            );
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: "243BED94-485D-47E6-945D-08D6652EEAFE",
                column: "Category",
                value: "Education"
            );
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: "84C4E862-F313-4728-945E-08D6652EEAFE",
                column: "Category",
                value: "Education"
            );
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: "2E922350-0737-4605-945F-08D6652EEAFE",
                column: "Category",
                value: "Engineering"
            );
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: "DB8B2CB0-9973-4D68-9460-08D6652EEAFE",
                column: "Category",
                value: "Engineering"
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: "FED7E365-A0FB-407D-9459-08D6652EEAFE",
                column: "Category",
                value: null
            );
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: "2176B78E-36A3-41C6-945A-08D6652EEAFE",
                column: "Category",
                value: null
            );
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: "ABD6EF94-F158-49B6-945B-08D6652EEAFE",
                column: "Category",
                value: null
            );
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: "8ABAD787-8622-4F4D-945C-08D6652EEAFE",
                column: "Category",
                value: null
            );
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: "243BED94-485D-47E6-945D-08D6652EEAFE",
                column: "Category",
                value: null
            );
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: "84C4E862-F313-4728-945E-08D6652EEAFE",
                column: "Category",
                value: null
            );
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: "2E922350-0737-4605-945F-08D6652EEAFE",
                column: "Category",
                value: null
            );
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: "DB8B2CB0-9973-4D68-9460-08D6652EEAFE",
                column: "Category",
                value: null
            );
        }
    }
}
