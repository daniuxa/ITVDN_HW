using ProjectDomain;
using Microsoft.EntityFrameworkCore;
using ProjectData;

CreateDB();

//AddInDB();

//ReadFromDB();

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
        Authors author1 = new Authors() { FName = "1", LName = "1" };
        Authors author2 = new Authors() { FName = "2", LName = "2" };

        Books book1 = new Books() { Name = "1", PublishingYear = 2000 };
        Books book2 = new Books() { Name = "2", PublishingYear = 2000 };

        author1.books.Add(book1);
        author1.books.Add(book2);

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
