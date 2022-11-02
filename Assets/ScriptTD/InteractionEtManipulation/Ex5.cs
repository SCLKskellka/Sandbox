using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InteractionEtManipulation
{
    public class Ex5 : MonoBehaviour
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
            float mouseYValue = Input.GetAxis("Mouse Y") * Speed;
            transform.Rotate(mouseYValue + Time.deltaTime, 0, 0);
        }
    }
}

