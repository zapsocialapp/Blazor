using System;

namespace Blazor.NetlifyDeploy.Client
{
    public class WeatherForecast
    {
        public DateTime ApprovedTime { get; set; }
        public DateTime ReferenceTime { get; set; }
        public Geometry Geometry { get; set; }
        public Timesery[] TimeSeries { get; set; }
    }

    public class Geometry
    {
        public string Type { get; set; }
        public float[][] Coordinates { get; set; }
    }

    public class Timesery
    {
        public DateTime ValidTime { get; set; }
        public Parameter[] Parameters { get; set; }
    }

    public class Parameter
    {
        public string Name { get; set; }
        public string LevelType { get; set; }
        public int Level { get; set; }
        public string Unit { get; set; }
        public float[] Values { get; set; }
    }
}