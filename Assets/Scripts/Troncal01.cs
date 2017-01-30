using UnityEngine;
using System.Collections;

public class Troncal01 : MonoBehaviour {

	// Use this for initialization


	private Animator myAnimation;
	private Renderer myRenderer;

	private Color myColorInicial;
	private Color myLerpedColor;

	private bool animState;

	public GameObject myCanvas; // no sé por qué no se agarra como Canvas

	private bool isMenuActive;


	void Start () {

		animState = false;

		myAnimation = GetComponent<Animator> ();
		myRenderer = GetComponent<Renderer> ();

		myColorInicial = myRenderer.material.GetColor ("_Color"); // conservamos el color inicial

		//myCanvas = GameObject.Find ("tuerca_canvas");

		isMenuActive = false;
		myCanvas.SetActive (isMenuActive);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	void OnMouseOver(){


		myRenderer.material.color = Color.white;
	


	}
	void OnMouseExit(){

	

		myRenderer.material.color = myColorInicial; // restauramos el color inicial
	



	}

	void OnMouseDown(){



		if (!animState) {
			myAnimation.Play ("troncal01_enter");
			animState = true;
			isMenuActive = true;

			//myLerpedColor=Color.Lerp(myColorInicial, Color.red, Mathf.PingPong(Time.time, 1));

		} else if (animState) {
			myAnimation.Play ("troncal01_exit");
			animState = false;
			isMenuActive = false;

			//myLerpedColor=Color.Lerp(Color.red,myColorInicial, Mathf.PingPong(Time.time, 1));


		}
		//myRenderer.material.SetColor ("_Color", myLerpedColor);


		myCanvas.SetActive (isMenuActive);


	}




}
