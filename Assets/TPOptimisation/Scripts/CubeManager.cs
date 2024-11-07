using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class CubeManager : MonoBehaviour
{
    public GameObject CubePrefab;
    private readonly List<GameObject> _cubes = new();

    private void Start()
    {
        for (var i = 0; i < 500; i++)
        {
            var cube = Instantiate(CubePrefab);
            cube.transform.position = new Vector3(Random.Range(-50, 50),
                Random.Range(-50, 50), Random.Range(-50, 50));
            _cubes.Add(cube);
        }
    }

    private void Update()
    {
        foreach (var cube in _cubes)
        {
            var renderer = cube.GetComponent<Renderer>();
            renderer.material.color = new Color(Random.value,
                Random.value, Random.value);
            cube.transform.Rotate(Vector3.up, 10 * Time.deltaTime);
        }
    }
}