using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataScript : MonoBehaviour {
	public static DataScript instance; 
	public int[] strArray = new int[100]; 
	// Use this for initialization
	void Start () {
		instance = this;
		catchData ();
	}

	void catchData(){
		//toDo
	}
}
