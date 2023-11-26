namespace Functors.Lab1
{
    internal interface IEnumerableFunctor<T>
    {
        IEnumerable<T> Value { get; }
        IEnumerableFunctor<U> Map<U>(Func<T, U> mapper);
    }
}
