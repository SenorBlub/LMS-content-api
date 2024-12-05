using Logic.Abstracts;
using Logic.Models.Datas;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Logic.Models.Fields;

[BsonDiscriminator("AudioField")]
[JsonObject(MemberSerialization.OptIn)]
public class AudioField : ContentField
{
	[BsonElement("AudioData")]
	public AudioData AudioData { get; set; }
}