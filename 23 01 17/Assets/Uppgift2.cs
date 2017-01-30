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
    //This checks if valA is bigger than valB.
    if (valB > valA)
        {
            Debug.Log(valB);
        }
    //This checks if valB is bigger than valA.
    if (valA == valB)
        {
            Debug.Log("The Same Value");
        }
    //This checks if valA and valB have the same value.
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
