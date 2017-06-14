namespace FullstackCourse.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulationGenresTAble : DbMigration
    {
        //this method is used to populate the the DB
        public override void Up()
        {
            // Insert = put in, INTO Tablename (Colum1, Colum2) and then matching values
            //Depending on what kind of variable that is decided (int, string, vchar etc). 
            Sql("INSERT INTO Genres (Id,Name) VALUES (1, 'Jazz')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (2, 'Blues')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (3, 'Rock')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (4, 'Country')");
             
        }

        //this method is used to rense the databas, and should do the opposite of the Up method
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id IN (1, 2, 3, 4)"); 
        }
    }
}
