using System.Collections.Generic;
using UnityEngine;

namespace TPOptimisation.Scripts.Optimized
{
    public class OptimizedHeavyProcessing : MonoBehaviour
    {
        public GameObject SpherePrefab;
        private GameObject[] _spheres;
        private int _objectCount = 5000;

        void Start()
        {
            _spheres = new GameObject[_objectCount];
            for (int i = 0; i < _objectCount; i++)
            {
                GameObject sphere = Instantiate(SpherePrefab);
                sphere.transform.position = new Vector3(Random.Range(-50, 50), Random.Range(-50, 50), Random.Range(-50, 50));
                _spheres[i] = sphere;
            }
        }

        void Update()
        {
            for (int i = 0; i < _spheres.Length; i++)
            {
                _spheres[i].transform.Rotate(Vector3.up, Random.Range(0, 360) * Time.deltaTime);
                Vector3 scale = _spheres[i].transform.localScale;
                scale.x = Mathf.PingPong(Time.time, 3);
                _spheres[i].transform.localScale = scale;
            }
        }
    }
}