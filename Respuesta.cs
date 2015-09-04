using UnityEngine;
using System.Collections;

public class Respuesta : MonoBehaviour {

	public GameObject check;
	public GameObject equis;
	public GameObject test;
	public GameObject score;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		if (this.gameObject.CompareTag("good")) {
			score.GetComponent<Grading>().correct_ans();
			check.SetActive(true);
			equis.SetActive(false);
		}
		else {
			score.GetComponent<Grading>().incorrect_ans();
			check.SetActive(false);
			equis.SetActive(true);
		}
		test.GetComponent<SpriteRenderer>().enabled = true;
		test.GetComponent<BoxCollider2D>().enabled = true;

		test.GetComponent<TestGenerator>().disable_colliders();
	}
}
