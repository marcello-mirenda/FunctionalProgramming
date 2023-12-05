using CSharpFunctionalPatterns.Lab2_Functors;

namespace CSharpFunctionalPatterns.Lab3_ApplicativeFunctors
{
    //public record RecordApplicativeMaybe<T>(RecordMaybe<T> Value)
    //{
    //    public RecordApplicativeMaybe<U> Apply<U>(RecordMaybe<Func<T, U>> mapper) => mapper switch
    //    {
    //        RecordMaybe<Func<T, U>>.Just justMapper => new RecordApplicativeMaybe<U>(RecordMaybe<T>.Map(mapper.Value, Value)),
    //        RecordMaybe<Func<T, U>>.Nothing => new RecordApplicativeMaybe<U>(new RecordMaybe<U>.Nothing()),
    //        _ => new RecordApplicativeMaybe<U>(new RecordMaybe<U>.Nothing()),
    //    };
    //}

    public record ApplicativeMaybe<T>(Maybe<T> Value)
    {
        public ApplicativeMaybe(T value) : this(new Maybe<T>.Just(value))
        {

        }

        public ApplicativeMaybe<U> Apply<U>(Maybe<Func<T, U>> mapper)
        {
            return new ApplicativeMaybe<U>(Apply(mapper, Value));
        }

        private static Maybe<U> Apply<U>(Maybe<Func<T,U>> mapper, Maybe<T> value) => mapper switch
        {
            Maybe<Func<T, U>>.Just justMapper => value.Map(justMapper.Value),
            Maybe<Func<T, U>>.Nothing => new Maybe<U>.Nothing(),
            _ => new Maybe<U>.Nothing(),
        };
    }
}
