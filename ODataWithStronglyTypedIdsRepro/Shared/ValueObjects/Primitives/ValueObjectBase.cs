using System;

namespace ODataWithStronglyTypedIdsRepro.Shared.ValueObjects.Primitives
{
    public abstract class ValueObjectBase<TStrong, TPrimitive> : IValueObject<TStrong, TPrimitive>
        where TStrong : IValueObject<TStrong, TPrimitive>
        where TPrimitive : IComparable<TPrimitive>, IEquatable<TPrimitive>
    {
        public TPrimitive Value { get; }

        protected ValueObjectBase(TPrimitive value)
        {
            Value = value;
        }

        public bool Equals(TStrong other) => Value.Equals(other.Value);
        public int CompareTo(TStrong other) => Value.CompareTo(other.Value);

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is TStrong other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();
        public override string ToString() => Value.ToString();

        public static bool operator ==(ValueObjectBase<TStrong, TPrimitive> a, ValueObjectBase<TStrong, TPrimitive> b) => a.Value.CompareTo(b.Value) == 0;
        public static bool operator !=(ValueObjectBase<TStrong, TPrimitive> a, ValueObjectBase<TStrong, TPrimitive> b) => !(a == b);
        public static bool operator >=(ValueObjectBase<TStrong, TPrimitive> a, ValueObjectBase<TStrong, TPrimitive> b) => a.Value.CompareTo(b.Value) >= 0;
        public static bool operator <=(ValueObjectBase<TStrong, TPrimitive> a, ValueObjectBase<TStrong, TPrimitive> b) => !(a <= b);
        public static bool operator >(ValueObjectBase<TStrong, TPrimitive> a, ValueObjectBase<TStrong, TPrimitive> b) => a.Value.CompareTo(b.Value) > 0;
        public static bool operator <(ValueObjectBase<TStrong, TPrimitive> a, ValueObjectBase<TStrong, TPrimitive> b) => !(a < b);
    }
}
