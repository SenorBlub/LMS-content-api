using Logic.Abstracts;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Logic.Models.Fields;

[BsonDiscriminator("TextField")]
[JsonObject(MemberSerialization.OptIn)]
public class TextField : ContentField
{
	[BsonElement("TextData")]
	public string Value { get; set; }
}