using MongoDB.Bson.Serialization.Attributes;

namespace Logic.Models.Datas;

public class FunctionalData
{
	[BsonElement("Condition")]
	public string Condition { get; set; }
	[BsonElement("Action")]
	public string Action { get; set; }
	[BsonElement("Parameters")]
	public Dictionary<string, object> Parameters { get; set; }
}