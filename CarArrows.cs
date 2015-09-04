using UnityEngine;
using System.Collections;

public class CarArrows : MonoBehaviour {

	public string direction;
	public GameObject wheel1;
	public GameObject wheel2;

	private JointMotor2D motor1;
	private JointMotor2D motor2;
	// Use this for initialization
	void Start () {
		motor1 = wheel1.GetComponent<HingeJoint2D>().motor;
		motor2 = wheel2.GetComponent<HingeJoint2D>().motor;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown ()
	{
		int dir = 0;
		if (direction == "r") dir = 1;
		if (direction == "l") dir = -1;

		motor1.motorSpeed = 1800*dir;
		wheel1.GetComponent<HingeJoint2D>().motor = motor1;


		motor2.motorSpeed = 1800*dir;
		wheel2.GetComponent<HingeJoint2D>().motor = motor2;
	}

	void OnMouseUp ()
	{

		motor1.motorSpeed = 0;
		wheel1.GetComponent<HingeJoint2D>().motor = motor1;
		

		motor2.motorSpeed = 0;
		wheel2.GetComponent<HingeJoint2D>().motor = motor2;
	}
}
