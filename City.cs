namespace Cities;

internal class City
{
    public string CityName { get; set; }
    public string CountryName { get; set; }
    public double Population { get; set; }

    public City(string line)
    {
        var data = line.Split(';');
        CityName = data[0];
        CountryName = data[1];
        Population = double.Parse(data[2]);
    }

    public override string ToString() =>
        $"{CityName} ({CountryName}) - {Population:0.00}";
}
