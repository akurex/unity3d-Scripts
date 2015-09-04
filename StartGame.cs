using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	public GameObject player;
	public GameObject hint;
	public GameObject timer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		timer.GetComponent<Timer>().running = true;
		player.rigidbody2D.isKinematic = false;
		hint.GetComponent<Fader>().fade_me = true;
		Destroy(gameObject);
	}
}
