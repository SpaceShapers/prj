using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Generate_Board : MonoBehaviour {

	public GameObject panel;
	public Vector2 cellSize;
	public int row_num;
	public int col_num;

	private int counterCol = 1;
	private int counterRow = 1;
	
	
	void Start()
	{
		CreateGrid (panel.transform.position.x, panel.transform.position.y);
	}
	
	public void CreateGrid(float x, float y)
	{
		GameObject piece = (GameObject)Instantiate (panel, new Vector3 (x, y, 0f), panel.transform.rotation);
		piece.SetActive (true);
		counterCol++;
		if (counterCol < col_num) 
		{
			CreateGrid (x - cellSize.x, y);
		}
		else if (counterRow < row_num)
		{
			counterCol = 1;
			counterRow++;
			CreateGrid (panel.transform.position.x, y - cellSize.y);
		}
	}
}
