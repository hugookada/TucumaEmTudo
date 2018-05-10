using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
    public GameObject item1;//item a ser spawn
    public GameObject item2;//item a ser spawn
    public GameObject item3;//item a ser spawn
    public GameObject item4;//item a ser spawn
    private GameObject item;
   // public float tempoSpawn;// tempo de spawn
    public Transform[] pontoSpawn;//quantidade de pontos de spawn
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //método de spawn
    public void Spawn(){
        //random entre os itens
        int dropitem = Random.Range(1, 5);
    
        if (dropitem == 1)
        {
            item = item1;
            
        }
        else if(dropitem==2){
            item = item2;
        }
        else if (dropitem == 3)
        {
            item = item3;
        }
        else//(dropitem == 4)
        {
            item = item4;
        }
        int valor = Random.Range(0, pontoSpawn.Length);//random do ponto de spawn
        Instantiate(item, pontoSpawn[valor].position, pontoSpawn[valor].rotation);//criar o item
    }
}
