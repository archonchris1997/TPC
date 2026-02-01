namespace TPC.Models.Vehicles;
using System.Text.Json;


public abstract class Vehicle
{
    public int Id { get; init; }
    public  string Manufacturer { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public double StartingBid { get; set; }
    
    public abstract string Type { get; set; }
//-------------------------------------------------------
    

    
     
}