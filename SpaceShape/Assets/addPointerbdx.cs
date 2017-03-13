﻿using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class addPointerbdx : MonoBehaviour {

	public GameObject ConquerCont;
	public changeState cngstate;
	public GameObject Area;
	public OnArea OnAreas;
	private bool First;

	void Start () {
		OnAreas = Area.GetComponent<OnArea>();
		cngstate = ConquerCont.GetComponent<changeState>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void OnTriggerEnter(Collider Coll) {


		cngstate.angBDx= true;

		if (OnAreas.isOnArea){

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
		if (cngstate.angADx && cngstate.angBSx && cngstate.angASx) return false;
		else return true;
	}
	
	private bool isCloserPoint(){
		if (cngstate.angADx && cngstate.angASx && cngstate.angBDx && cngstate.angBSx && First) return true;
		else return false;
	}
	
	public void Init(){
		Debug.Log ("Initbdx");
		First=false;
		cngstate.angADx=false;
		cngstate.angASx=false;
		cngstate.angBDx=false;
		cngstate.angBSx=false;
	}
}
