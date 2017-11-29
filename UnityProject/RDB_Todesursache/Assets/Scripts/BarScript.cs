using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngineInternal;

public class BarScript : MonoBehaviour {
	public float max;
	public float highest;
	private float n = 0;
	private Renderer render;
	private Color farbe;
	// Use this for initialization
	void Start () {
		this.transform.localScale = new Vector3 (0f, 0f, 0f);
		render = GetComponent<Renderer> ();	
	}
	// Update is called once per frame
	void Update () {
		this.transform.localScale = new Vector3 (3f, n, 3f);
		this.transform.position = new Vector3 (this.transform.position.x, n / 2 , this.transform.position.z);
		if(n < max){
			n = n + 0.1f;

			farbe = Color.HSVToRGB(n*(1/highest) , 1f, 1f);
			render.material.color = farbe;
		}
	}
}
