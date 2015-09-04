using UnityEngine;
using System.Collections;

public class TestGenerator : MonoBehaviour {

	public GameObject question;
	public GameObject ansa;
	public GameObject ansb;
	public GameObject ansc;
	public GameObject ansd;

	public GameObject check;
	public GameObject equis;

	public GameObject score;
	public GameObject final;

	private int counter=0;

	private int previous;
	// Use this for initialization
	private string preg1 = "Indique las unidades de\n" + "la velocidad";
	private string a1a = "a) m";
	private string a1b = "b) m*s";
	private string a1c = "c) m/s";
	private string a1d = "d) v/t";

	private string preg2 = "Indique la dificultad\nde implementar este\njuego en Unity3D";
	private string a2a = "a) Fácil";
	private string a2b = "b) Medio";
	private string a2c = "c) Dificil";
	private string a2d = "d) Extremo";

	private string preg3 = "Indique las unidades de\n" + "la distancia";
	private string a3a = "a) s";
	private string a3b = "b) km";
	private string a3c = "c) mm";
	private string a3d = "d) m";

	private string preg4 = "Indique las ecuación\n" + "incorrecta";
	private string a4a = "a) d = 2*(Vo + Vf)*t";
	private string a4b = "b) Vf = Vo + at";
	private string a4c = "c) d = Vf*t + 0.5*a*t^2";
	private string a4d = "d) Vf^2 = Vo^2 + 2ad";

	private string preg5 = "No es una ley\n" + "de Newton";
	private string a5a = "a) Un cuerpo esta en reposo\no a V constante\nsi no hay fuerzas externas";
	private string a5b = "b) Accion <-> Reaccion";
	private string a5c = "c) F = m*a";
	private string a5d = "d) La fuerza y la velocidad\nson vectores";

	void Start () {
		Generate ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Generate(){
		counter +=1;
		check.SetActive(false);
		equis.SetActive(false);
		clear_tags();
		enable_colliders();
		gameObject.GetComponent<SpriteRenderer>().enabled = false;
		gameObject.GetComponent<BoxCollider2D>().enabled = false;
	Repeat:
		int current = Random.Range(1,6);
		if (current==previous)  {goto Repeat;}

		switch(current){
		case 1: Post_text(preg1,a1a,a1b,a1c,a1d); break;
		case 2: Post_text(preg2,a2a,a2b,a2c,a2d); break;
		case 3: Post_text(preg3,a3a,a3b,a3c,a3d); break;
		case 4: Post_text(preg4,a4a,a4b,a4c,a4d); break;
		case 5: Post_text(preg5,a5a,a5b,a5c,a5d); break;
		}
		change_tags(current);

		previous = current; 
	}

	void Post_text(string qu,string aa,string ab,string ac, string ad){
		question.GetComponent<TextMesh>().text = qu;
		ansa.GetComponent<TextMesh>().text = aa;
		ansb.GetComponent<TextMesh>().text = ab;
		ansc.GetComponent<TextMesh>().text = ac;
		ansd.GetComponent<TextMesh>().text = ad;
	}

	void change_tags(int qu){
		switch (qu){
		case 1: ansc.tag = "good"; break;
		case 2: ansd.tag = "good"; break;
		case 3: ansd.tag = "good"; break;
		case 4: ansa.tag = "good"; break;
		case 5: ansd.tag = "good"; break;
		}
	}

	void clear_tags(){
		ansa.tag = null;
		ansb.tag = null;
		ansc.tag = null;
		ansd.tag = null;

	}

	void OnMouseDown() {
		if (counter<5) Generate ();
		else {
			final.GetComponent<GUIText>().text = "Puntaje: " + score.GetComponent<Grading>().result.ToString();

			if (PlayerPrefs.GetFloat("score1") < score.GetComponent<Grading>().result){
				PlayerPrefs.SetFloat("score1",score.GetComponent<Grading>().result);
				PlayerPrefs.Save();
			}
		}
	}

	public void disable_colliders(){
		ansa.GetComponent<BoxCollider2D>().enabled = false;
		ansb.GetComponent<BoxCollider2D>().enabled = false;
		ansc.GetComponent<BoxCollider2D>().enabled = false;
		ansd.GetComponent<BoxCollider2D>().enabled = false;
		
	}

	void enable_colliders(){
		ansa.GetComponent<BoxCollider2D>().enabled = true;
		ansb.GetComponent<BoxCollider2D>().enabled = true;
		ansc.GetComponent<BoxCollider2D>().enabled = true;
		ansd.GetComponent<BoxCollider2D>().enabled = true;
		
	}
}















