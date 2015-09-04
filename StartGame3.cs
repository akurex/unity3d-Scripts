using UnityEngine;
using System.Collections;

public class StartGame3 : MonoBehaviour {
	
	public GameObject spa1;
	public GameObject spa2;
	public GameObject hint;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseDown() {
		spa1.GetComponent<Spawner>().running = true;
		spa1.GetComponent<Spawner>().Start();
		spa2.GetComponent<Spawner>().running = true;
		spa2.GetComponent<Spawner>().Start();

		hint.GetComponent<Fader>().fade_me = true;
		Destroy(gameObject);
	}
}
