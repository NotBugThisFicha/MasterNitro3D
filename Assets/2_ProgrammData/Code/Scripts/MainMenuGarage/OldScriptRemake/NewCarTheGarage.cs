using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewCarTheGarage : MonoBehaviour
{
    //[SerializeField] GarageController garageController;
    //[SerializeField] SetActiveCarSceneGarage classObj;
    //[SerializeField] Text conclusionNameCarOnUI;
    //[SerializeField] Text conclusionOnPowerUI;
    //[SerializeField] Text conclusionOnSpeedUI;
    //[SerializeField] Text conclusionOnFuelUI;
    //[SerializeField] Text UpgrageToUIPanelPowerLvl;
    //[SerializeField] Text UpgrageToUIPanelSpeedLvl;
    //[SerializeField] Text UpgrageToUIPanelTowerLvl;
    //[SerializeField] string[] initeNameCar;
    //private string[] NameCarArray = { "Car_1", "Car_2", "Car_3", "Car_4", "Car_5" }; //�������� ������
    //[SerializeField] public static AllCarTheGarage allCarTheGarage = new AllCarTheGarage();
    //[SerializeField] public static SavePlayerStats savePlayerStats = new SavePlayerStats();
    //int PowerLvl = 6;
    //int SpeedLvl = 11;
    //int FuelLvl = 16;
    //int PowerState = 8;
    //int SpeedState = 13;
    //int FuelState = 18;
    //int indexMachin;
    //private void Start()
    //{
    //    garageController = GetComponent<GarageController>();
    //    classObj = GetComponent<SetActiveCarSceneGarage>();
    //    allCarTheGarage = ButtonClassSave.LoadFromPlayerPrefs<AllCarTheGarage>(allCarTheGarage, "AllCarTheGarage");
    //    DisplayToNameCar();
    //}
    //public void MethodWrappingMoney()
    //{
    //    GarageController._savePlayerStats.Money += 10000;
    //    garageController.SaveAndConclusionMetod();

    //}
    //public void ButtonRessetsStateMachin() //����� ���� ������
    //{
    //    allCarTheGarage.CarYellow[PowerState] = 11.ToString();
    //    allCarTheGarage.CarYellow[PowerLvl] = 0.ToString();
    //    ButtonClassSave.SaveToPlayerPrefs<AllCarTheGarage>(allCarTheGarage, "AllCarTheGarage");
    //}
    //public void ButtonRessetsMoney() //����� ����� ������
    //{
    //    GarageController.savePlayerStats.Money = 0;
    //    garageController.SaveAndConclusionMetod();
    //} 
    //public void UpgradePowerTest()
    //{
    //    int IndexPowerLvl1 = int.Parse(allCarTheGarage.CarYellow[PowerLvl]);
    //    if (indexMachin == 0)
    //    {
    //        int LvlThecurrentCar = int.Parse(allCarTheGarage.upgradeAllLvl[IndexPowerLvl1]);
    //        if (GarageController.savePlayerStats.Money >= LvlThecurrentCar)
    //        {
    //            IndexPowerLvl1 += 1;
    //            allCarTheGarage.CarYellow[PowerLvl] = IndexPowerLvl1.ToString();
    //            int state = int.Parse(allCarTheGarage.CarYellow[PowerState]);
    //            state += 10;
    //            conclusionOnPowerUI.text = allCarTheGarage.CarYellow[PowerState] = state.ToString();
    //            //���������� 
    //            garageController.SaveAndConclusionMetod();
    //            ButtonClassSave.SaveToPlayerPrefs<AllCarTheGarage>(allCarTheGarage, "AllCarTheGarage");
    //        }
              
    //    }
        
    //}
    //public void UpgradePower() //������� ������ �� �������� ������ � ���������� �������������� � ������� ������.
    //{
    //    string[][] AllStateMachin = { allCarTheGarage.CarYellow, allCarTheGarage.Chev, allCarTheGarage.Vehicle, allCarTheGarage.CarCarbon, allCarTheGarage.FocE };
    //    int IndexPowerLvl1 = int.Parse(AllStateMachin[indexMachin][PowerLvl]); //�������� ��� ������
    //    if (IndexPowerLvl1 < allCarTheGarage.upgradeAllLvl.Length - 1 ) 
    //    {
    //        int LvlThecurrentCar = int.Parse(allCarTheGarage.upgradeAllLvl[IndexPowerLvl1]);
    //        if (GarageController.savePlayerStats.Money >= LvlThecurrentCar)
    //        {
    //            GarageController.savePlayerStats.Money -= LvlThecurrentCar; //�������� ������� �����
    //            IndexPowerLvl1 += 1;
    //            AllStateMachin[indexMachin][PowerLvl] = IndexPowerLvl1.ToString();
    //            int state = int.Parse(AllStateMachin[indexMachin][PowerState]);
    //            state += 5;
    //            conclusionOnPowerUI.text = AllStateMachin[indexMachin][PowerState] = state.ToString();
    //            //���������� 
    //            garageController.SaveAndConclusionMetod();
    //            ButtonClassSave.SaveToPlayerPrefs<AllCarTheGarage>(allCarTheGarage, "AllCarTheGarage");
    //        }
    //        else
    //        {
    //            Debug.Log("��� �����");
    //        }
    //    }
    //    else
    //    {
    //        Debug.Log("��������� ������������ ���");
    //    }
    //}
    //public int ConclusionUpgrageToUIPanel(string[][] AllStateMachin, int indexMachin)
    //{
    //    //���������� ��� 
    //    int IndexPowerLvl = int.Parse(AllStateMachin[indexMachin][PowerLvl]);
    //    int IndexSpeedLvl = int.Parse(AllStateMachin[indexMachin][SpeedLvl]);
    //    int IndexFuelLvl = int.Parse(AllStateMachin[indexMachin][FuelLvl]);

    //    //������� ��������� �� ������� ���
    //    if(IndexPowerLvl < allCarTheGarage.upgradeAllLvl.Length)
    //    {
    //        UpgrageToUIPanelPowerLvl.text = allCarTheGarage.upgradeAllLvl[IndexPowerLvl];
    //    }
    //    UpgrageToUIPanelSpeedLvl.text = allCarTheGarage.upgradeAllLvl[IndexSpeedLvl];
    //    UpgrageToUIPanelTowerLvl.text = allCarTheGarage.upgradeAllLvl[IndexFuelLvl];
    //    return this.indexMachin  = indexMachin;
    //}

    //public void DisplayToNameCar()
    //{
    //    string[][] AllStateMachin = { allCarTheGarage.CarYellow, allCarTheGarage.Chev, allCarTheGarage.Vehicle, allCarTheGarage.CarCarbon, allCarTheGarage.FocE };

    //    for (int i = 0; i < NameCarArray.Length; i++)
    //    {
    //        if (classObj.gameObjects[i] == classObj.inite)
    //        {
    //            conclusionNameCarOnUI.text = NameCarArray[i];
    //            conclusionOnPowerUI.text = AllStateMachin[i][PowerState]; 
    //            conclusionOnSpeedUI.text = AllStateMachin[i][SpeedState];
    //            conclusionOnFuelUI.text = AllStateMachin[i][FuelState];
    //            ConclusionUpgrageToUIPanel(AllStateMachin, i);
    //        }
    //    }
    //}
}



