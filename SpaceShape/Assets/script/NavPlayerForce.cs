using UnityEngine;
using System.Collections;

public class NavPlayerForce : MonoBehaviour {

	//public GameObject Giocatore;
	public Rigidbody rgbd;
	public bool touchControls;
	public GameObject altog;
	//public GameObject up;
	public GameObject bassog;
	public GameObject sinistrag;
	public GameObject destrag;
	//public GameObject Sensors;
	public int movespeed;
	public int direction;

	// Use this for initialization
	void Start () {
		//rgbd =  GetComponent<Rigidbody> ();
		//direction = 5;

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0) && touchControls) 
		{
			//verifico quale dei 4 sensori è piu vicino al tocco sullo schermo
			//indirizzo il player in quella direzione
			direction = nearestSensor();

		}
		//else  MoveClick(direction);



	}

	private int nearestSensor()
	{
		//definisco "dove ho toccato"
		Ray getThere = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().ScreenPointToRay (Input.mousePosition);
		RaycastHit clicked;
		Physics.Raycast (getThere, out clicked);

		//chi piu vicino?
		//Debug.Log(clicked.transform.position.ToString);
		//Debug.Log(clicked.transform.position.ToString);
		if (Vector3.Distance(clicked.transform.position,altog.transform.position) < Vector3.Distance(clicked.transform.position,destrag.transform.position))
		{

			if (Vector3.Distance(clicked.transform.position,altog.transform.position)
			    < Vector3.Distance(clicked.transform.position,bassog.transform.position))
			{
				if (Vector3.Distance(clicked.transform.position,altog.transform.position)
				    < Vector3.Distance(clicked.transform.position,sinistrag.transform.position))
				{
					return 1;
				}
				else return 4;
			}
			else
			{
				if (Vector3.Distance(clicked.transform.position,bassog.transform.position)
				    < Vector3.Distance(clicked.transform.position,sinistrag.transform.position))
				{
					return 3;
				}
				else return 4;
				
			}
			
		}
		else
		{

			if (Vector3.Distance(clicked.transform.position,destrag.transform.position)
			    < Vector3.Distance(clicked.transform.position,bassog.transform.position))
			{
				if (Vector3.Distance(clicked.transform.position,destrag.transform.position)
				    < Vector3.Distance(clicked.transform.position,sinistrag.transform.position))
				{
					return 2;
				}
				else return 3;
			}	
			else
				if (Vector3.Distance(clicked.transform.position,bassog.transform.position)
				    < Vector3.Distance(clicked.transform.position,sinistrag.transform.position))
			{
				return 3;
			}
			else return 4;
		}
	}

	private void FixedUpdate() {

//		MoveClick(direction);
//
//	}
//
//	void MoveClick(int value)
//	{
		//		if (clicked.collider.gameObject.tag == "terrain")
		switch(direction)	{
			
		case 1:
			
			//agent.SetDestination (new Vector3 (transform.position.x, transform.position.y, Nord.transform.position.z));
		
			rgbd.AddForce(Vector3.forward * movespeed, ForceMode.Impulse);
			break;
			
		case 2:
			
			//agent.SetDestination (new Vector3 ( Est.transform.position.x, transform.position.y, transform.position.z));
		
			rgbd.AddForce(Vector3.right * movespeed, ForceMode.Impulse);
			break;
			
		case 3:
			
			//agent.SetDestination (new Vector3 (transform.position.x, transform.position.y,Sud.transform.position.z));
			//			agent.SetDestination (new Vector3 (clicked.point.x, transform.position.y, clicked.point.z));
			rgbd.AddForce(Vector3.back * movespeed, ForceMode.Impulse);
			break;
			
		case 4:
			
			//agent.SetDestination (new Vector3 (Owest.transform.position.x, transform.position.y, transform.position.z));
			rgbd.AddForce(Vector3.left * movespeed, ForceMode.Impulse);
			break;
			
		default:
			//non gli facciamo fare nulla
			//agent.SetDestination (new Vector3 (basso.transform.position.x, transform.position.y, alto.transform.position.z));

			break;
		}
	}
}
