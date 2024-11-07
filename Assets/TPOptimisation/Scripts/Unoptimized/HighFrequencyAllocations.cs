using UnityEngine;

public class HighFrequencyAllocations : MonoBehaviour
{
    public GameObject CubePrefab;
    private GameObject[] _cubes;

    void Start()
    {
        _cubes = new GameObject[1000];
        for (int i = 0; i < _cubes.Length; i++)
        {
            GameObject cube = Instantiate(CubePrefab);
            cube.transform.position = new Vector3(Random.Range(-100, 100), Random.Range(-100, 100), Random.Range(-100, 100));
            _cubes[i] = cube;
        }
    }

    void Update()
    {
        for (int i = 0; i < _cubes.Length; i++)
        {
            Renderer renderer = _cubes[i].GetComponent<Renderer>();
            renderer.material.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}