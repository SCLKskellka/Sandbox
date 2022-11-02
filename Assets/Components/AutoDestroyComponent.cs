using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroyComponent : MonoBehaviour
{
    public float TimeBeforeDestroy = 2f;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyThis", TimeBeforeDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void DestroyThis()
    {
        Destroy(gameObject);
    }
}
