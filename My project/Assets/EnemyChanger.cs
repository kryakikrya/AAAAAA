using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyChanger : MonoBehaviour
{
    [SerializeField] TMP_InputField inputField;
    Enemy[] enemyArray;
    void Start()
    {
        enemyArray = GameObject.FindObjectsOfType<Enemy>();
    }

    public void FirstButton()
    {
        for (int i = 0; i < enemyArray.Length; i++) 
        {
            if (enemyArray[i].GetHealth() > int.Parse(inputField.text))
            {
                enemyArray[i].Activator();
            }
            else
            {
                enemyArray[i].Deactivator();
            }
        }
    }
    public void SecondButton()
    {
        for (int i = 0; i < enemyArray.Length; i++)
        {
            if (enemyArray[i].GetLvl() == int.Parse(inputField.text))
            {
                enemyArray[i].Activator();
            }
            else
            {
                enemyArray[i].Deactivator();
            }
        }
    }
    public void ThirdButton()
    {
        for (int i = 0; i < enemyArray.Length; i++)
        {
            enemyArray[i].Activator();
            enemyArray[i].SetName(enemyArray[i].startname);
            enemyArray[i].SetLvl(enemyArray[i].startlvl);
            enemyArray[i].SetHealth(enemyArray[i].starthealth);
        }
    }
    public void ForthButton()
    {
        {
            for (int i = 0; i < enemyArray.Length; i++)
            {
                if (enemyArray[i].GetName() == inputField.text)
                {
                    enemyArray[i].SetHealth(enemyArray[i].GetHealth() * 3);
                    enemyArray[i].SetName("Boss");
                    enemyArray[i].SetLvl(enemyArray[i].GetLvl() + 1);
                }
            }
        }
    }

    //На нем расположите текстовое инпут-поле для ввода значений и кнопки:

    //Первая кнопка оставляет видимыми только юниты со здоровьем больше N,
    //которое вводится в текстовом поле интерфейса. Остальные юнити отключаются.
    //Вторая кнопка оставляет видимыми только юнити определенного левела, который вписан в текстовое поле.
    //Остальные скрываются.Третья кнопка сбрасывает все изменения и отображает все кубы.
    //Четвертая кнопка находит все имена, совпадающие с введенным значением в текстовое поле и меняет их на "Boss",
    //увеличивая уровень на 1 и количество здоровья в 3 раза.
}
