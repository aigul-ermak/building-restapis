using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevHabit.Migrations.Application;

/// <inheritdoc />
public partial class UpdatePendingModelChanges : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<int>(
            name: "frequency_times_per_period",
            schema: "dev_habit",
            table: "habits",
            type: "integer",
            nullable: false,
            defaultValue: 0);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "frequency_times_per_period",
            schema: "dev_habit",
            table: "habits");
    }
}
