class Program
{
    static void Main(string[] args)
    {
        List<Costume> myCostumes = new List<Costume>();
        Costume detective = new Costume();
        detective._headwear = "fedora";
        detective._upperGarment = "trenchcoat";
        detective._lowerGarment = "slacks";
        detective._footwear = "dress shoes";
        detective._accessories = "revolver";
        myCostumes.Add(detective);

        Costume nurse = new Costume();
        nurse._headwear = "hair net";
        nurse._upperGarment = "scrubs";
        nurse._lowerGarment = "scrubs";
        nurse._footwear = "running shoes";
        nurse._accessories = "stethoscope";
        myCostumes.Add(nurse);

        foreach (Costume c in myCostumes)
        {
            c.Output();
        }
    }
}
