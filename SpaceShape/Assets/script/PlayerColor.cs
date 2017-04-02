using UnityEngine;
using System.Collections;

public class PlayerColor : MonoBehaviour {

	private Color _plrOne = Color.yellow;

	private Color _plrTwo = Color.red;

	private Color _plrThree = Color.green;

	private Color _plrFour = Color.blue;

	private Color _plrFive = Color.magenta;

	private Color _plrSix = Color.cyan;

	public Color[] coloriM;
//
//	
	void Start () {
		Color[] coloriM = new Color[6];
		coloriM[0] = _plrOne;
		coloriM[1] = _plrTwo;
		coloriM[2] = _plrThree;
		coloriM[3] = _plrFour;
		coloriM[4] = _plrFive;
		coloriM[5] = _plrSix;

	}
	
	public Color plrOne(){

		return _plrOne;

	}

	public Color plrTwo(){

		return _plrTwo;

	}

	public Color plrThree(){

		return _plrThree;

	}

	public Color plrFour(){

		return _plrFour;

	}

	public Color plrFive(){

		return _plrFive;

	}

	public Color plrSix(){

		return _plrSix;

	}

}
