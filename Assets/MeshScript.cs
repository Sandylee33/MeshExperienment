using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshScript: MonoBehaviour {

	// Use this for initialization
	void Start () {
        Mesh mesh = new Mesh();

        Vector3[] vertices = new Vector3[3];

        vertices[1] = new Vector3(0,0,0);
        vertices[2] = new Vector3(0,0,1);
        vertices[0] = new Vector3(0,1,0);
        mesh.vertices = vertices;

        int[] trangles = new int[3]{1,2,0}; 
        mesh.triangles = trangles;
        GetComponent<MeshFilter>().mesh = mesh;

	}
	

}
