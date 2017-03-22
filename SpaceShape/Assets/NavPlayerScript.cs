﻿using UnityEngine;
using System.Collections;

public class NavPlayerScript : MonoBehaviour {

    UnityEngine.AI.NavMeshAgent agent;
	public bool touchControls;

	void Start () 
	{
	
<<<<<<< HEAD
		agent = GetComponent<UnityEngine.AI.NavMeshAgent> ();
=======
		agent = GetComponent<NavMeshAgent> ();
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> parent of f882eed... .
=======
>>>>>>> parent of f882eed... .
=======
>>>>>>> parent of f882eed... .

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
		//.tag == "terrain")
		if (clicked.collider.gameObject.tag == "terrain")
			agent.SetDestination (new Vector3 (clicked.point.x, transform.position.y, clicked.point.z));
	}


}
