namespace mission4;

using System;

public class FoodItem
{
    // set up variables
    public string foodName { get; set; }
    public string foodCategory { get; set; }
    public int foodQuantity { get; set; }
    public DateOnly foodExpiration { get; set; }
    
    //Constructor to initiate each item
    public FoodItem(string foodName, string foodCategory, int foodQuantity, DateOnly foodExpiration)
    {
        this.foodName = foodName;
        this.foodCategory = foodCategory;
        this.foodQuantity = foodQuantity;
        this.foodExpiration = foodExpiration;
    }
    // this is the format to print all the variables in one formatted string
    public override string ToString()
    {
        return $"{foodName}, {foodCategory}, {foodQuantity} units, Expires: {foodExpiration}";
    }
    
}