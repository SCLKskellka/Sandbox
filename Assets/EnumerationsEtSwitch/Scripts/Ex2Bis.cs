using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex2Bis : MonoBehaviour
{
   public enum Vacances
   {
      Rentré,
      VacancesDeLaToussaint,
      VacancesDeNoel,
      VacancesDhiver,
      VacancesDePrintemps,
      PontDeLAscension,
      VacancesEte,
      
   }
   
   public enum Mois
   {
      Janvier,
      Fevrier,
      Mars,
      Avril,
      Mai,
      Juin,
      Juillet,
      Aout,
      Septembre,
      Octobre,
      Novembre,
      Decembre
   }

   [Range(1, 31)] public int jour;
   public Mois currentMonth;

   private void Start()
   {
      Vacances mesVacances = quelVacances(jour,currentMonth );
      Debug.Log(mesVacances.ToString());
   }

   private Vacances quelVacances(int x, Mois y)
   {
      if (x == 2 && y == Mois.Septembre)
      {
         return Vacances.Rentré;
      }
      
      if (x >= 23 && y == Mois.Octobre || x <= 8 && y == Mois.Novembre)
      {
         return Vacances.VacancesDeLaToussaint;
      }
      
      if (x >= 18 && y == Mois.Decembre || x <= 3 && y == Mois.Janvier)
      {
         return Vacances.VacancesDeNoel;
      }
      
      if (x >= 5 && y == Mois.Fevrier || x <= 21 && y == Mois.Fevrier)
      {
         return Vacances.VacancesDhiver;
      }
      
      if (x >= 9 && y == Mois.Avril || x <= 25 && y == Mois.Avril)
      {
         return Vacances.VacancesDePrintemps;
      }
      if (x >= 25 && y == Mois.Mai || x <= 30 && y == Mois.Mai)
      {
         return Vacances.PontDeLAscension;
      }
      if (x >= 7 && y == Mois.Juillet || x <= 1 && y == Mois.Septembre)
      {
         return Vacances.VacancesEte;
      }

      throw new Exception("Pas en vacance");
   }
}
