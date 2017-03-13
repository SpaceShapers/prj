using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class addPointerbsx : MonoBehaviour {

	public GameObject ConquerCont; //dichiaro una variabile di tipo GameObject
	public changeState cngstate;
	public GameObject Area;
	public OnArea OnAreas;

	private bool First;

	void Start () {
		OnAreas = Area.GetComponent<OnArea>();
		cngstate = ConquerCont.GetComponent<changeState>();//.angBSx=true; 
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter(Collider Coll) {

		//ConquerCont = GameObject.Find("ConquerController"); //restituisce l'oggetto Control

		//ConquerCont.GetComponent<changeState>().angBSx=true; 
		cngstate.angBSx = true;

		if (OnAreas.isOnArea){
			Debug.Log ("Angolobsx in area");
			if (isCloserPoint()){
				cngstate.closerPoint =true;
			}
			else if (isFirst()){
				First=true;
			}
		}
		else {
			Init();
		}
	}

	private bool isFirst(){
		if (cngstate.angADx && cngstate.angASx && cngstate.angBDx) return false;
		else return true;
	}

	private bool isCloserPoint(){
		if (cngstate.angADx && cngstate.angASx && cngstate.angBDx && cngstate.angBSx && First) return true;
		else return false;
	}

	public void Init(){
		Debug.Log ("Initbsx");
		First=false;
		cngstate.angADx=false;
		cngstate.angASx=false;
		cngstate.angBDx=false;
		cngstate.angBSx=false;
	}
}
