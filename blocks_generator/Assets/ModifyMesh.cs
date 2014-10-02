using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ModifyMesh : MonoBehaviour {


	void Start() {
		Mesh mesh = GetComponent<MeshFilter>().mesh;
		mesh.Clear ();

		mesh.Clear();
		mesh.vertices = new Vector3[] {new Vector3(0, 0, 0), new Vector3(0, 1, 0), new Vector3(1, 1, 0), new Vector3(1, 0, 0)};


		float uvC = 0.33f;
		float uvW = 0.33f;

		//mesh.uv = new Vector2[] {new Vector2(uvS, 0), new Vector2(0, uvS), new Vector2(uvS, 0.uvS), new Vector2(uvS, 0)};
		mesh.triangles = new int[] {0, 1, 2, 
			                        0, 2, 3/*, 2, 1, 0*/};
		
	}
	
	void Update() {
		Mesh mesh = GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		int i = 0;
		while (i < vertices.Length) {
			vertices[i] += Vector3.up * Time.deltaTime;
			i++;
		}
		mesh.vertices = vertices;
		mesh.RecalculateBounds();
	}
}