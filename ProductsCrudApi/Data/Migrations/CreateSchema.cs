using FluentMigrator;

namespace ProductsCrudApi.Data.Migrations
{
    [Migration(03032024)]
    public class CreateSchema : Migration
    {
        public override void Up()
        {
            Create.Table("products")
                .WithColumn("id").AsInt32().PrimaryKey().Identity()
                .WithColumn("age").AsInt32().NotNullable() // Schimbăm price cu age
                .WithColumn("name").AsString(128).NotNullable()
                .WithColumn("gender").AsString(128).NotNullable() // Schimbăm category cu gender
                .WithColumn("date_of_birth").AsDateTime().NotNullable(); // Schimbăm date_of_fabrication cu date_of_birth
        }

        public override void Down()
        {
            
        }
    }
}
