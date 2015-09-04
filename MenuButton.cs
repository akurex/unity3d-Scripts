using UnityEngine;
using System.Collections;

public class MenuButton : MonoBehaviour {

	public string level;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//		if (Input.touchCount == 1) {
		
	}


	void OnMouseDown() {
		
			switch(level){
			case "1": Application.LoadLevel("Chapter1"); break;
			case "2": Application.LoadLevel("Chapter2"); break;
			case "3": Application.LoadLevel("Chapter3"); break;
			case "4": Application.LoadLevel("Chapter4"); break;
			}

	}


}
