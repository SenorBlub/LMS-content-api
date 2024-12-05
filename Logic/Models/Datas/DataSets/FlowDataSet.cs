using Logic.Models.Datas.DataSets.SubDatas;
using MongoDB.Bson.Serialization.Attributes;

namespace Logic.Models.Datas.DataSets;

public class FlowDataSet
{
	[BsonElement("FlowData")]
	public List<FlowData> FlowData { get; set; }
}