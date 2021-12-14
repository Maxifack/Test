using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : BaseLose
{
    public Controller controller;                                       //Ссылка на скрипт "Controller"
    private void Start()
    {                               
        keyLose = false;                                                //При старте игровой сцены, спав работает по этому "keyLose" равен "false"
        characker = controller.GetComponent<Controller>().character;    //Игровому объекту "character" присваеваем "Character", который расположен в классе Character    
    }

    private void Update()
    {
        CheckCollider();                                                 //Выполняет работу связаную  со столкновением коллайдеров "character" с "enemy"                 
    }

    

    

}
