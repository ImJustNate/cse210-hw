class Costume
{
    //atrebute (member varibales)
    public string headWear;
    public string gloves;
    public string shoes;
    public string shirt;
    public string pants;
    public string accessory;

    public void ShowWardroab()
    {
        string result = "";

        result += "headWear " + headWear;
        result += "\ngloves " + gloves;
        result += "\nshoes " + shoes;
        result += "\nshirt " + shirt;
        result += "\npants " + pants;
        result += "\naccessory " + accessory;
        
        Console.WriteLine(result + "\n");

    }
}