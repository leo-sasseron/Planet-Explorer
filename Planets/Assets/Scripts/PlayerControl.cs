using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	public Navigation nav;
	public GameObject[] listaPlanetas;

	void Update() {

		if (Input.anyKeyDown) {
			
			try {
				int i = int.Parse (Input.inputString);

				if (i > 0 && i <= 9)
					nav.PlanetToGo = listaPlanetas [i - 1];
			}

			catch {

			}
		
		}

		if (Input.GetKeyDown (KeyCode.Alpha0)) {

			nav.PlanetToGo = null;
		}
	}
}
