using UnityEngine;

namespace ScriptTD.BouclesEtCollections
{
    public class Ex2 : MonoBehaviour
    {
        void Start()
        {
            int a = 6;
            int b = 9;
            int result = 0;

            for (int i = 0; i < a; i++)
            {
                result += b;
                Debug.Log("Iteration :" + i + "result : " + result);
            }
        }

    }
}
