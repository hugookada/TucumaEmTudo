using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {
    public GameObject objetoBola;
    private Vector3 posicaoInicial;
	// Use this for initialization
	void Start () {
        //posicao inicial da camera
        posicaoInicial = transform.position - objetoBola.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        //posicao atualizada da camera
        transform.position = objetoBola.transform.position+posicaoInicial;
	}
}
