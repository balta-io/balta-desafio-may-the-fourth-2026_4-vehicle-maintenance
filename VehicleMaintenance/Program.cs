using CsvHelper;
using System.Globalization;

using var reader = new StreamReader("vehicle.csv");
using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
var records = csv.GetRecords<Vehicle>();

foreach (var record in records.ToList())
{
    Console.WriteLine(record.Model);
}

class Vehicle
{
    public string Model { get; set; } = null!;
    public string Brand { get; set; } = null!;
    public int Year { get; set; }
    public int CurrentMileage { get; set; }
    public int LastOilChangeMileage { get; set; }
    public int LastTireChangeMileage { get; set; }
    public int LastRevisionMileage { get; set; }
}