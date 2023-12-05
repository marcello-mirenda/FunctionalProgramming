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

        public Maybe<U> Map<U>(Func<T, U> mapper) => this switch
        {
            Maybe<T>.Nothing => new Maybe<U>.Nothing(),
            Maybe<T>.Just just => new Maybe<U>.Just(mapper(just.Value)),
            _ => new Maybe<U>.Nothing()
        };

    }
}
