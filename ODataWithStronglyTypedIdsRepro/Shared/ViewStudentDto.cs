using ODataWithStronglyTypedIdsRepro.Shared.ValueObjects;
using System;
using System.Text.Json.Serialization;

namespace ODataWithStronglyTypedIdsRepro.Shared
{
public class ViewStudentDto
{
    public Guid Id { get => StudentId.Value; set => StudentId = new StudentId(value); }
        
    [JsonIgnore]
    public StudentId StudentId { get; set; }

    public DateTime WhenEnrolled { get; set; }

    public string Name { get; set; }
}
}
