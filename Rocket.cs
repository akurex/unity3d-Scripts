using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour {

	private Score score;
	// Use this for initialization
	void Start () {

	}

	void Awake()	{
		score = GameObject.Find("score").GetComponent<Score>();
	}
	// Update is called once per frame
	void Update () {
	
	}

	void OnBecameInvisible() {
		Destroy(gameObject);
	}
	

	void OnTriggerEnter2D (Collider2D col) 
	{
		if(col.tag == "Enemy")
		{
			col.GetComponent<Enemy>().boom();
			col.gameObject.GetComponent<Detonator>().Explode();
			GameObject.Find ("score").GetComponent<Score>().substract_one();
			var renderers = col.GetComponentsInChildren<MeshRenderer>();
			foreach (var r in renderers) {
				r.enabled = !r.enabled;
			}
			col.GetComponent<BoxCollider2D>().enabled=false;
			score.kills+=1;
			Destroy (gameObject);
		}

	}
}
