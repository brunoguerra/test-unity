using UnityEngine;
using System.Collections;

public class MapGenerator : MonoBehaviour {
	public GameObject blockPref;

	// Use this for initialization
	void Start () {
		GameObject block;


		for(int x=-100; x<100; x++) {
			for(int z=-100; z<100; z++) {
				block = (GameObject)Instantiate(blockPref);
				block.transform.localPosition = new Vector3(x*block.transform.localScale.x, 0, z*block.transform.localScale.x);
			}
		}


		for(int x=-90; x<90; x+=10) {
			for(int z=-90; z<90; z+=15) {
				for (int y=5; y>0; y--) {
					block = Instantiate(blockPref, new Vector3(x*blockPref.transform.localScale.x, y, z*blockPref.transform.localScale.x), Quaternion.identity) as GameObject;
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
