using Microsoft.EntityFrameworkCore.Migrations;
using System.Text;

#nullable disable

namespace Students.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migration)
        {
            using (StreamReader reader = new (new FileStream("tanulo.txt", FileMode.Open), Encoding.UTF8))
            {
                string sql = "INSERT INTO Students (om, name, dateofbirth, class, zip, settlement, address) VALUES ";
                while (!reader.EndOfStream)
                {
                    string[] args = reader.ReadLine().Split(';');
                    sql += $"('{args[0]}', '{args[1]}', '{DateTime.Parse(args[2]).ToString("yyyy-MM-dd")}', '{args[3]}', '{args[4]}', '{args[5]}', '{args[6]}'), ";
                }
                sql = sql.Trim().Remove(sql.Length - 2);
                migration.Sql(sql);
            }

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
