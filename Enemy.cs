using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float moveSpeed = 2f;
	// Use this for initialization
	void Start () {
		GameObject.Find ("score").GetComponent<Score>().add_one();
	}

	// Update is called once per frame
	void Update () {
		rigidbody2D.velocity = new Vector2(transform.localScale.x * -moveSpeed, rigidbody2D.velocity.y);
	}

	public void boom(){
		audio.Play();
		}
}
