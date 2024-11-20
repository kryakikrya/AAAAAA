using Palmmedia.ReportGenerator.Core;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI nameText;
    [SerializeField] TextMeshProUGUI lvlText;
    [SerializeField] TextMeshProUGUI healthText;
    [SerializeField] string name;
    [SerializeField] int lvl;
    [SerializeField] int health;
    [SerializeField] GameObject me;
    public string startname;
    public int startlvl;
    public int starthealth;
    private void Start()
    {
        nameText.text = name;
        lvlText.text = $"LVL {lvl}";
        healthText.text = $"Health {health}";
        startname = name;
        starthealth = health;
        startlvl = lvl;
    }
    public void SetName(string newName)
    {
        name = newName;
        nameText.text = name;
    }
    public void SetLvl(int newLvl)
    {
        lvl = newLvl;
        lvlText.text = $"LVL {lvl}";
    }
    public void SetHealth(int newHealth)
    {
        health = newHealth;
        healthText.text = $"Health {health}";
    }
    public string GetName()
    {
        return name;
    }
    public int GetLvl()
    {
        return lvl;
    }
    public int GetHealth()
    {
        return health;
    }
    public void Activator()
    {
        me.SetActive(true);
    }
    public void Deactivator()
    {
        me.SetActive(false);
    }
}
//3.�������� ������� �����-������ � Canvas � world space, ������������� ������ �����-������.
//����������� �� � ��� ��������� �������. � Canvas-�� �������� ��������� ���� ��� ����� �����,
//����������� �������� �������� ����� � ������. ��� ������� ������� ���� ����� Enemy,
//������� ������ �������� �� ��������� ����� � ������ �� ��� ���������� �����.

//�������� Canvas ��� ���������� ����. �� ��� �������� ������ EnemyChanger.
//� ��� ������ Start ��������������� ������ � ������������ ������� Enemy, �� �����.

//�� ��� ����������� ��������� �����-���� ��� ����� �������� � ������:

//������ ������ ��������� �������� ������ ����� �� ��������� ������ N,
//������� �������� � ��������� ���� ����������. ��������� ����� �����������.
//������ ������ ��������� �������� ������ ����� ������������� ������, ������� ������ � ��������� ����.
//��������� ����������.������ ������ ���������� ��� ��������� � ���������� ��� ����.
//��������� ������ ������� ��� �����, ����������� � ��������� ��������� � ��������� ���� � ������ �� �� "Boss",
//���������� ������� �� 1 � ���������� �������� � 3 ����.
