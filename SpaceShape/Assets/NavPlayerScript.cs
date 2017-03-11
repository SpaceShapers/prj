﻿using UnityEngine;
using System.Collections;

public class NavPlayerScript : MonoBehaviour {
	
	NavMeshAgent agent;
	public bool touchControls;

	void Start () 
	{
	
		agent = GetComponent<NavMeshAgent> ();

	}

	void Update () 
	{
	
		if (Input.GetMouseButtonDown (0) && touchControls) 
		{
			MoveClick();
		}

	}

	void MoveClick()
	{
		Ray getThere = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().ScreenPointToRay (Input.mousePosition);
		RaycastHit clicked;
		Physics.Raycast (getThere, out clicked);
		if (clicked.collider.gameObject.tag == "terrain")
			agent.SetDestination (new Vector3 (clicked.point.x, transform.position.y, clicked.point.z));
	}


}
