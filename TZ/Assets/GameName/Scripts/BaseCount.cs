using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  abstract class BaseCount : MonoBehaviour
{
    public int countLong = 0;                    //"countLong" ����������, ������� �������� ������� ����� ������ ��� �������� �� ��������� ��� ����� "0"
     
    public static int countTry = 0;              //"countTry" �������� �� ���������� ����������� �������
    public static float leveltime { get; set; }  //"leveltime" � ������� ���������� ������ ���� �������� �������� "countLong"

    
}
