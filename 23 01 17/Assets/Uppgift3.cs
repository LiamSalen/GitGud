using UnityEngine;
using System.Collections;

public class Uppgift3 : MonoBehaviour {
    public int valA = 5;
    public int valB = 10;

    int Metod (int a, int b)
    {
        
        return a + b;
        //This method prints a + b. a and b have the same value as valA and valB.
    }
	// Use this for initialization
	void Start () {
        Debug.Log(Metod(valA, valB));
       //This prints the final product. It prints the values from valA and valB together.
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
