using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InteractionEtManipulation
{
    public class Ex1 : MonoBehaviour
    {
        public Color LeftClickColor;
        public Color RightClickColor;
        
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                 GetComponent<MeshRenderer>().material.color = LeftClickColor;
            }
            if (Input.GetButtonDown("Fire2"))
            {
                 GetComponent<MeshRenderer>().material.color = RightClickColor;
            }
        }
    }
}

