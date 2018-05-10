using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fluxo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //método para iniciar o jogo
    public void CarregarGame()
    {
        SceneManager.LoadScene("game");
    }
}
