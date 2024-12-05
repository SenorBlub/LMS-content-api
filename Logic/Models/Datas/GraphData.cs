using Logic.Abstracts;
using MongoDB.Bson.Serialization.Attributes;

namespace Logic.Models.Datas;

public class GraphData
{
	//current graph support consists of:
	//(OneAxisData)Bar Chart, Pie Chart, Histogram, Donut Chart, Word Cloud
	//(TwoAxisData AKA BasicData)Line Chart, Area Chart, Scatter Plot(individual Plan), Bubble Chart (individual Plan), Stacked Bar Chart, Horizontal Bar Chart
	//(PointSpecificData)Scatter Plot(points can be everywhere), Bubble Chart(points can be everywhere), Scatter Plot With Trendline
	//(RadialTwoAxisData)Radar Chart, Polar Area Chart
	//(RadialPointSpecificData)Radial Scatter Plot, Polar Point Chart
	//(FlowData)Sankey Diagram, Chord Diagram, Tree Map
	[BsonElement("GraphType")]
	public string GraphType { get; set; }
	[BsonElement("Labels")]
	public List<string> Labels { get; set; }
	[BsonElement("DataSets")]
	public List<DataSet> DataSets { get; set; }
	[BsonElement("DataSetNames")]
	public List<string> DataSetNames { get; set; }
}