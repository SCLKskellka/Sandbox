using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex5Bis : MonoBehaviour
{
   [Flags]
   public enum Couleur
   {
      None=0,
      Rouge=1,
      Vert=2,
      Bleu=4
   }

   public Couleur CurrentCouleur;

   private void Start()
   {
      switch (CurrentCouleur)
      {
         case Couleur.Rouge | Couleur.Bleu:
            Debug.Log("Magenta");
            break;
         case Couleur.Rouge | Couleur.Vert:
            Debug.Log("Jaune");
            break;
         case Couleur.Vert | Couleur.Bleu:
            Debug.Log("Cyan");
            break;
         case Couleur.Rouge | Couleur.Bleu | Couleur.Vert:
            Debug.Log("Blanc");
            break;
         default:
            Debug.Log(CurrentCouleur);
            break;
      }
   }
}
