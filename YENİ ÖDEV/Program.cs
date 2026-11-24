using System;

// 1. Yakıt türleri
enum FuelType
{
    Petrol,
    Diesel,
    Electric
}

// 2. Ana Sınıf (Vehicle)
class Vehicle
{
    public string Brand;
    public string Model;
    public int Year;
    public FuelType Fuel;

    // 6. Araç sayacı
    public static int Count = 0;

    // Constructor (Kurucu metot)
    public Vehicle(string brand, string model, int year, FuelType fuel)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Fuel = fuel;
        Count++; // Her araç üretildiğinde sayıyı 1 artır
    }

    // 3. Genel motor çalıştırma metodu
    public virtual void StartEngine()
    {
        Console.WriteLine("Vehicle engine started.");
    }

    // 5. Bilgi döndüren metot -> Örnek: Togg T10X (2024, Electric)
    public string Info()
    {
        return Brand + " " + Model + " (" + Year + ", " + Fuel + ")";
    }
}

// 4. Alt Sınıflar (Car, Truck, Motorcycle)
class Car : Vehicle
{
    public Car(string brand, string model, int year, FuelType fuel) : base(brand, model, year, fuel) { }

    public override void StartEngine()
    {
        Console.WriteLine("Car engine started.");
    }
}

class Truck : Vehicle
{
    public Truck(string brand, string model, int year, FuelType fuel) : base(brand, model, year, fuel) { }

    public override void StartEngine()
    {
        Console.WriteLine("Truck engine started.");
    }
}

class Motorcycle : Vehicle
{
    public Motorcycle(string brand, string model, int year, FuelType fuel) : base(brand, model, year, fuel) { }

    public override void StartEngine()
    {
        Console.WriteLine("Motorcycle engine started.");
    }
}

// Ana Program
class Program
{
    static void Main()
    {
        // 7. Araç dizisi (fleet)
        Vehicle[] fleet = {
            new Car("Togg", "T10X", 2024, FuelType.Electric),
            new Truck("Volvo", "FH16", 2022, FuelType.Diesel),
            new Motorcycle("Honda", "CBR", 2023, FuelType.Petrol)
        };

        // Tüm araçları yazdır ve çalıştır
        foreach (Vehicle v in fleet)
        {
            Console.WriteLine(v.Info());
            v.StartEngine();
        }

        // Toplam araç sayısını yazdır
        Console.WriteLine("Total vehicles: " + Vehicle.Count);
    }
}