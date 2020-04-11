using ODataWithStronglyTypedIdsRepro.Shared.JsonConverters;
using ODataWithStronglyTypedIdsRepro.Shared.TypeConverters;
using ODataWithStronglyTypedIdsRepro.Shared.ValueObjects.Primitives;
using System;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace ODataWithStronglyTypedIdsRepro.Shared.ValueObjects
{
    public class StudentId : ValueObjectBase<StudentId, Guid>
    {
        private StudentId() : base(new Guid()) { }

        public StudentId(Guid value) : base(value) { }

        public static StudentId New() => new StudentId(Guid.NewGuid());
    }
}
