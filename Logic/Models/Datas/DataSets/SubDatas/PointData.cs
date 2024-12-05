using MongoDB.Bson.Serialization.Attributes;

namespace Logic.Models.Datas.DataSets.SubDatas;

public class PointData
{
	public double XValue { get; set; }
	public double YValue { get; set; }
	[BsonIgnoreIfNull]
	public double? Size { get; set; }
	public string Color { get; set; }
}