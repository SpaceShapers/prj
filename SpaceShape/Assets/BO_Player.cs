using UnityEngine;
using System.Collections;

public class Bo_Player : MonoBehaviour {

	private Color _colore;
	private int  numeroGiocatore;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public Color Colore(){
		return _colore;
	}

	public int Ngiocatore(){
		return numeroGiocatore;
	}

	public void  Colore(Color value){
		_colore=value;
	}
	
	public void  Ngiocatore(int value){
		numeroGiocatore=value;
	}
}
