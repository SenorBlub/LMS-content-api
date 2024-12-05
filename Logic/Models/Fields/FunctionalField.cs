using Logic.Abstracts;
using Logic.Models.Datas;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Logic.Models.Fields;

[BsonDiscriminator("FunctionalField")]
[JsonObject(MemberSerialization.OptIn)]
public class FunctionalField : ContentField
{
	[BsonElement("FunctionalData")]
	public FunctionalData FunctionalData { get; set; }
}