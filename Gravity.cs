using UnityEngine;
using System.Collections;

public class Gravity : MonoBehaviour {

	public GameObject Rainer;
	private ParticleEmitter partemi;
	// Use this for initialization
	void Start () {
		Physics2D.gravity = new Vector2 (0, -9.81f);
		partemi = Rainer.GetComponent<ParticleEmitter>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void WindUp() {
		Physics2D.gravity = new Vector2 (0, -9.81f+5f);

		partemi.worldVelocity = new Vector3 (0,-40f,0);
		Rainer.GetComponent<ParticleEmitter>().worldVelocity = partemi.worldVelocity;
	}

	public void WindDown() {
		Physics2D.gravity = new Vector2 (0, -9.81f-5f);

		partemi.worldVelocity = new Vector3 (0,-160f,0);
		Rainer.GetComponent<ParticleEmitter>().worldVelocity = partemi.worldVelocity;
	}

	public void WindRight() {
		Physics2D.gravity = new Vector2 (0+5f, -9.81f);

		partemi.worldVelocity = new Vector3 (50,-100f,0);
		Rainer.GetComponent<ParticleEmitter>().worldVelocity = partemi.worldVelocity;
	}

	public void WindLeft() {
		Physics2D.gravity = new Vector2 (0-5f, -9.81f);

		partemi.worldVelocity = new Vector3 (-50,-100f,0);
		Rainer.GetComponent<ParticleEmitter>().worldVelocity = partemi.worldVelocity;
	}

	public void WindReset() {
		Physics2D.gravity = new Vector2 (0, -9.81f);
		
		partemi.worldVelocity = new Vector3 (0,-100f,0);
		Rainer.GetComponent<ParticleEmitter>().worldVelocity = partemi.worldVelocity;
	}
}