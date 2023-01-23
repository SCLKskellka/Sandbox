using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptTD.BouclesEtCollections
{
    public class Ex6 : MonoBehaviour
    {
        public List<GameObject> GameObjectToColorList = new List<GameObject>();
        public GameObject GameObjectToRemove;

        private void Start()
        {
            GameObjectToColorList.Remove(GameObjectToRemove);
            foreach (GameObject x in GameObjectToColorList)
            {
                MeshRenderer meshRendComp = x.GetComponent<MeshRenderer>();
                meshRendComp.material.color = Color.red;
            }
        }
    }
}
