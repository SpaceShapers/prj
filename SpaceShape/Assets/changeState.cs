using UnityEngine;
using System.Collections;

public class changeState : MonoBehaviour {

	public int stato; 
	public GameObject Quad;
	//Al momento prevediamo 2 stati
	public const int Libero = 0;
	public const int Occupato= 1;

	public bool angBSx;
	public bool angBDx;
	public bool angADx;
	public bool angASx;
	public bool closerPoint;

	public int player;

	public addPointerasx asx;
	public addPointerbsx bsx;
	public addPointerbdx bdx;
	public addPointeradx adx;


	void Start () {
		stato = Libero;

	}
	
	// Update is called once per frame
	void Update () {

		//Controllo lo stato
		if (CheckStateFree()) {

			//se libero e la biscia ha cirocndato il quadrato, allora cambio lo stato..
			if (GetHoldQuadbyPlayer()) {


				//..il colore..
				Quad.GetComponent<SpriteRenderer>().color = Color.red;
				setState(Occupato);

				//reinizializzo i trigger
				angBSx = false;
				angBDx = false;
				angADx = false;
				angASx = false;
			}
		}
	}

	//Confronto se tutti i trigger del quadrato sono stati calpestati piu il 5 trigger cioe quello di partenza
	public bool GetHoldQuadbyPlayer()  {
		if (angBSx && angBDx && angADx && angASx && closerPoint) return true;
		//if (angBSx) return true;
		else return false;
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
