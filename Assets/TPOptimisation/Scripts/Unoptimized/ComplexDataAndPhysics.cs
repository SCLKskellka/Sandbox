using System.Collections.Generic;
using UnityEngine;

namespace TPOptimisation.Scripts.Unoptimized
{
    public class ComplexDataAndPhysics : MonoBehaviour
    {
        public int InstantiationNumber;
        public GameObject ParticlePrefab;
        private List<GameObject> _particles = new List<GameObject>();

        void Update()
        {
            _particles.Clear();
            for (int i = 0; i < InstantiationNumber; i++)
            {
                GameObject particle = Instantiate(ParticlePrefab);
                particle.transform.position = new Vector3(Random.Range(-100, 100), Random.Range(-100, 100), Random.Range(-100, 100));
                _particles.Add(particle);
            }

            foreach (GameObject particle in _particles)
            {
                Rigidbody rb = particle.GetComponent<Rigidbody>();
                rb.AddTorque(Random.onUnitSphere * 1000);
                rb.AddExplosionForce(1000, Vector3.zero, 20);
            }

            if (_particles.Count > 1000)
            {
                Destroy(_particles[0]);
                _particles.RemoveAt(0);
            }
        }
    }
}