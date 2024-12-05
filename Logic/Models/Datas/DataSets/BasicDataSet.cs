using Logic.Abstracts;

namespace Logic.Models.Datas.DataSets;

public class BasicDataSet : DataSet
{
    public List<double> XValues { get; set; }
    public List<double> YValues { get; set; }
    public string Color { get; set; }
}