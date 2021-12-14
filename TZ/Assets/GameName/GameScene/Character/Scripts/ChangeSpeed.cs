using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpeed : MonoBehaviour
{
    public Lose lose;                     //������ �� ����� "Lose", � ������� ���������� "keyLose"
     
    private void Start()
    {
        StartCoroutine(ChangeForce());    //��� ������� ����� ����������� �������� "ChangeForce"
    }

    /*
     � �������� "ChangeForce"  ����������� ����������� ���� � �������, �����  ������ 15 ������ ���� ������������� �� "0.05f".
     ���� "Character" ��������, �� force ����� "1f"
     */
    IEnumerator ChangeForce() {
        while (!lose.keyLose) {
            yield return new WaitForSeconds(15f);
            Character.force += 0.05f;
           
        }
        Character.force = 1f;
    }

}
