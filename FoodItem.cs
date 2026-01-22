namespace mission4;

using System;

public class FoodItem
{
    public string foodName { get; set; }
    public string foodCategory { get; set; }
    public int foodQuantity { get; set; }
    public DateOnly foodExpiration { get; set; }

    public FoodItem(string foodName, string foodCategory, int foodQuantity, DateOnly foodExpiration)
    {
        this.foodName = foodName;
        this.foodCategory = foodCategory;
        this.foodQuantity = foodQuantity;
        this.foodExpiration = foodExpiration;
    }

    public override string ToString()
    {
        return $"{foodName}, {foodCategory}, {foodQuantity} units, Expires: {foodExpiration}";
    }
    
}