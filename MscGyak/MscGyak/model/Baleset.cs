using System;

public class Baleset
{
    public int[] Koordinata;
    public DateTime Datum;
    public bool SerulesTortent;
    public int Fokozat;

    public Baleset()
    {
        this.Datum = DateTime.Now;
    }

    public Baleset(int[] koordinata)
    {
        Koordinata = koordinata;
    }

    public Baleset(int[] koordinata, int fokozat)
    {
        Koordinata = koordinata;
        Fokozat = fokozat;
    }

    public virtual int[] GridKalkulator()
    {
        return Koordinata;
    }
}

