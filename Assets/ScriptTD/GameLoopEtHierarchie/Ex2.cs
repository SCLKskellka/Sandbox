using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameLoopEtHierarchie
{
    public class Ex2 : MonoBehaviour
    {
        private void Awake()
        {
            Debug.Log("I'm awake !");
        }

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("I start !");
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        private void OnEnable()
        {
            Debug.Log("I'm enabled !");
        }

        private void OnDisable()
        {
            Debug.Log("I'm disabled !");
        }

        private void OnDestroy()
        {
            Debug.Log("I'm destroyed !");
        }
    }
}

