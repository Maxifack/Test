using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Count : BaseCount
{
    public Text txtCountTime;             //"txtCountTime" UI элемент, в котором будет показан количесвто очков во время игры
    public Text txtLongTry;               //"txtLongTry" UI элемент, в котором изображено количесвто пройденного пути (В окне проигрыша)
    public Text txtScoreTry;              //"txtScoreTry" UI элемент, в котором  изображено  количесвто попыток (В окне проигрыша)
    public GameObject allLoseElements;    //"allLoseElements" игровой объект, который по умолчанию не активен, содержит все элементы UI, которые всплывают при проигрыше

    public Lose lose;                     //"lose" позвлоит брать комопнет "lose.keyLose" который является true если "character" столкнулся с коллайдером
    private void Start()
    {
        countTry++;                        //При каждом запуске сцены "countTry"  будет рости на "1";
        Replay();                          //В методе "Replay" запускается "CountCoroutine"
    }

    void Replay() {
        StartCoroutine(CountCoroutine());
    }
    IEnumerator CountCoroutine() {

            
        if (!lose.keyLose)                              //Если "keyLose" равна false то "countLong" увеличивается на "1" и показывается в "txtCountTime"
        {
            yield return new WaitForSeconds(leveltime);
            countLong++;
            txtCountTime.text = countLong.ToString();
            Replay();
        }else {                                         //Иначе если "keyLose" равза true, то "txtCountTime" отключается, в "txtLongTry" и "txtScoreTry" отображается результат
            txtCountTime.enabled = false;               //И объект "allLoseElements" становится активным 
            txtLongTry.text += countLong.ToString();
            txtScoreTry.text += countTry.ToString();
            allLoseElements.SetActive(true);
        }
    }

    
}
