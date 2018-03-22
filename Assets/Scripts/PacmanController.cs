using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PacmanController : MonoBehaviour {
    private Transform target;
    private NavMeshAgent agent;
     AudioSource NomNom;
    public Text txtScore;
    public int Score = 0;
    public Text txtLives;
    public int lives = 3;
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint1;
    [SerializeField] private Transform respawnPoint2;

    // Use this for initialization
    void Start () {
        agent = gameObject.GetComponent<NavMeshAgent>();
        NomNom = GetComponent<AudioSource>();
        txtScore.text = "Score:" + Score;
        txtLives.text = "Lives:" + lives;
    }
	
	// Update is called once per frame
	void Update () {
            txtScore.text = "Score: " + Score;
            txtLives.text = "Lives: " + lives;

        if (Input.GetMouseButtonDown(0))
            
        {
            RaycastHit hit;
            bool didHit = (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100));
            
            if (didHit && (hit.transform.gameObject.name.Equals("Quad") || hit.transform.gameObject.name.Equals("Sphere")))
            {
                agent.destination = hit.point;
            }


        }

		
	}
    public void OnTriggerEnter(Collider collision)
    {

        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "ghost")
        {
            Debug.Log("We hit this ghost here");
            lives -= 1;

            if (lives == 2)
            {
                player.transform.position = respawnPoint1.transform.position;
            }
            if(lives == 1)
            {
                player.transform.position = respawnPoint2.transform.position;
            }
         
            if (lives == 0)
                             {
                              RestartScreen();
                             }
          

        }

        if (collision.gameObject.tag == "dot")
        {
            NomNom.Play();
            Destroy(collision.gameObject);
            Score = Score + 1;
            txtScore.text = "Score: " + Score.ToString();


        }
            
            
       
    }

    private static void RestartScreen()
    {
        SceneManager.LoadScene("Menu");
    }
}
