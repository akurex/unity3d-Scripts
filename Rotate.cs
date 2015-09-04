using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	public Transform target;
	public float angle;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 relativePos = target.position - transform.position;
		angle = Mathf.Atan2(relativePos.y, relativePos.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle+90, Vector3.forward);
//		Quaternion rotation = Quaternion.LookRotation(relativePos);
//		transform.rotation = rotation;
	}
}
