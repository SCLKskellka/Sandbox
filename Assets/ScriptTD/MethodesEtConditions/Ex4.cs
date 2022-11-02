using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MethodesEtConditions
{
    public class Ex4 : MonoBehaviour
    {
        public int MyAge;
        public string MyName;
        public bool BuyAlcoolinUsa;
        public bool BuyAlcoolinFrance;
        
        // Start is called before the first frame update
        void Start()
        {
            CanIBuyAlcool();
            Debug.Log(MyName + "peu acheter de l'alcool au Usa : " + BuyAlcoolinUsa + ", peu acheter de l'alcool en France : " + BuyAlcoolinFrance);
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        void CanIBuyAlcool()
        {
            if (MyAge >= 21)
            {
                BuyAlcoolinUsa = true;
            }
            else
            {
                BuyAlcoolinUsa = false;
            }
            if (MyAge >= 18)
            {
                BuyAlcoolinFrance = true;
            }
            else
            {
                BuyAlcoolinFrance = false;
            }
            
        }
    }
}

