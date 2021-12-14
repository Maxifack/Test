using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  abstract class BaseCount : MonoBehaviour
{
    public int countLong = 0;                    //"countLong" переменная, которая отвечает сколько длины прошел наш персонаж по умолчанию она равна "0"
     
    public static int countTry = 0;              //"countTry" отвечает за количество совершенных попыток
    public static float leveltime { get; set; }  //"leveltime" у каждого выбранного уровня своя скорость изменеия "countLong"

    
}
