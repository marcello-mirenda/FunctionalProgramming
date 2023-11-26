using CSharpFunctionalPatterns.Lab2_Functors;

namespace CSharpFunctionalPatterns.Lab3_ApplicativeFunctors
{
    public record RecordApplicativeMaybe<T>(RecordMaybe<T> Value)
    {
        public RecordApplicativeMaybe<U> Apply<U>(RecordMaybe<Func<T, U>> f1) => f1 switch
        {
            RecordMaybe<Func<T, U>>.Just justF1 => new RecordApplicativeMaybe<U>(RecordMaybe<T>.Map(justF1.Value, Value)),
            RecordMaybe<Func<T, U>>.Nothing => new RecordApplicativeMaybe<U>(new RecordMaybe<U>.Nothing()),
            _ => new RecordApplicativeMaybe<U>(new RecordMaybe<U>.Nothing()),
        };
    }
}
