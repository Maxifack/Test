using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseButtonController : MonoBehaviour
{
    public int countButton { get; set; }                                                   //Количество кнопок
    public Button clickedButton { get; set; }                                              //Кнопка, у которой будет меняться цвет

    public void ChangeColorButtons(GameObject keepButton, int numberButton) {              //Метод "ChangeColorButtons" отввечает за измение цветва кнопки при нажатие на нее!(Доступен в сцене "LevelScene")
        
        for (int i = 0; i < countButton; i++)                         
        {
            clickedButton = keepButton.GetComponent<KeepButton>().LevelButton[i];          //"clickedButton" берез значение из класса "KeepButton", в котором содержаться все кнопки


            if (numberButton == i)                                                         //Если нажатая кнопка со значением "numberButton" равна "i", то есть число элемента в массиве "LevelButton[]".
            {
                clickedButton.GetComponent<Image>().color = Color.red;                     //Мы меняем ее цвет на красный
            }
            else
            {
                clickedButton.GetComponent<Image>().color = Color.white;                   //А оставшиеся кнопки в массиве остаются белыми
            }


        }
    }

    public void ChooseLevelButtons(int numberButton) {                                    //В методе "ChooseLevelButtons", выбранная кнопка "numberButton", равна выбранному уровню сложности.
          Level.choosedLevel = numberButton;                                              
    }


}
