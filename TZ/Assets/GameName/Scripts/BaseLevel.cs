using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseLevel : MonoBehaviour
{
    public static int choosedLevel { get; set; }  //� ���� "choosedLevel" ��������� "numberButton" ��������� ������ � ����� "LevelScene"

    /*
     � ������ "ChoosedLevelNow" ����������� � ������� ��������� ��������� "SwitchCase" ���� ����� 
     "choosedLevel"/
     � ������ �� ����� ���������� � ��������  �����
      "Enemy.speed" � �������� �������� ��������� "count" � "Count.leveltime"
     */
    public void ChoosedLevelNow() {               

        switch (choosedLevel) {
            case 0:
                Enemy.speed = 1f;
                Count.leveltime = 1.5f;
                break;
            case 1 :
                Enemy.speed = 5;
                Count.leveltime = 1f;
                break;
            case 2 :
                Enemy.speed = 10;
                Count.leveltime = 0.5f;
                break;
        }        
    }
    
}
