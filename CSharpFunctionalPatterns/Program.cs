using CSharpFunctionalPatterns.Lab3_ApplicativeFunctors;
using static System.Console;

var applicativeMaybe = new ApplicativeMaybeString();
var res = applicativeMaybe.Apply(
    applicativeMaybe.Pure((string x, string y, string z) => x + y + z),
    applicativeMaybe.Pure("A"),
    applicativeMaybe.Pure("B"),
    applicativeMaybe.Pure("C")
    );

WriteLine(res);