﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirarItem : MonoBehaviour {
    public float EixoX;
    public float EixoY;
    public float EixoZ;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(EixoX, EixoY, EixoZ) * Time.deltaTime);
	}
}
