using System;
using System.Runtime.CompilerServices;

public class KodePos
{
    private static Dictionary<string, string> kode2 = new Dictionary<string, string>
    {
        {"Batununggal", "40266"},
        {"Kujangsari", "40287"},
        {"Mengger", "40267"},
        {"Wates", "40256"},
        {"Cijaura", "40287"},
        {"Jatisari", "40286"},
        {"Margasari", "40286"},
        {"Sekejati", "40286"},
        {"Kebonwaru", "40272"},
        {"Maleer", "40274"},
        {"Samoja", "40273"},
    };

    //public void setKodePos(string kodePos)
    //{
    //    this.kodePos = kodePos;
    //}

    public string getKodePos(string keluharan)
    {
        if (kode2.ContainsKey(keluharan))
        {
            return kode2[keluharan];
        }
        return null;
    }
}
