using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace MethodesEtConditions
{
    public class Ex5 : MonoBehaviour
    {
        public int Days = 1;
        public int Weeks = 1;
        public int Months = 1;
        public int Years = 1;

        public float TimeScale = 0.1f;
        public float DayTime = 0f;
        public float WeekTime = 1f;
        
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        void FixedUpdate()
        {
            DayTime = TimeScale + DayTime;
            WeekTime = TimeScale + WeekTime;
            
            if (DayTime >= Days)
            {
                Days++;
                DayTime = 0f;
            }

            if (WeekTime >= Weeks)
            {
                Weeks++;
                WeekTime = 1f;
            }

            if (Days >= 31)
            {
                Months++;
                Days = 1;
            }

            if (Months >= 13)
            {
                Years ++;
                Months = 1;
            }
        }
    }
}

