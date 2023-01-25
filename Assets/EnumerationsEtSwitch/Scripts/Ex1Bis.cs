using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex1Bis : MonoBehaviour
{
    public enum Vegetal
    {
        artichaut, pomme, noix, tomate, oignon, betterave, fenouil, courgette
    }

    public Vegetal CurrentVegetal;

    private void Start()
    {
        if (CurrentVegetal == Vegetal.oignon || CurrentVegetal == Vegetal.fenouil)
        {
            Debug.Log("C'est un légume");
            
        }
        else
        {
            Debug.Log("C'est un fruit");
        }
    }
}
