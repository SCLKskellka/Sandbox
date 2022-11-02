using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MethodesEtConditions
{
    public class Ex1 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            someUselessMethod();
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        void someUselessMethod()
        {
            Debug.Log("I'm useless");
        }
    }
}

