using UnityEngine;
using System.Collections;

public class Uppgift5 : MonoBehaviour {
    public int valA = 10;
    public int valB =  5;
    private int valC;
    public float valD = 10;
    public float valE = 0;

    int Method (int a, int b)
    {
        return a + b;
        //Is a method
    }
	// Use this for initialization
	void Start () {
        valC = Method(valA, valB);
        if (valC < valE && valC > valD)
        {
            Debug.Log("Den Är Mellan D Och E");
        }
        //Prints if valC is bigger than valD and smaller than valE.
        else
        {
            Debug.Log("Större Eller Mindre Än Den Ska Vara");
        }
        //Prints if valC is bigger than valE or smaller than valD.
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
