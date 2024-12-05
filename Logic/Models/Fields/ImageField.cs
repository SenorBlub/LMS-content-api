using Logic.Abstracts;
using Logic.Models.Datas;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Logic.Models.Fields;

[BsonDiscriminator("ImageField")]
[JsonObject(MemberSerialization.OptIn)]
public class ImageField : ContentField
{
	[BsonElement("ImageData")]
	public ImageData ImageData { get; set; }
}