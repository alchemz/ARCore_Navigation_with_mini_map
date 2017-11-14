using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdatePos : MonoBehaviour {
    public GameObject trackedObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(trackedObject.transform.position.x, 6.0f, trackedObject.transform.position.z);
        transform.eulerAngles = new Vector3(90, 0, trackedObject.transform.eulerAngles.z);
	}
}
