using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseLose : MonoBehaviour
{
    public GameObject characker { get; set; }        //Объект главного героя
    public bool keyLose { get; set; }                //Отвечает за прекращение работы игровой сцены. Если "keyLose" = "true", то спавн объектов прекращается!
    public Collider2D[] allCollider { get; set; }    //Поле в котором хранятся "Colliders", с которыми пересекается "Character"
    public void CheckCollider() {                                                       //Метод  работает следующим образом. В массив "allCollider" помещается все колайдеры,которые             
        allCollider = Physics2D.OverlapCircleAll(characker.transform.position, 0.5f);   //попадают в радиус метода "OverlapCircleAll".
        if (allCollider.Length > 1 && !keyLose)                                         //У массива "allCollider" вызываем метод "Length", в котором содержится количесвто элементов в массиве.
        {                                                                               //И идет проверка в случае елси, элементов больше 1(так как 1 элемент это коллайдер "Character") и                    
            Debug.Log("Игра окончена!");                                                //"keyLose" будет равен false, то игра окончится и "keyLose" станет "true"
             keyLose = true;
            StopAllCoroutines();                                                        //Прекращает работу всех куратин
        }
    }
    
}
