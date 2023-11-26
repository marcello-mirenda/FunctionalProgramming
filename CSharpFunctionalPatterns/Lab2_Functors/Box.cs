namespace CSharpFunctionalPatterns.Lab2_Functors
{
    internal class Box<T>
    {
        public Box(T value)
        {
            Value = value;
        }

        public T Value { get; }

        public static Box<U> Map<U>(Func<T, U> mapper, Box<T> box)
        {
            return new Box<U>(mapper(box.Value));
        }

    }
}
