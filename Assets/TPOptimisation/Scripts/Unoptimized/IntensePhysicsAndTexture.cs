using System.Collections.Generic;
using UnityEngine;

public class IntensePhysicsAndTexture : MonoBehaviour
{
    public GameObject SpherePrefab;
    public Texture[] Textures;
    private List<GameObject> _spheres = new List<GameObject>();

    void Start()
    {
        for (int i = 0; i < 500; i++)
        {
            GameObject sphere = Instantiate(SpherePrefab);
            sphere.transform.position = new Vector3(Random.Range(-50, 50), Random.Range(-50, 50), Random.Range(-50, 50));
            _spheres.Add(sphere);
        }
    }

    void Update()
    {
        foreach (GameObject sphere in _spheres)
        {
            Renderer renderer = sphere.GetComponent<Renderer>();
            renderer.material = new Material(renderer.material);
            renderer.material.mainTexture = Textures[Random.Range(0, Textures.Length)];

            Rigidbody rb = sphere.GetComponent<Rigidbody>();
            rb.AddExplosionForce(500, Vector3.zero, 10);
        }
    }
}