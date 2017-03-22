using UnityEngine;
using System.Collections;

public class MainAI : MonoBehaviour {
	
	public ArrayList BoPlayers;
	public int numeroGiocatori = 0;
	private int ii;
	public PlayerColor ColorePlayer;


	void Start () {
	//assegno il colore al giocatore

		SetColor();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Metodo per il set dell'oggetto BO player, colore numero giocatore etc
	void SetColor () {
		Bo_Player[] BoPlayer = new Bo_Player[numeroGiocatori];
		for (ii = 0; ii < numeroGiocatori; ii++)
		{
			BoPlayer[ii].Ngiocatore(ii);
			BoPlayer[ii].Colore(ColorePlayer.coloriM[ii]);
		}
	}

}
