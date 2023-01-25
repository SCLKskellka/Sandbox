using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex3Bis : MonoBehaviour
{
    public int Age;

    private void Start()
    {
        switch (Age)
        {
            case 11:
                Debug.Log("6ème");
                break;
            case 12:
                Debug.Log("5ème");
                break;
            case 13:
                Debug.Log("4ème");
                break;
            case 14:
                Debug.Log("3ème");
                break;
            default:
                Debug.Log("Pas au collège.");
                break;
        }
    }
}
