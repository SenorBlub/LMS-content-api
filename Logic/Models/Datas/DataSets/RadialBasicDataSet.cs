using Logic.Abstracts;

namespace Logic.Models.Datas.DataSets;

public class RadialBasicDataSet : DataSet
{
	public List<string> Labels { get; set; }
	public List<List<double>> Values { get; set; }
	public string Color { get; set; }
}