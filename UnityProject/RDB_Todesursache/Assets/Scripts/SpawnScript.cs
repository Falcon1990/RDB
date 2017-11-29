using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {


	private int highest = 10;
	private float[][] data = new float[3][];
	private GameObject spawn;
	private GameObject barPrefab;
	private GameObject theBar;
	private BarScript barScript;
	private int n;
	private float x= 1f , y= 1f , z = 1f;


	// Use this for initialization
	void Start () {
	/*	while (GameObject.Find ("SpawnPoint" + i) != null) {
			i++;
		}
	*/
		for (int d = 0; d < 3; d++ ){
			data [d] = new float[highest];
		}
		for (int k = 0; k < 3; k++ ){
			for (int l = 0; l < 3; l++ ){
				data [k] [l] = Random.Range (1f , 10f);
			}
		}



		for (int i = 0; i < 3; i++ ){
			for (int j = 0; j < 3; j++ ){
				n = (j + (3 * i)); //( j + (10*(i-1))- 1)
				Debug.Log(n);
				if(!GameObject.Find("Bar"+n)){

					spawn = GameObject.Find ("SpawnPoint" + n);

					barPrefab = GameObject.Find ("Bar_Prefab");

					barScript = barPrefab.GetComponent<BarScript> ();
					barScript.max = data[i][j];
					barScript.highest = highest;
		//			theBar.transform.localScale = new Vector3 (x, y, z);
					theBar = Instantiate(barPrefab, spawn.transform.position, Quaternion.identity);
					theBar.name = "Bar" + n;

				}
			}
		}



/*

		for (int d = 0; d < highest; d++ ){
			data [d] = new float[highest];
		}

		for (int k = 0; k < highest; k++ ){
			for (int l = 0; l < highest; l++ ){
				data [k] [l] = Random.Range (-5f , 20f);
			}
		}

		for (int i = 0; i < highest; i++ ){
			for (int j = 0; j < highest; j++ ){
				GameObject theBar = GameObject.Find ("Bar_Prefab");
				BarScript barScript = theBar.GetComponent<BarScript> ();
				barScript.max = data[i][j];
				barScript.highest = highest;
				Instantiate(theBar, new Vector3(i * 2f, 0, j * 2f), Quaternion.identity);

			}
		}
		Debug.Log ("finish");
*/
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
