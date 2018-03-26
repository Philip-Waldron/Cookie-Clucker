using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour {
    public GameObject SpawnObj;
	public float XMax = 5f;
	public float XMin = -5f;
	public float ZMax = -2.5f;
	public float ZMin = 15f;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.DownArrow))
        {
	        SpawnOBject();
        }
	}

    public void SpawnOBject()
    {
        var clone = Instantiate(SpawnObj, 
                    new Vector3(Random.Range(XMin, XMax),10,Random.Range(ZMax, ZMin)), 
                    Quaternion.Euler(new Vector3(Random.Range(-180,180),Random.Range(-180,180),Random.Range(-180,180))));
        clone.AddComponent<DestroyerScript>();
    }
}
