using UnityEngine;
// ReSharper disable UnreachableSwitchCaseDueToIntegerAnalysis

namespace EnumerationsEtSwitch.Scripts {
	public class Ex3 : MonoBehaviour {

		public int Age;
		
		private void Start() {
			switch (Age) {
				case 6:
					Debug.Log("CP");
					break;
				case 7:
					Debug.Log("CE1");
					break;
				case 8:
					Debug.Log("CE2");
					break;
				case 9: 
					Debug.Log("CM1");
					break;
				case 10:
					Debug.Log("CM2");
					break;
				default:
					Debug.Log("Not in primary school");
					break;
			}
		}
		
	}
}