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
    
    
}