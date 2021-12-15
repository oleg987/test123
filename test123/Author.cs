using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test123
{
    public class Author
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public DateTime? Birthday { get; set; }
        public int? Age { get => CalculateAge(); }

        private int? CalculateAge()
        {
            if (Birthday.HasValue)
            {
                return DateTime.Today.Year - ((DateTime)Birthday).Year;
            }

            return null;
        }
    }
}
