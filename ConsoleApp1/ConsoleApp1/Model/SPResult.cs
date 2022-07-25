using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Model
{
    [Keyless]
    public class SPResult
    {
        public string Name { get; set; } = null!;

        public decimal Salary { get; set; }

        public string MobilePhone { get; set; } = null!;
    }
}
