using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class GhostController : MonoBehaviour {
    NavMeshAgent agent;
    //public Transform target;
    public GameObject target;


    // Use this for initialization
    void Start () {

        agent = GetComponent<NavMeshAgent>();
        //target = GameObject.FindGameObjectsWithTag ("pacman").transform;
        target = GameObject.FindGameObjectWithTag("pacman");

    }
	
	// Update is called once per frame
	void Update () {

         agent.destination = target.transform.position;
        //agent.SetDestination(target.transform.position);
		
	}

    public void OnCollisionEnter(Collision collision)
    {
       
    
        if (collision.gameObject.tag == "pacman")
            SceneManager.LoadScene("Menu");
       // if (collision.gameObject.tag != "pacman");
        //Physics.IgnoreCollision(collision.collider, gameObject.GetComponent<CapsuleCollider>());
    }

}
