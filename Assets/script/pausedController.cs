using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausedController : MonoBehaviour {
    public GameObject pause;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //método para pausar o jogo
    public void Pausar()
    {
        pause.SetActive(true);
        Time.timeScale = 0f;
    }
    //método para continuar a jogar
    public void Continuar()
    {
        pause.SetActive(false);
        Time.timeScale = 1f;
    }
    //método para sair do game e ir para o menu inicial
    public void Sair()
    {
        SceneManager.LoadScene("menuinicial");
        Time.timeScale = 1f;
    }
    //método para reiniciar o jogo
    public void Reiniciar()
    {
        SceneManager.LoadScene("game");
        Time.timeScale = 1f;
    }
}
