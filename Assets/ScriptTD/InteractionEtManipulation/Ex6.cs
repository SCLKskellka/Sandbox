using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InteractionEtManipulation
{
    public class Ex6 : MonoBehaviour
    {
        public int Force = 3;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (Input.GetButtonDown("Jump"))
            {
                GetComponent<Rigidbody>().AddForce(transform.up * Force, ForceMode.Impulse);
            }
        }
    }
}

