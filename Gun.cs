using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

	public Rigidbody2D rocket;
	public GameObject turret;
	public GameObject slider;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		float angleV = (turret.GetComponent<Rotate>().angle)*Mathf.Deg2Rad;

		Rigidbody2D bulletInstance = Instantiate(rocket, turret.transform.position+new Vector3(Mathf.Cos(angleV)*Mathf.Rad2Deg/30, Mathf.Sin(angleV)*Mathf.Rad2Deg/30,0), Quaternion.Euler(new Vector3(0,0,0))) as Rigidbody2D;
		bulletInstance.transform.rotation = Quaternion.AngleAxis(turret.GetComponent<Rotate>().angle+0, Vector3.forward);
		bulletInstance.isKinematic = false;
		audio.Play();

//		Debug.Log (angleV);
		bulletInstance.rigidbody2D.AddForce( new Vector2(Mathf.Cos(angleV)*Mathf.Rad2Deg, Mathf.Sin(angleV)*Mathf.Rad2Deg) * slider.GetComponent<SliderV>().vSliderValue  ) ;
	}
}
