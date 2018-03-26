using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followObject : MonoBehaviour {
    public GameObject TargetObject;
	
	// Update is called once per frame
	void Update () {
        transform.position = TargetObject.transform.position;
	}
}
