public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    // 所以地震資料
    public List<Feature> Features { get; set; } = new List<Feature>();
}

public class Feature
{
    // 單筆地震資料
    public EarthquakeProperties Properties { get; set; }
        = new EarthquakeProperties();
}

public class EarthquakeProperties
{
    // 單筆地震資料的屬性
    public double? Mag { get; set; }
    public string Place { get; set; } = "";
}