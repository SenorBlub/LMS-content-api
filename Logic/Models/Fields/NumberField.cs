using Logic.Abstracts;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Logic.Models.Fields;

[BsonDiscriminator("NumberField")]
[JsonObject(MemberSerialization.OptIn)]
public class NumberField : ContentField
{
	[BsonElement("NumberData")]
	public double Value { get; set; }
}