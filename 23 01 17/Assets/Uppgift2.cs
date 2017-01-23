using UnityEngine;
using System.Collections;

public class Uppgift2 : MonoBehaviour {
    public int valA = 5;
    public int valB = 10;

	// Use this for initialization
	void Start () {
	if (valA > valB)
        {
            Debug.Log(valA);
        }
    if (valB > valA)
        {
            Debug.Log(valB);
        }
    if (valA == valB)
        {
            Debug.Log("The Same Value");
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
