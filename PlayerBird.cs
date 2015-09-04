using UnityEngine;
using System.Collections;

public class PlayerBird : MonoBehaviour {

	private Transform thisTransform;
	public GameObject timer;
	public GameObject bird;

	private string current_lvl_sc;
	// Use this for initialization
	void Start () {
		timer = GameObject.Find("timer");
		switch(Application.loadedLevelName){
		case "Chapter4": current_lvl_sc="score4"; break;
		case "Chapter4.1": current_lvl_sc="score41"; break;
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
//			GameObject.Find("Main Camera").GetComponent<2DSmoothCam>().enabled = false;
			Invoke(	"Finish", 5);
			this.rigidbody2D.isKinematic=true;
			this.gameObject.SetActive(false);
			bird.SetActive(true);

			if (PlayerPrefs.GetFloat(current_lvl_sc) < timer.GetComponent<Timer>().timer){
				PlayerPrefs.SetFloat(current_lvl_sc,timer.GetComponent<Timer>().timer);
			PlayerPrefs.Save();
			}
		}
	}
	
	void Finish()
	{

		switch(Application.loadedLevelName){
		case "Chapter4": Application.LoadLevel("Chapter4.1"); break;
		case "Chapter4.1": Application.LoadLevel("Main"); break;
		}
	}


}
