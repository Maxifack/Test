using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : BaseLose
{
    public Controller controller;                                       //������ �� ������ "Controller"
    private void Start()
    {                               
        keyLose = false;                                                //��� ������ ������� �����, ���� �������� �� ����� "keyLose" ����� "false"
        characker = controller.GetComponent<Controller>().character;    //�������� ������� "character" ����������� "Character", ������� ���������� � ������ Character    
    }

    private void Update()
    {
        CheckCollider();                                                 //��������� ������ ��������  �� ������������� ����������� "character" � "enemy"                 
    }

    

    

}
