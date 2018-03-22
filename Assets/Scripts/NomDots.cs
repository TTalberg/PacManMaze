using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NomDots : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider collision)
    {

        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "pacman")
           // SceneManager.LoadScene("Menu");
        Destroy(gameObject);

    }

    
   


}
