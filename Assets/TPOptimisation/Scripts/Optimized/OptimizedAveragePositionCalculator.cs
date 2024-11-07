using System.Collections.Generic;
using UnityEngine;

namespace TPOptimisation.Scripts.Optimized
{
    public class OptimizedAveragePositionCalculator : MonoBehaviour
    {
        private List<GameObject> _objects = new List<GameObject>();

        public Vector3 AveragePosition
        {
            get
            {
                Vector3 sum = Vector3.zero;
                for (int i = 0; i < _objects.Count; i++)
                {
                    GameObject obj = _objects[i];
                    sum += obj.transform.position;
                }
                return sum / _objects.Count;
            }
        }
    
        void Start()
        {
            // Création de plusieurs objets autour de la scène
            for (int i = 0; i < 100; i++)
            {
                GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
                obj.transform.position = new Vector3(Random.Range(-50, 50), Random.Range(-50, 50), Random.Range(-50, 50));
                _objects.Add(obj);
            }
        }
    
        void Update()
        {
            // Accès fréquent à AveragePosition
            Debug.Log("Average Position: " + AveragePosition);
        }
    }
}