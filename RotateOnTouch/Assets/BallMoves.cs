using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class BallMoves : MonoBehaviour {

	public float moveSpeed = 2;
	public float invert = 100;
	private float pinvert = 100;
	public bool playing = false;
	private Rigidbody rg;
	private float deltaSpeed = 100;
	public bool fire1 = false;
	public Vector2 acumulator = new Vector2();

	// Use this for initialization
	void Start () {
		rg = GetComponentInChildren<Rigidbody> ();
		StartCoroutine(WaitASec(1.0F));
		pinvert = invert;
	}
	
	// Update is called once per frame
	void Update () {
		if (playing) {


//				if (Input.GetButtonDown("Fire1")) {
//					fire1 = true;
//				}

//				if (Input.GetButtonUp("Fire1")) {
//					fire1 = false;
//				}

//				if (Input.GetMouseButtonDown(0)) {
//					fire1 = true;
//					Debug.Log("Mouse 0 Down");
//				}
//
//
//				if (Input.GetMouseButtonUp(0)) {
//					fire1 = false;
//				}
			
			//				if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) {
//					rg.AddForce (Vector3.forward * moveSpeed*deltaSpeed * Time.deltaTime);
//				}
				
				if (fire1) {
					rg.AddForce (Vector3.forward * moveSpeed * deltaSpeed * Time.deltaTime);
				}

				if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) {
					Vector2 touchDelta = Input.GetTouch(0).deltaPosition;
					Vector2 rotateDelta = new Vector2(touchDelta.x*180/80, touchDelta.y*180/40);
					transform.Rotate(rotateDelta.x, rotateDelta.y, 0, Space.Self);
					acumulator += touchDelta;
					Debug.Log(acumulator);
				}

				//transform.Rotate (Vector3.forward * moveSpeed*2*Mathf.PI * Time.deltaTime);
			
				pinvert--;

				if (pinvert < 0) {
						pinvert = invert;
						moveSpeed = moveSpeed * -1;
						if (moveSpeed<0) {
							deltaSpeed = 68.3f;
						} else {
							deltaSpeed = 100f;
						}
				}
		}
	}


	IEnumerator WaitASec(float waitTime){
		yield return new WaitForSeconds(waitTime);
		playing = true;
	}
}