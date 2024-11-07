using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace TPOptimisation.Scripts.Optimized
{
    public class OptimizedComplexDataAndPhysics : MonoBehaviour
    {
        public int InstantiationNumber;
        public GameObject ParticlePrefab;
        private List<GameObject> _particles = new List<GameObject>();
        private List<Rigidbody> _particleRigidbodies= new List<Rigidbody>();
        
        void Update()
        {
            for (int i = 0; i < InstantiationNumber; i++)
            {
                GameObject particle = Instantiate(ParticlePrefab);
                particle.transform.position = new Vector3(Random.Range(-100, 100), Random.Range(-100, 100), Random.Range(-100, 100));
                _particles.Add(particle);
                _particleRigidbodies.Add(particle.GetComponent<Rigidbody>());
            }

            for (int i = 0; i < _particles.Count; i++)
            {
                _particleRigidbodies[i].AddTorque(Random.onUnitSphere * 1000);
                _particleRigidbodies[i].AddExplosionForce(1000, Vector3.zero, 20);
            }

            if (_particles.Count > 1000)
            {
                Destroy(_particles[0]);
                _particles.RemoveAt(0);
                _particleRigidbodies.RemoveAt(0);
            }
        }
    }
}