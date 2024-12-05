using MongoDB.Bson.Serialization.Attributes;

namespace Logic.Models.Datas;

public class LinkData
{
	[BsonElement("Url")]
	public string Url { get; set; }
	[BsonElement("DisplayText")]
	public string DisplayText { get; set; }
	[BsonElement("OpenInNewTab")]
	public bool OpenInNewTab { get; set; } = true;
}