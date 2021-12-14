using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLose : MonoBehaviour, IButton
{

    /*
     В классе "ButtonLose"  так же наследуется от интерфасе "IButton". И при нажатие на кнопку загружается выбранная сцена
     "0" - LevelScene
     "1" - GameScene
     */
    public void PressButton(int buttonNumber)
    {
        SceneManager.LoadScene(buttonNumber);
    }
}
