using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseLose : MonoBehaviour
{
    public GameObject characker { get; set; }        //������ �������� �����
    public bool keyLose { get; set; }                //�������� �� ����������� ������ ������� �����. ���� "keyLose" = "true", �� ����� �������� ������������!
    public Collider2D[] allCollider { get; set; }    //���� � ������� �������� "Colliders", � �������� ������������ "Character"
    public void CheckCollider() {                                                       //�����  �������� ��������� �������. � ������ "allCollider" ���������� ��� ���������,�������             
        allCollider = Physics2D.OverlapCircleAll(characker.transform.position, 0.5f);   //�������� � ������ ������ "OverlapCircleAll".
        if (allCollider.Length > 1 && !keyLose)                                         //� ������� "allCollider" �������� ����� "Length", � ������� ���������� ���������� ��������� � �������.
        {                                                                               //� ���� �������� � ������ ����, ��������� ������ 1(��� ��� 1 ������� ��� ��������� "Character") �                    
            Debug.Log("���� ��������!");                                                //"keyLose" ����� ����� false, �� ���� ��������� � "keyLose" ������ "true"
             keyLose = true;
            StopAllCoroutines();                                                        //���������� ������ ���� �������
        }
    }
    
}
