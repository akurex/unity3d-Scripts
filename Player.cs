using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private Transform thisTransform;
	public GameObject timer;

	private string current_lvl_sc;
	// Use this for initialization
	void Start () {
		timer = GameObject.Find("timer");
		switch(Application.loadedLevelName){
		case "Chapter2": current_lvl_sc="score2"; break;
		case "Chapter2.1": current_lvl_sc="score21"; break;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Awake ()
	{
		thisTransform = transform;
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag ("Goal") ) {
			Destroy(other.gameObject);
//			other.GetComponent<Pickup> ().PickMeUp ();
			timer.GetComponent<Timer>().running = false;

			if (PlayerPrefs.GetFloat(current_lvl_sc) < timer.GetComponent<Timer>().timer){
				PlayerPrefs.SetFloat(current_lvl_sc,timer.GetComponent<Timer>().timer);
				PlayerPrefs.Save();
			}

			Invoke(	"Finish", 4);
		}
	}
	
	void Finish()
	{
		switch(Application.loadedLevelName){
		case "Chapter2": Application.LoadLevel("Chapter2.1"); break;
		case "Chapter2.1": Application.LoadLevel("Main"); break;
		}
	}


}
