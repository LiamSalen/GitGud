﻿using UnityEngine;
using System.Collections;

public class Uppgift1 : MonoBehaviour {

    public int valA = 5;
    public int valB = 10;
    private int valC = 0;
    private int valD = 0;

	// Use this for initialization
	void Start () {
        valC = valA;
        valD = valB;
        valB = valC;
        valA = valD;
        //valC and valD save the values from valA and valB for later.
        //This makes it so you can change the values from valA to valB and valb to valA.
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
