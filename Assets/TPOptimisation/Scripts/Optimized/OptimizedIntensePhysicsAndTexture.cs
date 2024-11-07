using UnityEngine;

namespace TPOptimisation.Scripts.Optimized
{
    public class OptimizedIntensePhysicsAndTexture : MonoBehaviour
    {
        public int ObjectNumber;
        public GameObject SpherePrefab;
        public Texture[] Textures;
        private GameObject[] _spheres;
        private Texture[] _spheresTextures;
        private Rigidbody[] _spheresRigidbodies;

        void Start()
        {
            _spheres = new GameObject[ObjectNumber];
            _spheresTextures = new Texture[ObjectNumber];
            _spheresRigidbodies = new Rigidbody[ObjectNumber];
            for (int i = 0; i < ObjectNumber; i++)
            {
                GameObject sphere = Instantiate(SpherePrefab);
                sphere.transform.position = new Vector3(Random.Range(-50, 50), Random.Range(-50, 50), Random.Range(-50, 50));
                _spheres[i] = sphere;
                _spheresTextures[i] = sphere.GetComponent<Renderer>().material.mainTexture;
                _spheresRigidbodies[i] = sphere.GetComponent<Rigidbody>();
            }
        }

        void Update()
        {
            for (int i = 0; i < _spheres.Length; i++)
            {
                _spheresTextures[i] = Textures[Random.Range(0, Textures.Length)];
                _spheresRigidbodies[i].AddExplosionForce(500, Vector3.zero, 10);
            }
        }
    }
}