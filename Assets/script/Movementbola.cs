using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class Movementbola : MonoBehaviour {
    private Rigidbody rb;
    public float velocidade; //velocidade inicial 
    public GameObject particulaItem; //efeito de particula
    public Text textoPontos; //pontuacao do jogo
 
    public Text textoPontos2; //pontuacao do jogo no game over
    private int pontos; //contador de pontos
    private SpawnManager manager; //método spawn
    public GameObject gameover; //tela de game over

    public AudioClip somColisao; //som de colisao com item coletavel
    public AudioClip somGameOver; //som de gameover
    public AudioClip somCaixa; // som colisao com o item nao coletavel

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
     
        textoPontos.text = textoPontos.text + pontos.ToString(); //pontos inicial
        textoPontos2.text = textoPontos2.text + pontos.ToString(); //pontos inicial
        manager = FindObjectOfType<SpawnManager>();
        manager.Spawn();//criar o primeiro item
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        //movimentacao da bola
        Vector3 move = new Vector3(CrossPlatformInputManager.GetAxis("Horizontal"), 0, CrossPlatformInputManager.GetAxis("Vertical"));
        rb.AddForce(move*velocidade);//velocidade
	}
    void OnTriggerEnter(Collider outro)
    {
        //colisao para coletar o item
        if (outro.gameObject.CompareTag("item")){
            Instantiate(particulaItem, outro.gameObject.transform.position, Quaternion.identity);
            Destroy(outro.gameObject);// destroi item
            MarcaPonto();// adiciona o ponto
            manager.Spawn();// cria outro item
            velocidade = velocidade + 0.3f; //aumento de velocidade da bola a cada item coletado
            GetComponent<AudioSource>().PlayOneShot(somColisao);
        }
        //colisao para perder pontos
        if (outro.gameObject.CompareTag("itemMenos"))
        {
            Instantiate(particulaItem, outro.gameObject.transform.position, Quaternion.identity);
            MenosPonto();
            GetComponent<AudioSource>().PlayOneShot(somCaixa);
        }
        //colisao para diminuir velocidade
        if (outro.gameObject.CompareTag("item2"))
        {
            Instantiate(particulaItem, outro.gameObject.transform.position, Quaternion.identity);
            Destroy(outro.gameObject);// destroi item
            MarcaPonto();// adiciona o ponto
            manager.Spawn();// cria outro item
            velocidade = velocidade - 0.3f; //diminui velocidade da bola a cada item coletado
            GetComponent<AudioSource>().PlayOneShot(somColisao);
        }
        //colisao para game over
        if (outro.gameObject.CompareTag("Finish"))
        {
            gameover.SetActive(true);
            Time.timeScale = 0f;
            GetComponent<AudioSource>().PlayOneShot(somGameOver);
        }
    }
    //somador de pontos
    void MarcaPonto()
    {
        pontos++;
        textoPontos.text = "Pontos: " + pontos.ToString();
        textoPontos2.text = "Pontos: " + pontos.ToString();
       
    }
    //diminuir pontos
    void MenosPonto()
    {
        pontos--;
        textoPontos.text = "Pontos: " + pontos.ToString();
        textoPontos2.text = "Pontos: " + pontos.ToString();

    }
}
