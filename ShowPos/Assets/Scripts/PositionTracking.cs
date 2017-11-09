using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionTracking : MonoBehaviour {

    public GameObject Text1;
    public GameObject Text2;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(Text1.transform.parent.position, Text2.transform.parent.position);
        Text1.GetComponent<TextMesh>().text = "Distance: " + dist + "Pos: " + Text1.transform.parent.position;
        Text2.GetComponent<TextMesh>().text = "Distance: " + dist + "Pos: " + Text2.transform.parent.position;
    }
}
