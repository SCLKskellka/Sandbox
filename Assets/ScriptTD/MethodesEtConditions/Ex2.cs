using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MethodesEtConditions
{
    public class Ex2 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            displayTemperatureFeeling(10);
            displayTemperatureFeeling(18);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        
        void displayTemperatureFeeling( int waterTemp)
        {
            if (waterTemp < 14)
            {
                Debug.Log("It too cold ! ");
            }
            else
            {
                Debug.Log("It too hot ! ");
            }

            return;
        }
    }
}

