namespace ConsoleApp1.Model.DatabaseModels
{
    internal class Position
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Employee Employee { get; set; }
    }
}
