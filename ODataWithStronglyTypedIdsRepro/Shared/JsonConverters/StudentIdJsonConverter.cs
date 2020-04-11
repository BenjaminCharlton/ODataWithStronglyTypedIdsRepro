using ODataWithStronglyTypedIdsRepro.Shared.ValueObjects;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ODataWithStronglyTypedIdsRepro.Shared.JsonConverters
{
    public class StudentIdJsonConverter : JsonConverter<StudentId>
    {
        public override void Write(Utf8JsonWriter writer, StudentId id, JsonSerializerOptions options)
        {
            writer.WriteStringValue(id.Value);
        }

        public override StudentId Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var guid = reader.GetGuid();
            return new StudentId(guid);
        }
    }
}
