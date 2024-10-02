using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Sandbox World!");
        Costume nurse = new();
        nurse.headWear = "facemask";
        nurse.gloves = "latex";
        nurse.accessory = "stethiscope";
        nurse.pants = "scrubs";
        nurse.shirt = "scrubs";
        nurse.shoes = "sneakers";
        
        Costume detective = new();
        detective.headWear = "fedora";
        detective.gloves = "lether";
        detective.accessory = "magnifying glass";
        detective.pants = "slaks";
        detective.shirt = "trench coat";
        detective.shoes = "loafers";
        
        Costume rancher = new();
        rancher.headWear = "Cowboy hat";
        rancher.gloves = "work";
        rancher.accessory = "lasso";
        rancher.pants = "jeans";
        rancher.shirt = "vest";
        rancher.shoes = "boots";

        nurse.ShowWardroab();
        detective.ShowWardroab();
        rancher.ShowWardroab();

    }

}