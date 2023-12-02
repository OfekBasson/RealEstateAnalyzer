using System;

namespace RealEstateAnalizer.Website.Models;

class House
{
    private DateTime dateOfSelling;
    public DateTime DateOfSelling
    {
        get { return DateOfSelling; }
        set { DateOfSelling = value; }
    }
    private int prive;
    public int Price
    {
        get { return prive; }
        set { prive = value; }
    }
    private string essence;
    public string Essence
    {
        get { return essence; }
        set { essence = value; }
    }
    private double partOfHouseThatWasSold;
    public double PartOfHouseThatWasSold
    {
        get { return partOfHouseThatWasSold; }
        set { partOfHouseThatWasSold = value; }
    }
    private string city;
    public string City
    {
        get { return city; }
        set { city = value; }
    }
    private int yearBuildingWasBuilt;
    public int YearBuildingWasBuilt
    {
        get { return yearBuildingWasBuilt; }
        set { yearBuildingWasBuilt = value; }
    }
    private int size;
    public int Size
    {
        get { return size; }
        set { size = value; }
    }
    private int numberOfRooms;
    public int NumberOfRooms
    {
        get { return numberOfRooms; }
        set { numberOfRooms = value; }
    }
    
    
    
    
}