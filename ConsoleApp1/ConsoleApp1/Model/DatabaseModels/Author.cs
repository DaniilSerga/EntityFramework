namespace ConsoleApp1.Model.DatabaseModels
{
    internal class Author
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Book Book { get; set; }
    }
}
