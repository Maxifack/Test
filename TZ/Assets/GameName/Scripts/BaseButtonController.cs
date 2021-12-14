using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseButtonController : MonoBehaviour
{
    public int countButton { get; set; }                                                   //���������� ������
    public Button clickedButton { get; set; }                                              //������, � ������� ����� �������� ����

    public void ChangeColorButtons(GameObject keepButton, int numberButton) {              //����� "ChangeColorButtons" ��������� �� ������� ������ ������ ��� ������� �� ���!(�������� � ����� "LevelScene")
        
        for (int i = 0; i < countButton; i++)                         
        {
            clickedButton = keepButton.GetComponent<KeepButton>().LevelButton[i];          //"clickedButton" ����� �������� �� ������ "KeepButton", � ������� ����������� ��� ������


            if (numberButton == i)                                                         //���� ������� ������ �� ��������� "numberButton" ����� "i", �� ���� ����� �������� � ������� "LevelButton[]".
            {
                clickedButton.GetComponent<Image>().color = Color.red;                     //�� ������ �� ���� �� �������
            }
            else
            {
                clickedButton.GetComponent<Image>().color = Color.white;                   //� ���������� ������ � ������� �������� ������
            }


        }
    }

    public void ChooseLevelButtons(int numberButton) {                                    //� ������ "ChooseLevelButtons", ��������� ������ "numberButton", ����� ���������� ������ ���������.
          Level.choosedLevel = numberButton;                                              
    }


}
