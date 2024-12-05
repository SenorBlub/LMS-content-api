using Logic.Abstracts;
using Logic.Models.Datas.DataSets.SubDatas;
using MongoDB.Bson.Serialization.Attributes;

namespace Logic.Models.Datas.DataSets;

public class PointSpecificDataSet : DataSet
{
	[BsonElement("Points")]
	public List<PointData> Points { get; set; }
}