using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	public float timer;
	public bool running;
	// Use this for initialization
	void Start () {
		timer = 0;

	}
	
	// Update is called once per frame
	void Update () {
		if (running) {
			timer += Time.deltaTime;
			guiText.text = timer.ToString("F2");
		}
	}
}
