using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField]
    GameObject Enemy1, Enemy2, Enemy3, Enemy4, Enemy5;
    GameObject SpawnObj;
    int spawnO;
    Stats stats;
    Vector3 Castlepos; 
    void Start()
    {
        Castlepos = this.SpawnObj.transform.position;
        stats = GameObject.Find("EnemyCastle").GetComponent<Stats>();
    }

    void Update()
    {

        
    }

    void SpawnPlay()
    {
        if(stats.currenthp >= 0)
        {
            spawnO = Random.Range(1, 6);    

            switch (spawnO)
            {
                case 1:
                    Instantiate(Enemy1, Castlepos,Quaternion.identity);
                    break;
                case 2:
                    Instantiate(Enemy2, Castlepos, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(Enemy3, Castlepos, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(Enemy4, Castlepos, Quaternion.identity);
                    break;
                case 5:
                    Instantiate(Enemy5, Castlepos, Quaternion.identity);
                    break;
            }
        }
    }
}
