using UnityEngine;
using System.Collections;

public class Velocity : MonoBehaviour {

	private GameObject show_text, show_texta;
	private GameObject show_speed, show_accel;
	private float speed;
	private float init_h;
	private float sum;
	private float accel, lastVelocity;
	// Use this for initialization
	void Start () {
		show_text = GameObject.Find("speed");
		show_texta = GameObject.Find("accel");
		show_speed = GameObject.Find("speed meter");
		show_accel = GameObject.Find("accel meter");
		init_h = show_speed.GetComponent<GUITexture>().pixelInset.y;

	}
	
	// Update is called once per frame
	void Update () {
		speed = this.rigidbody2D.velocity.magnitude;
		show_text.GetComponent<GUIText>().text = "Velocidad: " + speed.ToString("F2");
		sum = init_h + speed*10;
		show_speed.GetComponent<GUITexture>().pixelInset = new Rect(249, sum, 58, 18);


	}

	void FixedUpdate () {
		accel = (this.rigidbody2D.velocity.magnitude - lastVelocity) / Time.fixedDeltaTime;
		lastVelocity = this.rigidbody2D.velocity.magnitude;
		show_accel.GetComponent<GUITexture>().pixelInset = new Rect(332, init_h + accel*10, 58, 18);
		show_texta.GetComponent<GUIText>().text = "Aceleracion: " + accel.ToString("F2");
	}
}
