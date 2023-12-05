using CSharpFunctionalPatterns.Lab2_Functors;

namespace CSharpFunctionalPatterns.Lab3_ApplicativeFunctors
{
    public record RecordApplicativeMaybe<T>(RecordMaybe<T> Value)
    {
        public RecordApplicativeMaybe<U> Apply<U>(RecordMaybe<Func<T, U>> mapper) => mapper switch
        {
            RecordMaybe<Func<T, U>>.Just justMapper => new RecordApplicativeMaybe<U>(Value.Fmap(mapper.Value, Value)),
            RecordMaybe<Func<T, U>>.Nothing => new RecordApplicativeMaybe<U>(new RecordMaybe<U>.Nothing()),
            _ => new RecordApplicativeMaybe<U>(new RecordMaybe<U>.Nothing()),
        };
    }
}
