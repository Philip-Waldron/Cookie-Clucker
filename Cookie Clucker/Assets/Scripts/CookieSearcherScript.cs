using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookieSearcherScript : MonoBehaviour {
    public float travelSpeed = 1.0f;

    bool currentlySearching = true;
    GameObject currentTarget;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(currentlySearching)
        {
            AcquireNewTarget();
        }
        else
        {
            //RotateTowardsTarget(currentTarget.transform, travelSpeed);
            TravelTowardsTarget(currentTarget.transform, travelSpeed);
        }
	}

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "cookie")
        {
            //nom nom nom
            //_psystem.Play();

            Destroy(col.gameObject);
            currentlySearching = true;
        }
    }

    void AcquireNewTarget()
    {
        var cookieList = GameObject.FindGameObjectsWithTag("cookie");
        if(cookieList.Length > 0)
        {
            var shortestDistance = float.MaxValue;
            bool validTargetFound = false;

            foreach (GameObject cookie in cookieList)
            {

                    currentTarget = cookie;
                    validTargetFound = true;

            }
            //only stop searching once valid target found, otherwise there won't be a valid target to search for
            if(validTargetFound)
                currentlySearching = false;
        }

    }

    void RotateTowardsTarget(Transform target, float speed)
    {
        //rotate towards
        Vector3 targetDir = target.transform.position - transform.position;

        // The step size is equal to speed times frame time.
        float step = travelSpeed * Time.deltaTime;

        Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0f);
        //Debug.DrawRay(transform.position, newDir, Color.red);

        // Move our position a step closer to the target.
        transform.rotation = Quaternion.LookRotation(newDir);
    }

    void TravelTowardsTarget(Transform target, float speed)
    {
        //Debug.Log("Target X: " + target.position.x + "Z: " + target.position.z);
        //Debug.Log("Chicken X: " + gameObject.transform.position.x + "Z: " + gameObject.transform.position.z);
        float step = speed * Time.deltaTime;
        var targetWithoutY = new Vector3(target.position.x, gameObject.transform.position.y, target.position.z);

        //confine to x and z axis
        transform.position = Vector3.MoveTowards(transform.position, targetWithoutY, step);
        
        //free movement
        //transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }
}
