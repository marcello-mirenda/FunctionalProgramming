namespace CSharpFunctionalPatterns.Lab2_Functors
{
    public record RecordMaybe<T>
    {
        private RecordMaybe() { }

        public record Just(T Value) : RecordMaybe<T>;
        public record Nothing() : RecordMaybe<T>;

        public static RecordMaybe<U> Map<U>(Func<T, U> mapper, RecordMaybe<T> maybe) => maybe switch
        {
            RecordMaybe<T>.Nothing => new RecordMaybe<U>.Nothing(),
            RecordMaybe<T>.Just just => new RecordMaybe<U>.Just(mapper(just.Value)),
            _ => new RecordMaybe<U>.Nothing()
        };

    }
}
