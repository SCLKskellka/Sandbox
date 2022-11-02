using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MethodesEtConditions
{
    public class Ex3 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            int magicNumberOne = getMagicNumber(10, 16);
            int magicNumberTwo = getMagicNumber(20, 5);
            int magicNumberThree = getMagicNumber(12, 12);
            
            Debug.Log("1er Nombre Magique : " + magicNumberOne + " 2eme Nombre Magique : "+ magicNumberTwo +" 1er Nombre Magique : " + magicNumberThree);
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        int getMagicNumber(int a, int b)
        {
            if (a < b)
            {
                return b;
            }
            if(a > b)
            {
                return a -b;
            }

            return 42;
        }
    }
}

