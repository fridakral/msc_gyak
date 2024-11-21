namespace MscGyak.model;

public class MotorBaleset : Baleset
{
    public int KeletkezettKar;
    public bool Bukosisak;

    public MotorBaleset()
    {

    }

     public MotorBaleset(int[] koordinata)
    {
        Koordinata = koordinata;
    }

    public MotorBaleset(int[] koordinata, int fokozat)
    {
        Koordinata = koordinata;
        Fokozat = fokozat;
    }

    public MotorBaleset (bool bukosisak)
    {
        Bukosisak = bukosisak;
    }
   /*  public override int[] GridKalkulator()
    {
        Console.WriteLine("Ez egy motorbaleset volt");
        return Koordinata;
    }
*/
}