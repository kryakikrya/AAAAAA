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
//3.Создайте префабы кубов-юнитов с Canvas в world space, расположенном внутри кубов-юнитов.
//Расположите их в ряд случайным образом. В Canvas-ах создайте текстовые поля для имени юнита,
//отображения значения здоровья юнита и уровня. Для каждого префаба есть класс Enemy,
//который хранит значения из текстовых полей и меняет их при изменениях извне.

//Создайте Canvas для интерфейса игры. На нем создайте скрипт EnemyChanger.
//В его методе Start инициализируйте массив с экземплярами классов Enemy, со сцены.

//На нем расположите текстовое инпут-поле для ввода значений и кнопки:

//Первая кнопка оставляет видимыми только юниты со здоровьем больше N,
//которое вводится в текстовом поле интерфейса. Остальные юнити отключаются.
//Вторая кнопка оставляет видимыми только юнити определенного левела, который вписан в текстовое поле.
//Остальные скрываются.Третья кнопка сбрасывает все изменения и отображает все кубы.
//Четвертая кнопка находит все имена, совпадающие с введенным значением в текстовое поле и меняет их на "Boss",
//увеличивая уровень на 1 и количество здоровья в 3 раза.
