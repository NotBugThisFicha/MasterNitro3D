using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class EventManager : MonoBehaviour
{
    [SerializeField] Text MoneDisplayUi;
    int Money; //���������� ������� ���-�� �����
    public static UnityEvent<int> MoneyDisplay = new UnityEvent<int>();
    public void StateMoneyUpdateDisplayUi(int CountMoneyScene)
    {
        if (MoneyDisplay != null)
        {
            MoneyDisplay.Invoke(CountMoneyScene);
            Money += CountMoneyScene;
            MoneDisplayUi.text = Money.ToString();
        }
    }
}
