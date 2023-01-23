using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptTD.BouclesEtCollections
{
    public class Ex3 : MonoBehaviour
    {
        public List<string> Names = new List<string>{};

        private void Start()
        {
            for (int i = 0; i < Names.Count; i++)
            {
                Debug.Log(Names[i]);
            }
        }
    }
}
