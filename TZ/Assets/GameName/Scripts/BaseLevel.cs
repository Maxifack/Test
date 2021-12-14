using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseLevel : MonoBehaviour
{
    public static int choosedLevel { get; set; }  //В поле "choosedLevel" содерится "numberButton" выбронной кнопки в сцене "LevelScene"

    /*
     В методе "ChoosedLevelNow" проверается с помощью условного оператора "SwitchCase" чему равна 
     "choosedLevel"/
     И исходя из этого изменяется с скорость  врага
      "Enemy.speed" и изменеия скорости появления "count" в "Count.leveltime"
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
