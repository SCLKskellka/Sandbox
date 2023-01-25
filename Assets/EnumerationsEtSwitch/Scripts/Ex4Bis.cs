using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex4Bis : MonoBehaviour
{
    public enum Type
    {
        RTS,TPS,RPG,FPS,VN,MMO
    }

    public Type currentType;
    private void Start()
    {
        switch (currentType)
        {
            case Type.VN:
                Debug.Log("Jeu de lecture");
                break;
            case Type.MMO:
                Debug.Log("Jeu massivement multijoueur");
                break;
            case Type.FPS:
            case Type.TPS:
                Debug.Log("Jeu de tir");
                break;
            case Type.RPG:
                Debug.Log("Jeu d'aventure");
                break;
            case Type.RTS:
                Debug.Log("Jeu de stratégie");
                break;
            default:
                Debug.Log("Type inexistant");
                break;
        }
    }
}
