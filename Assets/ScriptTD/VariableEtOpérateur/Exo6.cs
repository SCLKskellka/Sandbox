using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VariablesEtOperateursrateurs
{
    public class Exo6 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            bool isCatAlive = true;
            bool isMouseAlive = !isCatAlive;
            bool isSomeOneAlive = isCatAlive || isMouseAlive;
            bool isEveryOneAlive = isCatAlive && isMouseAlive;
            
            Debug.Log("Le chat est vivant : " + isCatAlive + " La souris est vivante : " + isMouseAlive + " Quelqu'un est vivant : " + isSomeOneAlive + " Tout le monde est vivant : " + isEveryOneAlive );
        }

    }
}

