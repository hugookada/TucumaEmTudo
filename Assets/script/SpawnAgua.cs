using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//spawn da agua
public class SpawnAgua : MonoBehaviour {
    public GameObject item;
    public Transform[] pontoSpawn;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Spawn()
    {
        int valor = Random.Range(0, pontoSpawn.Length);//random do ponto de spawn
        Instantiate(item, pontoSpawn[valor].position, pontoSpawn[valor].rotation);//criar o item
    }
}
