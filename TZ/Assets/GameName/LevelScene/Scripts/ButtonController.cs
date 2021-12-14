using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController : BaseButtonController, IButton
{
    public GameObject keepButton;                                                //Объект класса "KeepButton" в массиве которого храняться все кнопки
    void Start() {
         countButton = keepButton.GetComponent<KeepButton>().LevelButton.Length; //Присвоем "countButton" количество элементов в массиве
    }
    
    public void PressButton(int numberButton)                                    //При нажатие на кнопку вызывается метод "PressButton".                                                                                                 
    {
        ChangeColorButtons(keepButton, numberButton);                            //Метод  "ChangeColorButtons" предназначен для изменеия цвета кнопки, при нажатие на нее.
        ChooseLevelButtons(numberButton);                                        //Метод  "ChooseLevelButtons" предназачен для выбором уровня сложности.
    }

    public void PressButtonStart() {                                             //Метод "PressButtonStart" при нажатие на кнопку "Start" будет запускаться сцена с игрой!
        SceneManager.LoadScene(1);
    }
}
