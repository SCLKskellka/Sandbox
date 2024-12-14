using UnityEngine;

namespace TestPre_baking
{
    public class SpawnPrefabs2xX : MonoBehaviour
    {
        public GameObject[] prefab;
        void Start()
        {
            int x = 0;
        
            for (int i = 0; i < prefab.Length; i++)
            {
                if(i%2==0)
                    Instantiate(prefab[i],new Vector3(i*20,0,x*20),Quaternion.identity);
                else
                {
                    Instantiate(prefab[i],new Vector3(x*20,0,(x+1)*20),Quaternion.identity);
                    x++;
                }
            }
        }

   
    }
}
