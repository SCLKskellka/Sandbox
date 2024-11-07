using System.Collections.Generic;
using UnityEngine;

public class HeavyProcessing : MonoBehaviour
{
    public GameObject SpherePrefab;
    private List<GameObject> _spheres = new List<GameObject>();
    private int _objectCount = 5000;

    void Start()
    {
        for (int i = 0; i < _objectCount; i++)
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
            sphere.transform.Rotate(Vector3.up, Random.Range(0, 360) * Time.deltaTime);
            Vector3 scale = sphere.transform.localScale;
            scale.x = Mathf.PingPong(Time.time, 3);
            sphere.transform.localScale = scale;
        }
    }
}