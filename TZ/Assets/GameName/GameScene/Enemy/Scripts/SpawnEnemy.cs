using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : BaseSpawn
{
    public Lose lose;                                     //"lose" �����, �� �������� ����� ������ "keyLose"
    public void Start()                                   //��� ������� ����� ����������� �������� "TimeEnemySpawn"
    {
        StartCoroutine(TimeEnemySpawn());                                           
    }
                                                                 
    public override void Spawn()                          //� ������ Spawn ��������� ������ "Enemy" � ��������� ����������� �� "Y"
    {
        Instantiate(prifabe, new Vector2(prifabe.transform.position.x, PosY()), Quaternion.identity);
    }
    
    /*
     "� �������� "TimeEnemySpawn" ����� ��������� ����� ���������� ����� "Spawn", ���� "keyLose" ����� "true""
     */
    IEnumerator TimeEnemySpawn() {                           
        while (!lose.keyLose) {
            timeEnemySpawn = Random.Range(1, 5);
            yield return new WaitForSeconds(timeEnemySpawn);
            Spawn();
        }
    }
    

    


}
