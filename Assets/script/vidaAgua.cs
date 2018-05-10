using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaAgua : MonoBehaviour
{
    private SpawnAgua manager; //método spawn
   // private Rigidbody rb;
    // Use this for initialization
    void Start()
    {
     //   rb = GetComponent<Rigidbody>();
        manager = FindObjectOfType<SpawnAgua>();
        manager.Spawn();//criar o primeiro item
        manager.Spawn();//criar o primeiro item
        manager.Spawn();//criar o primeiro item
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider outro)
    {
        //Debug.Log ("entrou no trigger");
        //colisao para coletar o item
        if (outro.CompareTag("vidaAgua"))
        {
            Destroy(outro.gameObject);// destroi item
            manager.Spawn();// cria outro item
           
        }
    }

}
