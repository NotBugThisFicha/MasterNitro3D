using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewCarTheGarage : MonoBehaviour
{
    [SerializeField] GarageController garageController;
    [SerializeField] ClassObj classObj;
    [SerializeField] Text conclusionNameCarOnUI;
    [SerializeField] Text conclusionOnPowerUI;
    [SerializeField] Text conclusionOnSpeedUI;
    [SerializeField] Text conclusionOnFuelUI;
    [SerializeField] Text UpgrageToUIPanelPowerLvl;
    [SerializeField] Text UpgrageToUIPanelSpeedLvl;
    [SerializeField] Text UpgrageToUIPanelTowerLvl;
    [SerializeField] string[] initeNameCar;
    [SerializeField] string[] NameCarArray = { "�������", "�������666", "����", "������ ����", "�������8" }; //�������� ������
    [SerializeField] AllCarTheGarage allCarTheGarage = new AllCarTheGarage();

    int PowerLvl = 6;
    int SpeedLvl = 11;
    int FuelLvl = 16;
    int PowerState = 8;
    int SpeedState = 13;
    int FuelState = 18;
    int indexMachin;
    private void Start()
    {
        garageController = GetComponent<GarageController>();
        classObj = GetComponent<ClassObj>();
        //Debug.Log("allCarTheGarage " + allCarTheGarage);
        allCarTheGarage = ButtonClassSave.LoadFromPlayerPrefs<AllCarTheGarage>(allCarTheGarage, "AllCarTheGarage");
        DisplayToNameCar();
    }
    public void MethodWrappingMoney()
    {
        garageController.savePlayerStats.Money += 10000;
        garageController.SaveAndConclusionMetod();

    }
    public void UpgradePower() //������� ������ �� �������� ������ � ���������� �������������� � ������� ������.
    {
        string[][] Ttt = { allCarTheGarage.CarYellow, allCarTheGarage.Chev, allCarTheGarage.Vehicle, allCarTheGarage.CarCarbon, allCarTheGarage.FocE };
        int IndexPowerLvl1 = int.Parse(Ttt[indexMachin][PowerLvl]); //�������� ��� ������
        if (IndexPowerLvl1 < allCarTheGarage.upgradeAllLvl.Length - 1 ) 
        {
            int LvlThecurrentCar = int.Parse(allCarTheGarage.upgradeAllLvl[IndexPowerLvl1]);
            if (garageController.savePlayerStats.Money >= LvlThecurrentCar)
            {
                garageController.savePlayerStats.Money -= LvlThecurrentCar; //�������� ������� �����
                IndexPowerLvl1 += 1;
                Ttt[indexMachin][PowerLvl] = IndexPowerLvl1.ToString();
                int state = int.Parse(Ttt[indexMachin][PowerState]);
                state += 5;
                conclusionOnPowerUI.text = Ttt[indexMachin][PowerState] = state.ToString();
                //���������� 
                garageController.SaveAndConclusionMetod();
                ButtonClassSave.SaveToPlayerPrefs<AllCarTheGarage>(allCarTheGarage, "AllCarTheGarage");
            }
            else
            {
                Debug.Log("��� �����");
            }
        }
        else
        {
            Debug.Log("��������� ������������ ���");
        }
    }
    public int ConclusionUpgrageToUIPanel(string[][] Ttt, int indexMachin)
    {
        //���������� ��� 
        int IndexPowerLvl = int.Parse(Ttt[indexMachin][PowerLvl]);
        //Debug.Log("������ ������" + indexMachin + "lvl Power" + IndexPowerLvl);
        int IndexSpeedLvl = int.Parse(Ttt[indexMachin][SpeedLvl]);
        int IndexFuelLvl = int.Parse(Ttt[indexMachin][FuelLvl]);

        //������� ��������� �� ������� ���
        if(IndexPowerLvl < allCarTheGarage.upgradeAllLvl.Length)
        {
            UpgrageToUIPanelPowerLvl.text = allCarTheGarage.upgradeAllLvl[IndexPowerLvl];
        }
        UpgrageToUIPanelSpeedLvl.text = allCarTheGarage.upgradeAllLvl[IndexSpeedLvl];
        UpgrageToUIPanelTowerLvl.text = allCarTheGarage.upgradeAllLvl[IndexFuelLvl];
        return this.indexMachin  = indexMachin;
    }

    public void DisplayToNameCar()
    {
        string[][] Ttt = { allCarTheGarage.CarYellow, allCarTheGarage.Chev, allCarTheGarage.Vehicle, allCarTheGarage.CarCarbon, allCarTheGarage.FocE };

        for (int i = 0; i < NameCarArray.Length; i++)
        {
            if (classObj.gameObjects[i] == classObj.inite)
            {
                conclusionNameCarOnUI.text = NameCarArray[i];
                conclusionOnPowerUI.text = Ttt[i][PowerState]; 
                conclusionOnSpeedUI.text = Ttt[i][SpeedState];
                conclusionOnFuelUI.text = Ttt[i][FuelState];
                Debug.Log("������ ������ " + i);
                ConclusionUpgrageToUIPanel(Ttt, i);
            }
        }
    }
}



