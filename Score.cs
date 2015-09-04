using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public int kills=0;
	public int amount=0;

//	public GameObject spa1, spa2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		guiText.text = "Puntaje: " + kills;

		if (amount > 8) {
			GameObject.Find ("fire").GetComponent<GUITexture>().enabled = false;
			GameObject.Find ("fire").GetComponent<Gun>().enabled = false;

			if (PlayerPrefs.GetInt("score3") < kills){
				PlayerPrefs.SetInt("score3",kills);
				PlayerPrefs.Save();
			}
		}
	}

	public void add_one () {
		amount++;

	}

	public void substract_one () {
		amount--;
	}
}
