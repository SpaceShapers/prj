using UnityEngine;
using System.Collections;

public class OnArea : MonoBehaviour {

	public bool isOnArea;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnTriggerEnter(Collider Coll) {

		isOnArea = true;

	}

	public void OnTriggerStay(Collider Coll) {

		isOnArea = true;
	

	}

	public void OnTriggerExit(Collider Coll) {
	
		isOnArea = false;
	
	}
}
