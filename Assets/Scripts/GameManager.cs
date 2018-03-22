using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public Maze mazePrefab;

	private Maze mazeInstance;
   
    public GameObject theDot;
    GameObject DotClone;

    public GameObject thePlayer;
    GameObject playerClone;


    public GameObject blinkyGhost;
    GameObject blinkyClone;
    public GameObject inkyGhost;
    GameObject inkyClone;
    public GameObject pinkyGhost;
    GameObject pinkyClone;
    public GameObject clydeGhost;
    GameObject clydeClone;

    [Header("X Spawn Range")]
    public float xMin;
    public float xMax;

    [Header("Z Spawn Range")]
    public float zMin;
    public float zMax;



	private void Start () {
		BeginGame();
        SpawnDots();
        SpawnPlayer();
        SpawnEnemy();


    }
	
	private void Update () {
	if (Input.GetKeyDown(KeyCode.Space)) {
		RestartGame();
		}
	}

	private void BeginGame () {
		mazeInstance = Instantiate(mazePrefab) as Maze;
		//StartCoroutine(mazeInstance.Generate());
	}

	private void RestartGame () {
		StopAllCoroutines();
		Destroy(mazeInstance.gameObject);
		BeginGame();
	}

    private void SpawnDots()
    {
        for (int x = 0; x < 20; x++)
        {
            for (int z = 0; z < 20; z++)
            {
                float Floatx = x - 11 ;
                float Floatz = z - 9;
                float rando = Random.value;
                if (rando > 0.5f)
                {
                 Vector3 spawnOffset = new Vector3(Floatx, 0f, Floatz);
                DotClone = Instantiate(theDot, transform.position + spawnOffset, Quaternion.identity) as GameObject;

                }
          

            }
        }
  
    }
    private void SpawnPlayer()
    {
       // Vector3 spawnOffset = new Vector3(0f, 0f, -8f);
       // playerClone = Instantiate(thePlayer, transform.position + spawnOffset, Quaternion.identity) as GameObject;


    }
    private void SpawnEnemy()
    {
        Vector3 spawnOffset1 = new Vector3(-10f, 0f, 10f);
        blinkyClone = Instantiate(blinkyGhost, transform.position + spawnOffset1, Quaternion.identity) as GameObject;
        Vector3 spawnOffset2 = new Vector3(-4f, 0f, 10f);
        inkyClone = Instantiate(inkyGhost, transform.position + spawnOffset2, Quaternion.identity) as GameObject;
        Vector3 spawnOffset3 = new Vector3(4f, 0f, 10f);
        pinkyClone = Instantiate(pinkyGhost, transform.position + spawnOffset3, Quaternion.identity) as GameObject;
        Vector3 spawnOffset4 = new Vector3(10f, 0f, 10f);
        clydeClone = Instantiate(clydeGhost, transform.position + spawnOffset4, Quaternion.identity) as GameObject;
    }




}