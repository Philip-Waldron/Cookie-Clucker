using System.Collections;
using System.Collections.Generic;
using Leap;
using UnityEngine;

public class SpawnConscript : MonoBehaviour
{
	public Transform playerTable;
	public Transform Conscript;

	private Vector3 spawnPos;
	private float spawnIndent = 2;

	private bool swap;
	
	// Use this for initialization
	void Start () {
		spawnPos = playerTable.position + new Vector3(spawnIndent,0,0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SpawnNewConscript()
	{
		Instantiate(Conscript, 
			spawnPos, 
			Conscript.rotation);

		spawnIndent = (spawnIndent * -1);
		
		if (spawnIndent > 0)
		{
			spawnIndent = spawnIndent + 2;
		}
		
		spawnPos = playerTable.position + new Vector3(spawnIndent,0,0);
	}
}
