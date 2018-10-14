using CleanCode.Libraries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodePractices
{
    class Program
    {
        static void Main(string[] args)
        {
            

        }

        private static void AntiNegative() 
        {
            var package = FetchPackage();
            if (!package.IsNotDamaged)
            {
                throw new PackageNotValidException("Package is damaged.");
            }
            if (!package.IsNotEmpty)
            {
                throw new PackageNotValidException("Package is empty.");
            }
        }

        private static void Assertive()
        {
            var package = FetchPackage();
            if (package.IsDamaged)
            {
                throw new PackageNotValidException("Package is damaged.");
            }
            if (package.IsEmpty)
            {
                throw new PackageNotValidException("Package is empty.");
            }
        }

        public static Package FetchPackage()
        {
            return new Package();
        }
    }

    public class PackageNotValidException : ApplicationException
    {
        public PackageNotValidException(string message) : base(message)
        {
        }
    }
}
