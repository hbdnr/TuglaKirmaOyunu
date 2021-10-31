using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puan : MonoBehaviour
{
    private int puann;
    public void PuanArttir()
    {
        puann++;
    }

    public int Puanin()
    {
        return puann;
    }

    public void PuanSifirla()
    {
        puann = 0;
    }
}
