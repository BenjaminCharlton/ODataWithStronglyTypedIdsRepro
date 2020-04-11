using System;

namespace ODataWithStronglyTypedIdsRepro.Shared.ValueObjects.Primitives
{
    public interface IValueObject<TStrong, TPrimitive> : IComparable<TStrong>, IEquatable<TStrong>
        where TStrong : IValueObject<TStrong, TPrimitive>
        where TPrimitive : IComparable<TPrimitive>, IEquatable<TPrimitive>
    {
        TPrimitive Value { get; }
        bool Equals(object obj);
        int GetHashCode();
        string ToString();
    }
}
