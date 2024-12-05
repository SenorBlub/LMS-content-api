using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Logic.Models;

public class Content
{
	[BsonId]
	[BsonRepresentation(BsonType.String)]
	public Guid Id { get; set; }
	[BsonElement("UserId")]
	[BsonRepresentation(BsonType.String)]
	public Guid UserId { get; set; }
	[BsonElement("IsPrivate")]
	public bool IsPrivate { get; set; }
	[BsonRequired]
	[BsonElement("Title")]
	public string Title { get; set; }
	[BsonIgnoreIfNull]
	[BsonElement("Description")]
	public string? Description { get; set; }
	[BsonElement("contentContainers")]
	public List<ContentContainer> ContentContainers { get; set; } = new List<ContentContainer>();
	[BsonElement("CreatedAt")]
	public DateTime CreatedAt { get; set; }
	[BsonElement("LastUpdatedAt")]
	public DateTime LastUpdatedAt { get; set; }
}