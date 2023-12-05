namespace CSharpFunctionalPatterns.Lab2_Functors
{
    public record RecordMaybe<T>(T Value)
    {
        public RecordMaybe() : this(default(T)!) { }

        public record Just(T Value) : RecordMaybe<T>(Value);
        public record Nothing() : RecordMaybe<T>();

        public RecordMaybe<U> Fmap<U>(Func<T, U> mapper, RecordMaybe<T> maybe) => maybe switch
        {
            RecordMaybe<T>.Nothing => new RecordMaybe<U>.Nothing(),
            RecordMaybe<T>.Just just => new RecordMaybe<U>.Just(mapper(just.Value)),
            _ => new RecordMaybe<U>.Nothing()
        };

    }
}
