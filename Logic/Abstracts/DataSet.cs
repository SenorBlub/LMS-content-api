using Logic.Models.Datas;
using Logic.Models.Datas.DataSets;
using Logic.Models.Fields;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Logic.Abstracts;

[BsonDiscriminator(RootClass = true)]
[BsonKnownTypes(typeof(BasicDataSet), typeof(FlowDataSet), typeof(OneAxisDataSet), typeof(PointSpecificDataSet), typeof(RadialBasicDataSet), typeof(RadialPointSpecificDataSet))]
[JsonObject(MemberSerialization.OptIn)]
public abstract class DataSet
{
	[BsonElement("Name")]
	public string Name { get; set; }
}