using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : BaseSpawn
{
    public Lose lose;                                     //"lose" класс, от которого будет братся "keyLose"
    public void Start()                                   //При запуски сцены запускается куратина "TimeEnemySpawn"
    {
        StartCoroutine(TimeEnemySpawn());                                           
    }
                                                                 
    public override void Spawn()                          //В методе Spawn создается объект "Enemy" с рандомной координатой по "Y"
    {
        Instantiate(prifabe, new Vector2(prifabe.transform.position.x, PosY()), Quaternion.identity);
    }
    
    /*
     "В куратине "TimeEnemySpawn" через рандомной время вызывается метод "Spawn", пока "keyLose" равна "true""
     */
    IEnumerator TimeEnemySpawn() {                           
        while (!lose.keyLose) {
            timeEnemySpawn = Random.Range(1, 5);
            yield return new WaitForSeconds(timeEnemySpawn);
            Spawn();
        }
    }
    

    


}
