using Logic.Abstracts;
using Logic.Models.Datas;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Logic.Models.Fields;

[BsonDiscriminator("TableField")]
[JsonObject(MemberSerialization.OptIn)]
public class TableField : ContentField
{
	[BsonElement("TableData")]
	public TableData TableData { get; set; }
}