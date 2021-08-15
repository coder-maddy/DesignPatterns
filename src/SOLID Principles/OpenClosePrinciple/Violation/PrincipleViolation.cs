using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple.Violation
{

    // We need to everytime modify this class for adding new filter mechnism.
    // This violates open close principle. I class should be open to extend(inheritance) and closed to modify.
    internal class ProductFilter
    {
        public IEnumerable<Product> FilterBySize(IEnumerable<Product> items, Size size)
        {
            return items.Where(i => i.Size == size);
        }

        public IEnumerable<Product> FilterByColor(IEnumerable<Product> items, Color color)
        {
            return items.Where(i => i.Color == color);
        }

        public IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> items, Size size, Color color)
        {
            return items.Where(i => i.Size == size && i.Color == color);
        }
    }
}
