namespace Functors.Lab1
{
    internal class ListFunctor<T> : IEnumerableFunctor<T>
    {
        public ListFunctor(IEnumerable<T> value)
        {
            Value = value;
        }

        public IEnumerable<T> Value { get; }

        public IEnumerableFunctor<U> Map<U>(Func<T, U> mapper)
        {
            var list = new List<U>();
            foreach (var item in Value)
            {
                list.Add(mapper(item));
            }
            return new ListFunctor<U>(list);
        }
    }
}
