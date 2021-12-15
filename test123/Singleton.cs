using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test123
{
    public class Singleton
    {
        private static Singleton instance;

        public Guid Id { get; set; }

        private Singleton()
        {
            Id = Guid.NewGuid();
        }

        public static Singleton GetInstance()
        {
            if (instance is not null)
            {
                return instance;
            }

            instance = new Singleton();

            return instance;
        }

    }
}
