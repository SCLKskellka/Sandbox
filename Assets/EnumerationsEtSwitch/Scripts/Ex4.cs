using UnityEngine;
// ReSharper disable UnreachableSwitchCaseDueToIntegerAnalysis

namespace EnumerationsEtSwitch.Scripts {
	public class Ex4 : MonoBehaviour {
		
		public enum Season {
			Spring,
			Summer,
			Autumn,
			Winter
		}

		public Season CurrentSeason;
		
		private void Start() {
			switch (CurrentSeason) {
				case Season.Spring:
				case Season.Autumn:
					Debug.Log("Time to work");
					break;
				case Season.Summer:
				case Season.Winter:
					Debug.Log("Time to chill");
					break;
				default:
					Debug.Log("This season does not exist");
					break;
			}
		}
		
	}
}