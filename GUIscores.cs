using UnityEngine;
using System.Collections;

public class GUIscores : MonoBehaviour {

	// Use this for initialization
	public GameObject sc1;
	public GameObject sc2;
	public GameObject sc21;
	public GameObject sc3;
	public GameObject sc4;
	public GameObject sc41;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		sc1.GetComponent<TextMesh>().text = PlayerPrefs.GetFloat("score1").ToString();
		sc2.GetComponent<TextMesh>().text = PlayerPrefs.GetFloat("score2").ToString("F2");
		sc21.GetComponent<TextMesh>().text = PlayerPrefs.GetFloat("score21").ToString("F2");
		sc3.GetComponent<TextMesh>().text = PlayerPrefs.GetInt("score3").ToString();
		sc4.GetComponent<TextMesh>().text = PlayerPrefs.GetFloat("score4").ToString("F2");
		sc41.GetComponent<TextMesh>().text = PlayerPrefs.GetFloat("score41").ToString("F2");
	}
}
