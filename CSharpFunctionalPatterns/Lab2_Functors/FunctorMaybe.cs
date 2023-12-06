namespace CSharpFunctionalPatterns.Lab2_Functors
{
    public class FunctorMaybe<T>
    {
        public Maybe<U> Map<U>(Func<T, U> mapper, Maybe<T> a) => a switch
        {
            Maybe<T>.Nothing => new Maybe<U>.Nothing(),
            Maybe<T>.Just just => new Maybe<U>.Just(mapper(just.Value)),
            _ => new Maybe<U>.Nothing()
        };
    }
}
