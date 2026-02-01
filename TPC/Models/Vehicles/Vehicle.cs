namespace TPC.Models.Vehicles;
using System.Text.Json;


/// <summary>
/// Escolhi Class abstrat porque depois é mais fácil trabalhar com Polimorfismo
/// </summary>
public abstract class Vehicle
{
    public int Id { get; init; }
    public  string Manufacturer { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public double StartingBid { get; set; }
    
    public abstract string Type { get; set; }
//-------------------------------------------------------

    protected Vehicle(int id, string manufacturer, string model, int year)
    {
        Id = id;
        Manufacturer = manufacturer;
    }


    
     
}