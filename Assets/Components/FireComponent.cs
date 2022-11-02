using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireComponent : MonoBehaviour
{
    public GameObject AmmoPrefab;

    public int FirePower;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fire()
    {
        GameObject ammoShot = Instantiate(AmmoPrefab, transform.position, Quaternion.identity);
        ammoShot.GetComponent<Rigidbody>().AddForce(-transform.right * FirePower, ForceMode.Impulse);
    }
}
