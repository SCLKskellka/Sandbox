using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VariablesEtOperateursrateurs
{
    public class Exo5 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            int five = 5;
            int seven = 7;
            bool fiveIsGreaterThanSeven = five > seven;
            bool fiveIsLesserThanSeven = five < seven;
            bool sevenIsGreaterThanFive = seven > five;
            bool sevenIsLesserThanFive = seven < five;
            bool fiveIsEqualToSeven = five == seven;
            bool fiveIsNotEqualToSeven = five != seven;
            Debug.Log("5 est plus grand que 7 : " + fiveIsGreaterThanSeven + " 5 est plus petit que 7 : " + fiveIsLesserThanSeven + " 7 est plus grand que 5 : " + sevenIsGreaterThanFive + " 7 est plus petit que 5 : " + sevenIsLesserThanFive + " 5 est égale à 7 : " + fiveIsEqualToSeven + " 5 n'est pas égale à 7 : " + fiveIsNotEqualToSeven + " ." );

        }
    }
}

