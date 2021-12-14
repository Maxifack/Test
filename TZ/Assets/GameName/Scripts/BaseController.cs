using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseController : MonoBehaviour
{
    public GameObject character { get; set; }                                                   //"character" - это персонаж, который спавница в сцене "GameScene" 
    protected bool pressMode { get; set; }                                                      //Переменная, которая при нажатие равняется "true", при отжатие "false"
    private Character characterScript { get; set; }                                             //"characterScripts"  это скрипт на объекте "character", в котором содержится доступ к "rb" и "force"
    
   


    public void Move(GameObject character) {                                                     //метод "Move" принимает объект "character"
        characterScript = character.GetComponent<Character>();                                   //"characterScript" присваевает класс на объекте "Character" класс "Character"
        characterScript.rb.AddForce(Vector2.up * Character.force, ForceMode2D.Impulse);    //В классе "Character" есть поле "rb" = RigidBody2D и "force"   
        Debug.Log($"CharacterForce: {Character.force}");
    }


   

}
