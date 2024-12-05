using Logic.Abstracts;
using Logic.Models.Datas;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Logic.Models.Fields;

[BsonDiscriminator("LinkField")]
[JsonObject(MemberSerialization.OptIn)]
public class LinkField : ContentField
{
	[BsonElement("LinkData")]
	public LinkData LinkData { get; set; }
}