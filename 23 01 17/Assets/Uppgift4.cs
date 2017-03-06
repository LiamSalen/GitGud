using UnityEngine;
using System.Collections;

public class Uppgift4 : MonoBehaviour {
    public float valA;
    public float valB;
    public float valC;

	// Use this for initialization
	void Start () {
        
	if(valC < valB || valC < valA)
        {
            //This checks if valC is smaller than valB and bigger than valA.
            Debug.Log("In The Middle");
        }
    
        else
        {
            //This prints if valC not bigger or smaller than valA or valB.
            Debug.Log("Not In the Middle");
        }
    
	}
}
