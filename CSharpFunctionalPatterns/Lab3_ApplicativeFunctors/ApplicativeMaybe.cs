using CSharpFunctionalPatterns.Lab2_Functors;

namespace CSharpFunctionalPatterns.Lab3_ApplicativeFunctors
{
    public class ApplicativeMaybe<T>
    {
        public virtual Maybe<U> Pure<U>(U a)
        {
            if (a is U value)
            {
                return new Maybe<U>.Just(value);
            }
            else
            {
                return new Maybe<U>.Nothing();
            }
        }

        public Maybe<U> Lift2<U>(Func<T, T, U> mapper, Maybe<T> a, Maybe<T> b)
        {
            if (a is Maybe<T>.Nothing) return new Maybe<U>.Nothing();
            if (b is Maybe<T>.Nothing) return new Maybe<U>.Nothing();
            return new Maybe<U>.Just(mapper(a.Value, b.Value));
        }

        public Maybe<U> Lift3<U>(Func<T, T, T, U> mapper, Maybe<T> a, Maybe<T> b, Maybe<T> c)
        {
            if (a is Maybe<T>.Nothing) return new Maybe<U>.Nothing();
            if (b is Maybe<T>.Nothing) return new Maybe<U>.Nothing();
            if (c is Maybe<T>.Nothing) return new Maybe<U>.Nothing();
            return new Maybe<U>.Just(mapper(a.Value, b.Value, c.Value));
        }

        public Maybe<U> Apply<U>(Maybe<Func<T, U>> mapper, Maybe<T> a) => mapper switch
        {
            Maybe<Func<T, U>>.Just justMapper => new FunctorMaybe<T>().Map(justMapper.Value, a),
            Maybe<Func<T, U>>.Nothing => new Maybe<U>.Nothing(),
            _ => new Maybe<U>.Nothing(),
        };

        public Maybe<U> Apply<U>(Maybe<Func<T, T, U>> mapper, Maybe<T> a, Maybe<T> b) => mapper switch
        {
            Maybe<Func<T, T, U>>.Just justMapper => Lift2(justMapper.Value, a, b),
            Maybe<Func<T, T, U>>.Nothing => new Maybe<U>.Nothing(),
            _ => new Maybe<U>.Nothing(),
        };

        public Maybe<U> Apply<U>(Maybe<Func<T, T, T, U>> mapper, Maybe<T> a, Maybe<T> b, Maybe<T> c) => mapper switch
        {
            Maybe<Func<T, T, T, U>>.Just justMapper => Lift3(justMapper.Value, a, b, c),
            Maybe<Func<T, T, T, U>>.Nothing => new Maybe<U>.Nothing(),
            _ => new Maybe<U>.Nothing(),
        };
    }
}
