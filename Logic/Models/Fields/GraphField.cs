using Logic.Abstracts;
using Logic.Models.Datas;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Logic.Models.Fields;

[BsonDiscriminator("GraphField")]
[JsonObject(MemberSerialization.OptIn)]
public class GraphField : ContentField
{
	[BsonElement("GraphData")]
	public GraphData GraphData { get; set; }
}