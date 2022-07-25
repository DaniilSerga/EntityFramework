namespace ConsoleApp1.Model.DatabaseModels
{
    internal class Country
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public Book Book { get; set; } = null!;
    }
}
