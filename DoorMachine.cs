using System;
using System.Runtime.CompilerServices;

public enum doorState
{
    Terkunci, Terbuka
}

public class DoorMachine
{
    private doorState state = doorState.Terkunci;

    public void kunci()
    {
        if (state == doorState.Terbuka)
        {
            state = doorState.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
        else
        {
            Console.WriteLine("Pintu sudah terkunci");
        }
    }

    public void buka()
    {
        if (state == doorState.Terkunci)
        {
            state = doorState.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }
        else
        {
            Console.WriteLine("Pintu terbuka");
        }
    }

    public DoorMachine()
    {
    }
}