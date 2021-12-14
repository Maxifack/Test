using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseSpawn : MonoBehaviour //�� ������ "BaseSpawn" ����������� ��� ������ ���������� ��� "SpawnCharacter" � "SpawnEnemy"
{
    public GameObject prifabe;                  //"prifabe" ����������� ������ �� "Character" � "Enemy"  
    public float timeEnemySpawn { get; set; }   //��� �����, �� ������� ����� ��������� "Enemy"

    public virtual void Spawn() {               // � ������ "Spawn" ��������� ������ ��� "Character", ��� � "Enemy"
        Instantiate(prifabe);        
    }


    /* 
     � ������ "PozY" ��������� ��������� �������� ��� ����� ��������� ������� �� ���������� "Y"  
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
