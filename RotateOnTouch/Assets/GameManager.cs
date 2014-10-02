using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public Vector2 lastDelta;
	public float lastDX = 0f;
	public float lastDY = 0f;
	public int touchCount = 0;
	public bool fire1 = false;
	public Vector2 touchBegan;
	public Vector2 touchMoved;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		this.touchCount = Input.touchCount;
		this.fire1 = Input.GetButtonDown ("Fire1");


		if (Input.touchCount > 0){
			switch (Input.GetTouch(0).phase) {
			case TouchPhase.Began:
				touchBegan = Input.GetTouch(0).position;
				break;
			case TouchPhase.Moved:
				touchMoved = Input.GetTouch(0).position;
				lastDelta = (touchBegan-touchMoved);
				lastDX = lastDelta.x;
				lastDY = lastDelta.y;
				break;
			}
		}
	}
}
