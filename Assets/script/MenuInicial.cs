using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuInicial : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //método para mudar visão da camera
    public void LookAtMenu (Transform menuTransform)
    {
        Camera.main.transform.LookAt(menuTransform.position);
    }
}
