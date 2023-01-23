using UnityEngine;

namespace ScriptTD.BouclesEtCollections
{
    public class Ex1 : MonoBehaviour
    {
        
        void Start()
        {
            int repeatNumber = 8;
            string message = ("Hello world !");
            while (repeatNumber > 0)
            {
                Debug.Log(message + " " + repeatNumber);
                repeatNumber--;
            }
        }
    }
}
