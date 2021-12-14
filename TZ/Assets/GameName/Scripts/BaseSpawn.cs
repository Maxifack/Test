using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseSpawn : MonoBehaviour //От класса "BaseSpawn" наследуется два класса наследника это "SpawnCharacter" и "SpawnEnemy"
{
    public GameObject prifabe;                  //"prifabe" принимается прифаб от "Character" и "Enemy"  
    public float timeEnemySpawn { get; set; }   //Это время, за которое будет спавнется "Enemy"

    public virtual void Spawn() {               // В методе "Spawn" создаются объект как "Character", так и "Enemy"
        Instantiate(prifabe);        
    }


    /* 
     В методе "PozY" создается рандомное значение где будет спавнится элемент по координате "Y"  
     */
    public float PosY()
    {
        float range = Random.Range(0f, 3f);
        if (range > 0 && range < 1)
        {
            return 0f;
        }
        else if (range > 1 && range < 2)
        {
            return 2.6f;
        }
        else
        {
            return -2.6f;
        }
    }
}
