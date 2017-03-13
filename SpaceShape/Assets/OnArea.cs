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
		Debug.Log ("trigger colliso");
	}

	public void OnTriggerStay(Collider Coll) {
		Debug.Log ("sul trigger");
		isOnArea = true;
	}

	public void OnTriggerExit(Collider Coll) {
		Debug.Log ("fuori trigger");
		isOnArea = false;
	}
}
