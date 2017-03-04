using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class touchLato : MonoBehaviour {

	public GameObject lato3;
	public int stato; 

	private int ii;

	void Start () {
		//libero on start
		stato = 0;
	}

	// Update is called once per frame
	void Update () {

		//Quanti tocchi?
		int nTouches = Input.touchCount;


		if (nTouches > 0) 
		{
			for (ii = 0; ii < nTouches; ii++);
			{

				Touch t = Input.GetTouch(ii);
		
				switch(t.phase)	{

					case TouchPhase.Began:

					if (stato == 1) 
					{
						//ToDo
					}
					/* eventuale stato aggiuntivo
					else if (stato ==2)
					{
					}
					*/
					else 
					{
						//set occupato
						stato = 1;

						//per ora colore con valore statico, poi dinamiciziamo
						lato3.GetComponent<SpriteRenderer>().color = Color.red; 
					}

						break;

				}
			}
		}
	}
}