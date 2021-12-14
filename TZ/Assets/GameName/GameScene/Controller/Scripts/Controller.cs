using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : BaseController                
{
    public SpawnEnemy spawnEnemy;                        //Ссылкка на скрипт "SpawnEnemy"
    public SpawnCharacter spawnCharacter;                //Ссылка на скрипт "SpawnCharacter"
    private void Start()
    {        
        spawnCharacter.Spawn();                          //В скрипте "SpawnCharacter" содержится метод Spawn,который отвечает за спавн "Character"
        character = GameObject.Find("Character(Clone)"); //С помощью метода "Find" мы находим наш объект на сцене (Да я понимаю, что это метод лучше не использовать, но в данной ситуации у нас объектов на сцене не так много!)
        spawnEnemy.Spawn();                              //В скрипте "SpawnEnemy" содержится метод Spawn,который отвечает за спавн "Enemy"                    
    }

    //Далее в методах PushDown и PushUp реализовывается зажатие и отжатие кнопки "Controller" и идет измение "pressMode"
    public void PushDown() {  
        pressMode = true;
    }

    public void PushUp() {
        pressMode = false;
    }

    //Так как у нас ведется работа с RigidBody то лучше использовать метод "FixedUpdate".В нашем случае если "pressMode" равен "true", то реализовыется метод Move
    private void FixedUpdate()
    {
        if (pressMode)
        {
            Move(character);
        }
    }


}
