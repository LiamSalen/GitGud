using UnityEngine;
using System.Collections;

public class Uppgift3 : MonoBehaviour {
    public int valA = 5;
    public int valB = 10;

    int Metod (int a, int b)
    {
        //Debug.Log(valA + valB);
        return a + b;

    }
	// Use this for initialization
	void Start () {
        Debug.Log(Metod(valA, valB));
       
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
