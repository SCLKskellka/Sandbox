using System;
using UnityEngine;

namespace EnumerationsEtSwitch.Scripts {
	public class Ex2 : MonoBehaviour {

		public enum AstrologicalSign {
			Capricornus,
			Aquarius,
			Pisces,
		}
		
		public enum Months {
			January,
			February,
			March,
			December
		}

		[Range(1, 31)] public int BirthDay;
		public Months BirthMonth;
		
		private void Start() {
			AstrologicalSign mySign = WhatIsMySign(BirthDay, BirthMonth);
			Debug.Log(mySign.ToString());
		}

		private AstrologicalSign WhatIsMySign(int birthDay, Months birthMonth) {
			// Operator && takes priority over operator ||
			if (birthDay >= 22 && birthMonth == Months.December 
			    || birthDay <= 19 && birthMonth == Months.January) {
				return AstrologicalSign.Capricornus;
			}
			if (birthDay >= 20 && birthMonth == Months.January 
			    || birthDay <= 18 && birthMonth == Months.February) {
				return AstrologicalSign.Aquarius;
			}
			if (birthDay >= 19 && birthMonth == Months.February 
			    || birthDay <= 20 && birthMonth == Months.March) {
				return AstrologicalSign.Pisces;
			}
			// This is an exception, it throw an error if the program come here
			throw new Exception("Sorry, i don't know...");
		}

	}
}