using System;
using UnityEngine;

namespace EnumerationsEtSwitch.Scripts {
	public class Ex5 : MonoBehaviour {

		[Flags]
		public enum Element {
			None = 0,
			Fire = 1,
			Water = 2,
			Earth = 4,
			Air = 8
		}

		public Element CurrentElement;
		
		private void Start() {
			switch (CurrentElement) {
				case Element.Fire | Element.Water:
					Debug.Log("Steam");
					break;
				case Element.Water | Element.Air:
					Debug.Log("Ice");
					break;
				default:
					Debug.Log(CurrentElement);
					break;
			}
		}

	}
}