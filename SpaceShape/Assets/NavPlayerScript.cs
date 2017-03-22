using UnityEngine;
using System.Collections;

public class NavPlayerScript : MonoBehaviour {
	
	NavMeshAgent agent;
	public bool touchControls;
	public GameObject alto;
	public GameObject basso;
	public GameObject sinistra;
	public GameObject destra;
	//public Rigidbody rigB;
	public GameObject Nord;
	public GameObject Sud;
	public GameObject Owest;
	public GameObject Est;
	//public GameObject pan;
	void Start () 
	{
	
		agent = GetComponent<NavMeshAgent> ();
		//rigB =  GetComponent<Rigidbody> ();

	}

	void Update () 
	{
	
		if (Input.GetMouseButtonDown (0) && touchControls) 
		{
			//verifico quale dei 4 sensori è piu vicino al tocco sullo schermo
			//indirizzo il player in quella direzione
			MoveClick(nearestSensor());
		}

	}

	private int nearestSensor()
	{
		//definisco "dove ho toccato"
		Ray getThere = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().ScreenPointToRay (Input.mousePosition);
		RaycastHit clicked;
		Physics.Raycast (getThere, out clicked);

		//chi piu vicino?
		if (Vector3.Distance(clicked.transform.position,alto.transform.position)
			< Vector3.Distance(clicked.transform.position,destra.transform.position))
		{
			if (Vector3.Distance(clicked.transform.position,alto.transform.position)
			    < Vector3.Distance(clicked.transform.position,basso.transform.position))
			{
				if (Vector3.Distance(clicked.transform.position,alto.transform.position)
				    < Vector3.Distance(clicked.transform.position,sinistra.transform.position))
				{
					return 1;
				}
				else return 4;
			}
			else
			{
				if (Vector3.Distance(clicked.transform.position,basso.transform.position)
				    < Vector3.Distance(clicked.transform.position,sinistra.transform.position))
				{
					return 3;
				}
				else return 4;

			}
		
		}
		else
		{
			if (Vector3.Distance(clicked.transform.position,destra.transform.position)
			    < Vector3.Distance(clicked.transform.position,basso.transform.position))
			{
				if (Vector3.Distance(clicked.transform.position,destra.transform.position)
				    < Vector3.Distance(clicked.transform.position,sinistra.transform.position))
				{
					return 2;
				}
				else return 3;
			}	
			else
				if (Vector3.Distance(clicked.transform.position,basso.transform.position)
				    < Vector3.Distance(clicked.transform.position,sinistra.transform.position))
			{
				return 3;
			}
			else return 4;
		}
	}

	void MoveClick(int value)
	{
//		if (clicked.collider.gameObject.tag == "terrain")
		switch(value)	{
			
		case 1:

			agent.SetDestination (new Vector3 (transform.position.x, transform.position.y, Nord.transform.position.z));
			break;

		case 2:

			agent.SetDestination (new Vector3 ( Est.transform.position.x, transform.position.y, transform.position.z));

			//rigB.AddForce(Vector3.right * 3);
			break;
		
		case 3:

			agent.SetDestination (new Vector3 (transform.position.x, transform.position.y,Sud.transform.position.z));
//			agent.SetDestination (new Vector3 (clicked.point.x, transform.position.y, clicked.point.z));
			break;

		case 4:

			agent.SetDestination (new Vector3 (Owest.transform.position.x, transform.position.y, transform.position.z));
			break;

		default:
			//non gli facciamo fare nulla
			//agent.SetDestination (new Vector3 (basso.transform.position.x, transform.position.y, alto.transform.position.z));
			break;
		}
	}

	//agent.SetDestination (new Vector3 (clicked.point.x, transform.position.y, clicked.point.z));
}
