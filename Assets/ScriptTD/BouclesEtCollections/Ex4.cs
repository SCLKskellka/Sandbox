using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptTD.BouclesEtCollections
{
    public class Ex4 : MonoBehaviour
    {
        private void Start()
        {
            List<string> NameList = new List<string>();
            NameList.Add("Christopher");
            NameList.Add("Toto");
            NameList.Add("Goku");
            foreach (string x in NameList)
            {
                Debug.Log(x);
            }
        }
    }
}
