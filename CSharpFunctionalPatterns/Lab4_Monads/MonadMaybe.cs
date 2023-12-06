using CSharpFunctionalPatterns.Lab2_Functors;

namespace CSharpFunctionalPatterns.Lab4_Monads
{
    public class MonadMaybe<T>
    {
        public Maybe<U> Bind<U>(Func<T, Maybe<U>> mapper, Maybe<T> value) => value switch
        {
            Maybe<T>.Just justValue => mapper(justValue.Value),
            Maybe<T>.Nothing => new Maybe<U>.Nothing(),
            _ => new Maybe<U>.Nothing()
        };

        public Maybe<T> Return(T? a)
        {
            if (a is T value)
            {
                return new Maybe<T>.Just(value);
            }
            else
            {
                return new Maybe<T>.Nothing();
            }
        }
    }
}
