using System;

namespace MscGyak.model;

public class AutoBaleset : Baleset
{
    public int KeletkezettKar;
    public String Felelos;

    public override int[] GridKalkulator()
    {
        return base.GridKalkulator();
    }
}