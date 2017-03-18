using UnityEngine;
using System.Collections;

public class PlayerAI : MonoBehaviour {

	public GameObject GController;
	public MainAI MainAI_script;
	private int numeroGiocatori;

	void Start () {

		MainAI_script = GController.GetComponent<MainAI> ();
		numeroGiocatori =  MainAI_script.numeroGiocatori;
		MainAI_script.numeroGiocatori =  numeroGiocatori + 1;

	}
//	
//	// Update is called once per frame
//	void Update () {
//	
//	}
}
