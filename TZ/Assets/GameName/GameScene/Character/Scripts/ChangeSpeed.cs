using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpeed : MonoBehaviour
{
    public Lose lose;                     //Ссылка на класс "Lose", в котором содержится "keyLose"
     
    private void Start()
    {
        StartCoroutine(ChangeForce());    //При страрте сцены запускается куратина "ChangeForce"
    }

    /*
     В куратине "ChangeForce"  выполняется прибовление силы к объекту, через  каждые 15 секунд сила увеличивается на "0.05f".
     Если "Character" проиграл, то force равна "1f"
     */
    IEnumerator ChangeForce() {
        while (!lose.keyLose) {
            yield return new WaitForSeconds(15f);
            Character.force += 0.05f;
           
        }
        Character.force = 1f;
    }

}
