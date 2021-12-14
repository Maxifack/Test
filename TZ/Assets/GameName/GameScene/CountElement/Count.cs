using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Count : BaseCount
{
    public Text txtCountTime;             //"txtCountTime" UI �������, � ������� ����� ������� ���������� ����� �� ����� ����
    public Text txtLongTry;               //"txtLongTry" UI �������, � ������� ���������� ���������� ����������� ���� (� ���� ���������)
    public Text txtScoreTry;              //"txtScoreTry" UI �������, � �������  ����������  ���������� ������� (� ���� ���������)
    public GameObject allLoseElements;    //"allLoseElements" ������� ������, ������� �� ��������� �� �������, �������� ��� �������� UI, ������� ��������� ��� ���������

    public Lose lose;                     //"lose" �������� ����� �������� "lose.keyLose" ������� �������� true ���� "character" ���������� � �����������
    private void Start()
    {
        countTry++;                        //��� ������ ������� ����� "countTry"  ����� ����� �� "1";
        Replay();                          //� ������ "Replay" ����������� "CountCoroutine"
    }

    void Replay() {
        StartCoroutine(CountCoroutine());
    }
    IEnumerator CountCoroutine() {

            
        if (!lose.keyLose)                              //���� "keyLose" ����� false �� "countLong" ������������� �� "1" � ������������ � "txtCountTime"
        {
            yield return new WaitForSeconds(leveltime);
            countLong++;
            txtCountTime.text = countLong.ToString();
            Replay();
        }else {                                         //����� ���� "keyLose" ����� true, �� "txtCountTime" �����������, � "txtLongTry" � "txtScoreTry" ������������ ���������
            txtCountTime.enabled = false;               //� ������ "allLoseElements" ���������� �������� 
            txtLongTry.text += countLong.ToString();
            txtScoreTry.text += countTry.ToString();
            allLoseElements.SetActive(true);
        }
    }

    
}
