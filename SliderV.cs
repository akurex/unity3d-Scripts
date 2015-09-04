using UnityEngine;
using System.Collections;

public class SliderV : MonoBehaviour {

	public float vSliderValue = 0.0F;
	// Use this for initialization
	void Start () {
		vSliderValue = 10.0F;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI() {
		vSliderValue = GUI.VerticalSlider(new Rect(50, 100, 30, 240), vSliderValue, 20.0F, 0.0F);
	}
}
