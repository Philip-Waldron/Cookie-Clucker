using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoombaUpgrade : MonoBehaviour
{

	public Transform Cube;

	public Transform roomba;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void UpgradeSpeed()
	{
		GetComponent<CookieSearcherScript>().travelSpeed = GetComponent<CookieSearcherScript>().travelSpeed + 1;
	}

	public void UpgradeSize()
	{
		Cube.localScale = Cube.localScale + new Vector3(0.1f, 0.1f, 0.1f);
		roomba.localScale = roomba.localScale + new Vector3(0.1f, 0.1f, 0.1f);
		Cube.localPosition = Cube.localPosition + new Vector3(0, 0.2f, 0);
	}
}
