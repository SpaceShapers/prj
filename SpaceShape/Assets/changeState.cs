using UnityEngine;
using System.Collections;

public class changeState : MonoBehaviour {

	public int stato; 
	public GameObject Quad;
	//Al momento prevediamo 2 stati
	public const int Libero = 0;
	public const int Occupato= 1;


	void Start () {
		stato = Libero;
	}
	
	// Update is called once per frame
	void Update () {

		//Controllo lo stato
		if (CheckStateFree()) {
			//ToDo
			//se libero e la biscia ha cirocndato il quadrato, allora cambio lo stato
			//setState(Occupato);
			//Quad. setto colore del player con effetto

		}

	}

	//Funzione per la verifica dello stato, se libero torno true altrimenti false
	public bool CheckStateFree() {

		if (stato==Libero)return true;
		else return false;
	}

	public void setState(int val) {
		stato = val;
	}

}
