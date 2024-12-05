using Logic.Abstracts;
using Logic.Models.Datas.DataSets.SubDatas;
using MongoDB.Bson.Serialization.Attributes;

namespace Logic.Models.Datas.DataSets;

public class RadialPointSpecificDataSet : DataSet
{
	[BsonElement("Points")]
	public List<RadialPointData> Points { get; set; }
	public List<double> Angles { get; set; }

	public void AutoAngle()
	{
		Angles.Clear();
		double angle = 360 / Points.Count();
		double currentAngleValue = 00.00;
		foreach (RadialPointData point in Points)
		{
			Angles.Add(currentAngleValue);
			currentAngleValue =+ angle;
		}
	}
}