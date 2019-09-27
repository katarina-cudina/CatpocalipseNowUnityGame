using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurvivalObstacles : MonoBehaviour
{
    public float speed = 5f;
    public GameObject cubePrefab1;
    public GameObject cubePrefab2;
    public GameObject cubePrefab3;
    public GameObject star;
    GameObject choice;
    public int waitingTime = 1;

    System.Random rnd;
    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(spawnWave());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void spawnEnemies()
    {
        rnd = new System.Random();
        
        switch(rnd.Next(1,4)){
            case 1:
            choice = cubePrefab1;
            break;
            case 2:
            choice = cubePrefab2;
            break;
            case 3:
            choice = cubePrefab3;
            break;
        }
        GameObject enemyCube = Instantiate(choice) as GameObject;
        enemyCube.transform.position = new Vector3(Random.Range(2f, 14f), 1f, 20f);

    }
    IEnumerator spawnWave(){
        while(true)
        {
            yield return new WaitForSeconds(waitingTime);
            spawnEnemies();
        }
        
    }
}
