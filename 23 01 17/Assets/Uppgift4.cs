using UnityEngine;
using System.Collections;

public class Uppgift4 : MonoBehaviour {
    public float valA;
    public float valB;
    public float valC;

	// Use this for initialization
	void Start () {
        //valA = valB - 5;
	if(valC < valB || valC < valA)
        {
            Debug.Log("In The Middle");
        }
    else
        {
            Debug.Log("Not In the Middle");
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
