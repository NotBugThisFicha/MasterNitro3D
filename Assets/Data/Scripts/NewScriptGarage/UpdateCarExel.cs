using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class UpdateCarExel : MonoBehaviour //Load Class
{
    public static List<CarS_Player> ListClassCarState; // ���� ���� ����� ���������� � ������� ������
    private int indexCar;

    void Awake()
    {
        //for (int i = 0; i < index.indices.Count; i++)
        //{
        //    index.indices.Remove(i);
        //}
        //CarS_Player[] CarS_Player = new CarS_Player[] { };
        ListClassCarState = ExelStateMachin.CarStatsRead();
        foreach (var item in ListClassCarState) //�������� � �������������� ������� � ������� �� ������� 
        {
            Debug.Log(item.Power);
            if (indexCar != item.IndexMachin)
            {
                this.indexCar = item.IndexMachin;
                index.indices.Add(item.IndexMachin);
                Debug.Log(item.IndexMachin);
            }
        }
    }

}
