using UnityEngine;
using System.Collections;

public class NavPlayerCarrot : MonoBehaviour {

	NavMeshAgent agent;
	public bool touchControls;
	public Transform alto;
	public Transform basso;
	public Transform sinistra;
	public Transform destra;

	private Transform destination;
	private int click = 0;

	void Start () 
	{
		
		agent = GetComponent<NavMeshAgent> ();
		destination = transform;
		
	}
	
	void Update () 
	{
		
		if (Input.GetMouseButtonDown (0) && touchControls) 
		{
			click++;
			SetPlayerDirection();
		}
		agent.SetDestination (destination.position);
		
	}
	
	private void SetPlayerDirection()
	{
		Transform wantedDirection;
		Ray getThere = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().ScreenPointToRay (Input.mousePosition);
		RaycastHit clicked;
		Physics.Raycast (getThere, out clicked);
		Vector3 touched = clicked.transform.position;
		float touchAngle = Vector3.Angle (Vector3.forward, touched);
		if (touchAngle <= 45f)
			wantedDirection = alto;
		else if (touchAngle >=135f)
			wantedDirection = basso;
		else if (touchAngle > 45f && touchAngle < 135f && touched.x > 0)
			wantedDirection = destra;
		else
			wantedDirection = sinistra;
		destination = wantedDirection;
		//StartCoroutine (CheckToChangeRoute(wantedDirection));

	}

	IEnumerator CheckToChangeRoute(Transform newRoute)
	{
		NavMeshHit hit;
		while(click > 1)
			yield return new WaitForSeconds(0.01f);
		while(!NavMesh.SamplePosition (destination.position, out hit, 0.01f, NavMesh.AllAreas)|| click > 1)
			yield return new WaitForSeconds(0.1f);
		if(click == 1)
			destination = newRoute;
		click--;

	}
}
