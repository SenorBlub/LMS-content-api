using Logic.Abstracts;

namespace Logic.Models.Datas.DataSets;

public class OneAxisDataSet : DataSet
{
	public List<string> Labels { get; set; }
	public List<double> Values { get; set; }
	public string Color { get; set; }
}