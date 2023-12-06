namespace CSharpFunctionalPatterns.Lab2_Functors
{
    public record Maybe<T>
    {
        public T Value { get; }

        private Maybe(T value)
        {
            Value = value;
        }

        private Maybe() : this(default(T)!) { }

        public record Just(T Value) : Maybe<T>(Value);
        public record Nothing() : Maybe<T>();

    }
}
