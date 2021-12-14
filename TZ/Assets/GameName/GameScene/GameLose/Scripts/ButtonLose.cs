using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLose : MonoBehaviour, IButton
{

    /*
     � ������ "ButtonLose"  ��� �� ����������� �� ��������� "IButton". � ��� ������� �� ������ ����������� ��������� �����
     "0" - LevelScene
     "1" - GameScene
     */
    public void PressButton(int buttonNumber)
    {
        SceneManager.LoadScene(buttonNumber);
    }
}
