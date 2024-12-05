using MongoDB.Bson.Serialization.Attributes;

namespace Logic.Models.Datas;

public class AudioData
{
	[BsonElement("Url")]
	public string Url { get; set; }
	[BsonElement("Description")]
	public string Description { get; set; }
	[BsonElement("Duration")]
	public double Duration { get; set; }
	[BsonElement("Autoplay")]
	public bool Autoplay { get; set; } = false;
	[BsonElement("Loop")]
	public bool Loop { get; set; } = false;
}