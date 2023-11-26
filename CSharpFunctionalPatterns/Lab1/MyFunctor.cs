namespace Functors.Lab1
{
    internal class MyFunctor<T> : IFunctor<T>
    {
        public MyFunctor(T value)
        {
            Value = value;
        }

        public T Value { get; }

        public IFunctor<U> Map<U>(Func<T, U> mapper)
        {
            return new MyFunctor<U>(mapper(Value));
        }
    }
}
