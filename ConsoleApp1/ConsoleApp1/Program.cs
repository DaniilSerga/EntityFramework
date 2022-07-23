using ConsoleApp1.Model.DatabaseModels;
using ConsoleApp1.Model;

using (ApplicationContext db = new ApplicationContext())
{
    List<Author> authors = new List<Author> 
    { 
        new Author { Name = "Александр Сергеевич Пушкин" },
        new Author { Name = "Евгений Алексеевич Гришаев"},
        new Author { Name = "Булгаков Михаил Афанасьевич"}
    };
    List<Country> countries = new List<Country>
    {
        new Country { Name = "Россия"},
        new Country { Name = "США"}
    };
    List<Genre> genres = new List<Genre>
    {
        new Genre { Name = "Приключения"},
        new Genre { Name = "Роман"},
        new Genre { Name = "Драма"}
    };
    List<Book> books = new List<Book>
    {
        new Book { Name = "Собачье сердце", AuthorId = 3, CountryId = 1, GenreId = 3},
        new Book { Name = "Евгений Онегин", AuthorId = 1, CountryId = 1, GenreId = 2},
        new Book { Name = "Узник чёрного камня", AuthorId = 2, CountryId = 1, GenreId = 1}
    };
    List<Customer> customers = new List<Customer>
    {
        new Customer { Name = "Серга Даниил Денисович", MobilePhone = "+375291731104"},
        new Customer { Name = "Новик Илья Витальевич", MobilePhone = "+375296891695"}
    };
    List<Position> positions = new List<Position>
    {
        new Position { Name = "Менеджер"},
        new Position { Name =  "Директор"}
    };
    List<Employee> employees = new List<Employee>
    {
        new Employee { Name = "Володько Людвик Павлович", MobilePhone="+375331543520", PositionId=2, Salary=3000},
        new Employee { Name = "Пигаль Анастасия Сергеевна", MobilePhone="+375334862211", PositionId=1, Salary=3000},
    };
    List<SaleRegistration> sales = new List<SaleRegistration>
    {
        new SaleRegistration { BookId = 1, CustomerId = 1, EmployeeId = 2, SaleDate = DateTime.Now },
        new SaleRegistration { BookId = 3, CustomerId = 2, EmployeeId = 1, SaleDate = new DateTime(2022, 7, 22) },
    };
    List<City> cities = new List<City>
    {
        new City { Name = "Пинск"},
        new City { Name = "Минск"},
        new City { Name = "Брест"},
    };
    List<Store> stores = new List<Store>
    {
        new Store { CityId = 1, Name = "Пинский книжник"},
        new Store { CityId = 2, Name = "Минский книжник"},
        new Store { CityId = 3, Name = "Брестский книжник"},
    };

    db.Authors.AddRange(authors);
    db.Countries.AddRange(countries);
    db.Genres.AddRange(genres);
    db.Books.AddRange(books);
    db.Customers.AddRange(customers);
    db.Positions.AddRange(positions);
    db.Employees.AddRange(employees);
    db.SaleRegistations.AddRange(sales);
    db.Cities.AddRange(cities);
    db.Stores.AddRange(stores);

    db.SaveChanges();
}

using (ApplicationContext db = new ApplicationContext())
{

}
