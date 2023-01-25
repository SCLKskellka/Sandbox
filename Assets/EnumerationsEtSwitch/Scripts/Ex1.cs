using UnityEngine;

namespace EnumerationsEtSwitch.Scripts {
	public class Ex1 : MonoBehaviour {
		
		public enum Days {
			Monday,
			Tuesday,
			Wednesday,
			Thursday, 
			Friday,
			Saturday, 
			Sunday
		}

		public Days CurrentDay;
		
		private void Start() {
			if (CurrentDay == Days.Saturday || CurrentDay == Days.Sunday) {
				Debug.Log("This is the weekend");
			} else {
				Debug.Log("Still not the weekend");
			}
		}

	}
}