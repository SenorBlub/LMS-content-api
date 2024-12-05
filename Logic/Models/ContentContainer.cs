using Logic.Abstracts;
using Logic.Models.Datas;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Logic.Models;

public class ContentContainer
{
	[BsonIgnoreIfNull]
	public string? ContainerName { get; set; }
	[BsonElement("Layout")]
	public LayoutData Layout { get; set; }
	public int FieldCapacity { get; set; }
	[BsonElement("contentFields")]
	public List<ContentField> contentFields { get; set; } = new List<ContentField>();
	public bool IsCollapsible { get; set; }
	public bool IsCollapsed { get; set; }
}