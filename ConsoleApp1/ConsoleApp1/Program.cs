using ConsoleApp1.Model.DatabaseModels;
using ConsoleApp1.Model;
using Microsoft.EntityFrameworkCore;

/*
using (ApplicationContext db = new ApplicationContext())
{
    List<Author> authors = new()
    {
        new Author { Name = "Александр Сергеевич Пушкин" },
        new Author { Name = "Евгений Алексеевич Гришаев"},
        new Author { Name = "Булгаков Михаил Афанасьевич"}
    };
    List<Country> countries = new()
    {
        new Country { Name = "Россия"},
        new Country { Name = "США"}
    };
    List<Genre> genres = new()
    {
        new Genre { Name = "Приключения"},
        new Genre { Name = "Роман"},
        new Genre { Name = "Драма"}
    };
    List<Book> books = new()
    {
        new Book { Name = "Собачье сердце", Author = authors[2], Country = countries[0], Genre = genres[2]},
        new Book { Name = "Евгений Онегин", Author = authors[0], Country = countries[0], Genre = genres[1]},
        new Book { Name = "Узник чёрного камня",  Author = authors[1], Country = countries[0], Genre = genres[0]}
    };
    List<Customer> customers = new()
    {
        new Customer { Name = "СергаДаниил Денисович", MobilePhone = "+375291731104"},
        new Customer { Name = "НовикИлья Витальевич", MobilePhone = "+375296891695"}
    };
    List<Position> positions = new()
    {
        new Position { Name = "Менедер"},
        new Position { Name =  "Диретор"}
    };
    List<City> cities = new()
    {
        new City { Name = "Пинск"},
        new City { Name = "Минск"},
        new City { Name = "Брест"},
    };
    List<Store> stores = new()
    {
        new Store { Cities = new List<City> { cities[0] }, Name = "Пинский книжник"},
        new Store { Cities = new List<City> { cities[1] }, Name = "Минский книжник"},
        new Store { Cities = new List<City> { cities[2] }, Name = "Брестский книжник"},
    };
    List<Employee> employees = new()
    {
        new Employee { Name = "Володько Людвик Павлович", MobilePhone="+375331543520", Position = positions[1], Salary=3000, StoreId = 1},
        new Employee { Name = "Пигаль Анастасия Сергеевна", MobilePhone="+375334862211", Position = positions[0], Salary=3000, StoreId = 2},
    };
    List<SaleRegistration> sales = new()
    {
        new SaleRegistration { BookId = 1, Customer = customers[0], Employee = employees[0], SaleDate = DateTime.Now },
        new SaleRegistration { BookId = 2, Customer = customers[1], Employee = employees[1], SaleDate = new DateTime(2022, 7, 22) },
    };

    db.Authors.AddRange(authors);
    db.Countries.AddRange(countries);
    db.Genres.AddRange(genres);
    db.Books.AddRange(books);
    db.Customers.AddRange(customers);
    db.Positions.AddRange(positions);
    db.Cities.AddRange(cities);
    db.Stores.AddRange(stores);
    db.Employees.AddRange(employees);
    db.SaleRegistations.AddRange(sales);

    db.SaveChanges();
}
*/

// Using INCLUDE
using (ApplicationContext db = new ApplicationContext())
{
    var books = db.Books
        .Include(u => u.Country)
        .ToList();

    foreach (Book book in books)
    {
        Console.WriteLine($"{book.Id}. {book.Name}, {book.Country.Id} ({book.Country.Name})");
    }
}

// Executing Stored Procedures
using (ApplicationContext db = new ApplicationContext())
{
    decimal salary = 500.00M;

    var employees = db.SpResults
        .FromSqlInterpolated($"exec [dbo].[SelectEmployeeBySalary] @Salary={salary}");

    /* Result
     * 3000.00 Володько Людвик Павлович +375331543520
     * 3000.00 Пигаль Анастасия Сергеевна +375334862211
     */
}


