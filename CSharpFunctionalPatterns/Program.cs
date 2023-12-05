using CSharpFunctionalPatterns.Lab2_Functors;
using CSharpFunctionalPatterns.Lab3_ApplicativeFunctors;

var applicativeMaybe = new ApplicativeMaybe<int>(1);
var res = applicativeMaybe
    .Apply(new Maybe<Func<int, int>>.Just(x => x + 9))
    .Apply(new Maybe<Func<int, int>>.Just(x => x * 2))
    //.Apply(new Maybe<Func<int, int>>.Nothing())
    .Apply(new Maybe<Func<int, string>>.Just(x => $"A{x}"));
Console.WriteLine(res);