using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InteractionEtManipulation
{
    public class Ex4 : MonoBehaviour
    {
        public int Speed = 100;
        
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private void FixedUpdate()
        {
            float mouseXValue = Input.GetAxis("Mouse X") * Speed;
            
            transform.Rotate(0,mouseXValue + Time.deltaTime, 0);
        }
    }
}

