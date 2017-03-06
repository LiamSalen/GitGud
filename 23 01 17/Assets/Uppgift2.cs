using UnityEngine;
using System.Collections;

public class Uppgift2 : MonoBehaviour {
    public int valA = 5;
    public int valB = 10;

	// Use this for initialization
	void Start () {
	    if (valA > valB) //This checks if valA is bigger than valB.
        {
            Debug.Log(valA);
        }

        if (valB > valA) //This checks if valB is bigger than valA.
        {
            Debug.Log(valB);
        }
    
        if (valA == valB) //This checks if valA and valB have the same value.
        {
            Debug.Log("The Same Value");
        }
    
	}	
}
