namespace ExerciseCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddedClassificationColumnToVideosTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Videos", "Classification", c => c.Int(nullable: false, defaultValue: 1));
        }

        public override void Down()
        {
            DropColumn("dbo.Videos", "Classification");
        }
    }
}
