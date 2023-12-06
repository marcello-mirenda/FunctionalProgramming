using CSharpFunctionalPatterns.Lab2_Functors;

namespace CSharpFunctionalPatterns.Lab3_ApplicativeFunctors
{
    public class ApplicativeMaybeString : ApplicativeMaybe<string>
    {
        public override Maybe<U> Pure<U>(U a)
        {
            if (a is string value && !string.IsNullOrWhiteSpace(value))
            {
                return new Maybe<U>.Just(a);
            }
            else
            {
                return base.Pure(a);
            }
        }
    }
}
