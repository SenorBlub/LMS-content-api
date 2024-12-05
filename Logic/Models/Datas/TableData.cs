using MongoDB.Bson.Serialization.Attributes;

namespace Logic.Models.Datas;

public class TableData
{
	[BsonElement("Headers")]
	public List<string> Headers { get; set; }
	[BsonElement("Rows")]
	public List<List<string>> Rows { get; set; }
	[BsonElement("HasBorder")]
	public bool HasBorder { get; set; } = true;
}