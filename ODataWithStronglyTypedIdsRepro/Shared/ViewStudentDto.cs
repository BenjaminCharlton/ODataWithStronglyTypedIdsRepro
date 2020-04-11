using ODataWithStronglyTypedIdsRepro.Shared.ValueObjects;
using System;

namespace ODataWithStronglyTypedIdsRepro.Shared
{
    public class ViewStudentDto
    {
        public StudentId Id { get; set; }

        public DateTime WhenEnrolled { get; set; }

        public string Name { get; set; }
    }
}
