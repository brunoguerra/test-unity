using UnityEngine;
using System.Collections;

public class GuiDisplay : MonoBehaviour {
	public GameManager mn;

	// Update is called once per frame
	void OnGUI() {
		GUI.Label(new Rect(10, 10, 100, 20), "DX: "+ mn.lastDX);
		GUI.Label(new Rect(10, 24, 100, 20), "DY: "+mn.lastDY);
		GUI.Label(new Rect(10, 38, 100, 20), "Touch count: "+mn.touchCount);

		string fire1T = mn.fire1 ? "Sim" : "Não"; 

		GUI.Label(new Rect(10, 50, 100, 20), "Fire1: "+fire1T);
	}
}
