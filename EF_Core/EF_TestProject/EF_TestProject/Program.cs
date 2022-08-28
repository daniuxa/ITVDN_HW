using ProjectDomain;
using Microsoft.EntityFrameworkCore;
using ProjectData;

ManyToMany();

/*CreateDB();

AddInDB();

ReadFromDB();*/

void ManyToMany()
{
    using (ProjectContext projectContext = new ProjectContext())
    {
        projectContext.Database.EnsureDeleted();
        projectContext.Database.EnsureCreated();

        Artist artist1 = new Artist() { FullName = "artist1" };
        Artist artist2 = new Artist() { FullName = "artist2" };

        Work work1 = new Work() { Name = "work1" };
        Work work2 = new Work() { Name = "work2" };

        artist1.Works.Add(work1);
        artist2.Works.Add(work1);
        artist2.Works.Add(work2);

        projectContext.artists.Add(artist1);
        projectContext.artists.Add(artist2);    

        projectContext.SaveChanges();

        var artists = projectContext.artists.Include(a => a.Works).ToList();
        var works = projectContext.works.Include(a => a.Artists).ToList();

        foreach (var artist in artists)
        {
            Console.WriteLine(artist.ArtistId + " " + artist.FullName);
            foreach (var work in artist.Works)
            {
                Console.WriteLine("   " + $"{work.WorkId} {work.Name}");
            }
        }

        Console.WriteLine(new String('-', 10));

        foreach (var work in works)
        {
            Console.WriteLine(work.WorkId + " " + work.Name);
            foreach (var artist in work.Artists)
            {
                Console.WriteLine($"\t{artist.ArtistId} {artist.FullName}");
            }
        }

    }
}

void CreateDB()
{
    using (ProjectContext projectContext = new ProjectContext())
    {
        projectContext.Database.EnsureDeleted();

        projectContext.Database.EnsureCreated();
    }
}

void AddInDB()
{
    using (ProjectContext projectContext = new ProjectContext())
    {
        Authors author1 = new Authors() { FName = "author", LName = "1" };
        Authors author2 = new Authors() { FName = "author", LName = "2" };

        Books book1 = new Books() { Name = "book1", PublishingYear = 2000 };
        Books book2 = new Books() { Name = "book2", PublishingYear = 2000 };

        /*projectContext.Add(author1);
        projectContext.Add(author2);

        book1.AuthorsId = 1;
        book2.AuthorsId = 1;

        projectContext.books.Add(book1);
        projectContext.books.Add(book2);*/

        author1.books?.Add(book1);
        author1.books?.Add(book2);

        projectContext.Add(author1);
        projectContext.Add(author2);

        projectContext.SaveChanges();

    }
}

void ReadFromDB()
{
    using (ProjectContext projectContext = new ProjectContext())
    {
        var authors = projectContext.authors.Include(x => x.books).ToList();

        foreach (var item in authors)
        {
            Console.WriteLine($"{item.Id} {item.FName} {item.LName}: ");
            foreach (var books in item.books)
            {
                Console.WriteLine(books.Id + " " + books.Name);
            }
        }
    }
}
