using CsvHelper;
using System.Globalization;

using var reader = new StreamReader("vehicle.csv");
using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
var records = csv.GetRecords<Vehicle>();

var vehicle = records.FirstOrDefault();

if (vehicle is null)
    return;

string context = string.Empty;

if (vehicle.CurrentMileage - vehicle.LastOilChangeMileage >= 10000)
    context += "precisa trocar o óleo, pois trocar a cada 10.000km;";

if (vehicle.CurrentMileage - vehicle.LastTireChangeMileage >= 20000)
    context += "precisa revisar o pneu, pois revisar a cada 20.000km;";

if (vehicle.CurrentMileage - vehicle.LastRevisionMileage >= 30000)
    context += "precisa fazer revisão geral, pois revisar a cada 30.000km;";

Console.WriteLine(context);

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