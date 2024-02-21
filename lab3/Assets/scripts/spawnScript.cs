using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float spawnRate = 1.0f;
    public GameObject enemyPrefab;
    // Update is called once per frame
    private float timePast = 0;
    
    void Start()
    {
        StartCoroutine(SpawnWithDelayCoroutine());
    }
    IEnumerator SpawnWithDelayCoroutine(){
        while(true){
            yield return new WaitForSeconds(spawnRate);
            spawnEnemy();
            
        }
        
    }
    private void spawnEnemy(){
        int spawn = Random.Range(0, 2);
        
        if(spawn == 0){
            Vector3 spawnPos = new Vector3(-33, Random.Range(-30, 92),0);
            GameObject l = Instantiate(enemyPrefab, spawnPos, Quaternion.Euler(0, 180, 0)); 
        }
        else{
            Vector3 spawnPos = new Vector3(381, Random.Range(-30, 92),0);
            GameObject l = Instantiate(enemyPrefab, spawnPos, Quaternion.Euler(0, 0, 0)); 
        }

        
        
    }
    void Update()
    {
        timePast += Time.deltaTime;
        //increase spawn rate
        
    }
}

