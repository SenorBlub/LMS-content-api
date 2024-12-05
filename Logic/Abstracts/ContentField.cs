using Logic.Models.Fields;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Logic.Abstracts;

[BsonDiscriminator(RootClass = true)]
[BsonKnownTypes(typeof(AudioField), typeof(TextField), typeof(GraphField), typeof(ImageField), typeof(TableField), typeof(FunctionalField), typeof(NumberField), typeof(LinkField))]
[JsonObject(MemberSerialization.OptIn)]
public abstract class ContentField
{
	[BsonElement("FieldName")]
	[JsonProperty("FieldName")]
	public string FieldName { get; set; }
	[BsonElement("IsCollapsible")]
	[JsonProperty("IsCollapsible")]
	public bool IsCollapsible { get; set; }
	[BsonElement("IsCollapsed")]
	[JsonProperty("IsCollapsed")]
	public bool IsCollapsed { get; set; }
}