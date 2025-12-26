using System;

public class UnitConverter
{
    // Convert with target unit
    public double Convert(double value, string fromUnit, string toUnit)
    {
        fromUnit = fromUnit.ToLower();
        toUnit = toUnit.ToLower();

        // Length
        if (fromUnit == "meters" && toUnit == "kilometers")
            return value * 0.001;
        if (fromUnit == "kilometers" && toUnit == "meters")
            return value * 1000;
        if (fromUnit == "miles" && toUnit == "feet")
            return value * 5280;
        if (fromUnit == "feet" && toUnit == "miles")
            return value / 5280;

        // Weight
        if (fromUnit == "grams" && toUnit == "kilograms")
            return value * 0.001;
        if (fromUnit == "kilograms" && toUnit == "grams")
            return value * 1000;
        if (fromUnit == "pounds" && toUnit == "ounces")
            return value * 16;
        if (fromUnit == "ounces" && toUnit == "pounds")
            return value / 16;

        // Temperature
        if (fromUnit == "celsius" && toUnit == "fahrenheit")
            return (value * 9 / 5) + 32;
        if (fromUnit == "fahrenheit" && toUnit == "celsius")
            return (value - 32) * 5 / 9;
        if (fromUnit == "celsius" && toUnit == "kelvin")
            return value + 273.15;
        if (fromUnit == "kelvin" && toUnit == "celsius")
            return value - 273.15;

        throw new Exception("Invalid conversion units");
    }

    // Convert to default unit
    public double Convert(double value, string fromUnit)
    {
        string type = GetType(fromUnit);
        string defaultUnit = GetDefaultUnit(type);
        return Convert(value, fromUnit, defaultUnit);
    }

    private string GetType(string unit)
    {
        unit = unit.ToLower();

        if (unit == "meters" || unit == "kilometers" || unit == "miles" || unit == "feet")
            return "length";
        if (unit == "grams" || unit == "kilograms" || unit == "pounds" || unit == "ounces")
            return "weight";
        if (unit == "celsius" || unit == "fahrenheit" || unit == "kelvin")
            return "temperature";

        throw new Exception("Invalid unit type");
    }

    public string GetDefaultUnit(string type)
    {
        switch (type.ToLower())
        {
            case "length": return "meters";
            case "weight": return "kilograms";
            case "temperature": return "celsius";
            default: throw new Exception("Invalid conversion type");
        }
    }
}

class Program
{
    static void Main()
    {
        UnitConverter converter = new UnitConverter();

        Console.WriteLine("Enter conversion type (Length / Weight / Temperature):");
        string type = Console.ReadLine();

        Console.WriteLine("Enter value:");
        double value = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter from unit:");
        string fromUnit = Console.ReadLine();

        Console.WriteLine("Do you want to specify target unit? (yes/no)");
        string choice = Console.ReadLine().ToLower();

        double result;
        string toUnit;

        if (choice == "yes")
        {
            Console.WriteLine("Enter to unit:");
            toUnit = Console.ReadLine();
            result = converter.Convert(value, fromUnit, toUnit);
        }
        else
        {
            toUnit = converter.GetDefaultUnit(type);
            result = converter.Convert(value, fromUnit);
        }

        Console.WriteLine($"Converted Value: {result} {toUnit}");

        //-------------------------------------------------

        int menId = Convert.ToInt32(Console.ReadLine());
        int menSize = Convert.ToInt32(Console.ReadLine());

        // Women input
        int womenId = Convert.ToInt32(Console.ReadLine());
        int womenSize = Convert.ToInt32(Console.ReadLine());
        string materialType = Console.ReadLine();

        // Kids input
        int kidsId = Convert.ToInt32(Console.ReadLine());
        int kidsSize = Convert.ToInt32(Console.ReadLine());

        // Object creation
        Men men = new Men(menId, menSize);
        Women women = new Women(womenId, womenSize, materialType);
        Kids kids = new Kids(kidsId, kidsSize);

        // Display output
        men.DisplayInfo();
        women.DisplayInfo();
        kids.DisplayInfo();
    }
}

public class Cloth
{
    public int ID { get; set; }

    public Cloth(int id)
    {
        ID = id;
    }
}

// Men class
public class Men : Cloth
{
    public int Size { get; set; }
    public string return_cloth = "YES";

    public Men(int id, int size) : base(id)
    {
        Size = size;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"MEN ID: {ID}");
        Console.WriteLine($"Size: {Size}");
        Console.WriteLine($"Return Option within a Week: {return_cloth}");
    }
}

// Women class
public class Women : Cloth
{
    public int Size { get; set; }
    public string MaterialType { get; set; }
    public string return_cloth = "YES";

    public Women(int id, int size, string materialType) : base(id)
    {
        Size = size;
        MaterialType = materialType;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Women Cloth ID: {ID}");
        Console.WriteLine($"Size: {Size}");
        Console.WriteLine($"Material Type: {MaterialType}");
        Console.WriteLine($"Return Option within a Week: {return_cloth}");
    }
}

// Kids class
public class Kids : Cloth
{
    public int Size { get; set; }
    public string return_cloth = "NO";

    public Kids(int id, int size) : base(id)
    {
        Size = size;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"KID Cloth ID: {ID}");
        Console.WriteLine($"Size: {Size}");
        Console.WriteLine($"Return Option: {return_cloth}");
    }
}

