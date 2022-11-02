using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameLoopEtHierarchie
{
    public class ColoredCollisionComponent : MonoBehaviour
    {
        public Color ColisionColor;

        private Color _baseColor;

        private void Awake()
        {
            MeshRenderer meshRendComp = GetComponent<MeshRenderer>();
            Material material = meshRendComp.material;
            _baseColor = material.color;
            /*
             * autre méthode --> _basecolor = GetComponent<MeshRenderer>().material.color; 
             */
        }

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private void OnTriggerEnter()
        {
            GetComponent<MeshRenderer>().material.color = ColisionColor;
        }

        private void OnTriggerExit()
        {
            GetComponent<MeshRenderer>().material.color = _baseColor;
        }
    }
}

