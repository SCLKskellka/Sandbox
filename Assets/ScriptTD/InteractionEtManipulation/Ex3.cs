using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InteractionEtManipulation
{
    public class Ex3 : MonoBehaviour
    {
        public int Speed = 5;
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
            float horizontalValue = Input.GetAxis("Horizontal") * Speed;
            float verticalValue = Input.GetAxis("Vertical") * Speed;
            
            transform.Translate(horizontalValue + Time.deltaTime, 0, verticalValue + Time.deltaTime);
        }
    }
}

