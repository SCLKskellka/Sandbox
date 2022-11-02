using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameLoopEtHierarchie
{
    public class Ex1 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            
            Debug.Log("Update time : " + Time.deltaTime );
        }

        private void FixedUpdate()
        {
            
            Debug.Log("FixedUpdate time : " + Time.deltaTime );
        }
    }
}

