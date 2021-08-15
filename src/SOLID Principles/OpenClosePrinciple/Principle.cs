using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    internal interface ISpecification<T>
    {
        bool Satisfied(T t);
    }

    internal interface IFilterService<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> specification);
    }

    internal class SizeSpecification : ISpecification<Product>
    {
        Size size;
        public SizeSpecification(Size size)
        {
            this.size = size;
        }
        public bool Satisfied(Product t)
        {
            return t.Size==size;
        }
    }

    internal class ColorSpecification : ISpecification<Product>
    {
        Color color;
        public ColorSpecification(Color color)
        {
            this.color = color;
        }
        public bool Satisfied(Product t)
        {
            return t.Color == color;
        }
    }

    internal class AndSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> first;
        private ISpecification<T> second;

        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            this.first = first;
            this.second = second;
        }
        public bool Satisfied(T t)
        {
            return first.Satisfied(t) && second.Satisfied(t);
        }
    }

    internal class Filter : IFilterService<Product>
    {

        IEnumerable<Product> IFilterService<Product>.Filter
            (IEnumerable<Product> items, ISpecification<Product> specification)
        {
            return items.Where(i=>specification.Satisfied(i));
        }
    }
}
