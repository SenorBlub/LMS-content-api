using MongoDB.Bson.Serialization.Attributes;

namespace Logic.Models.Datas;

public class ImageData
{
	[BsonElement("Url")]
	public string Url { get; set; }
	[BsonElement("AltText")]
	public string AltText { get; set; }
	[BsonElement("Width")]
	public int Width { get; set; }
	[BsonElement("Height")]
	public int Height { get; set; }
}