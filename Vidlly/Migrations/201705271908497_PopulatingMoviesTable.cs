namespace Vidlly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulatingMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, ReleasedDate, NumberInStock) VALUES('Shark', 1, 10/08/2014, 5)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleasedDate, NumberInStock) VALUES('300', 2, 10/08/2013, 5)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleasedDate, NumberInStock) VALUES('3idiots', 3, 10/08/2012, 5)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleasedDate, NumberInStock) VALUES('kamal', 4, 10/08/2011, 5)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleasedDate, NumberInStock) VALUES('titanic', 5, 10/08/2010, 5)");

        }

        public override void Down()
        {
        }
    }
}
