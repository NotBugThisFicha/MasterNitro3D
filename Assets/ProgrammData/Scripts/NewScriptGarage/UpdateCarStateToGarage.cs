using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateCarStateToGarage : MonoBehaviour //EventConclusionTheDisplayUIStatsMachin //������� ������ �������� ������ 
{
    public int Power = 10;
    public int IndexCar;
    AllGarageCarsThePlayer allGarageCarsThePlayer = new AllGarageCarsThePlayer();
    private List<int> intermediateIndex = new List<int>();
    public  List<CarS_Player> ItemsListMachin = new List<CarS_Player>();

    private void Start() //Load
    {
        allGarageCarsThePlayer = ButtonClassSave.LoadFromPlayerPrefs<AllGarageCarsThePlayer>(allGarageCarsThePlayer, "AllGarageCarsThePlayer");
        EventManagerGame.AddListener<EventPushList>(GetIndexMachin);
        jogIndex();
        LoadingStatsPoIndex();
    }
    public void UpgradeStatePower()
    {
        if (true)//������ ������ ���-�� �� ������
        {

        }
        Test1 evt= EventManager.Test1;
        evt.Power = Power;
        EventManagerGame.Broadcast(evt);
        LoadingStatsPoIndex();

    }
    public void UpgradeStateSpeed()
    {
        Test1 evt = EventManager.Test1;
        evt.Speed = Power;
        EventManagerGame.Broadcast(evt);
    }
    public void UpgradeStateControl()
    {
        Test1 evt = EventManager.Test1;
        evt.Control = Power;
        EventManagerGame.Broadcast(evt);
    }
    public void jogIndex()
    {
        foreach (var item in index.indices)
        {
            intermediateIndex.Add(item);
        }
        foreach (var item in AllGarageCarsThePlayer.AllCarState) //�������� �� ���������� ������ ����� ���������� � Json file.
        {
            foreach (var it in index.indices)
            {
                if (item.IndexMachin.ToString() == it.ToString())
                {
                    intermediateIndex.Remove(it);
                }
            }
        }
        foreach (var item in intermediateIndex) //���������� ��������� ���� ��� ������
        {
            foreach (var it in UpdateCarExel.ListClassCarState)
            {
                if (item == it.IndexMachin)
                {
                    CarS_Player CarS_Player = new CarS_Player();
                    CarS_Player.IndexMachin = it.IndexMachin;
                    CarS_Player.Power = it.Power;
                    CarS_Player.Speed = it.Speed;
                    CarS_Player.Control = it.Control;
                    CarS_Player.NameCar = it.NameCar;
                    AllGarageCarsThePlayer.AllCarState.Add(CarS_Player);
                    break;
                }

            }
        }
    }
    public void ChecState()
    {

    }
    public void LoadingStatsPoIndex()
    {
        for (int i = 0; i < ItemsListMachin.Count; i++)
        {
            if(ItemsListMachin.Count == 0)
            {
                break;
            }
            ItemsListMachin.Clear() ;
        }
        foreach (var item in UpdateCarExel.ListClassCarState) //������� ������, ������������ ��� �������� 
        {//��������� ������ ������ �� ������.
            if (SetActiveCarSceneGarage.IndexMachinInList == item.IndexMachin)
            {
                ItemsListMachin.Add(item);
            }
            //if (SetActiveCarSceneGarage.IndexMachinInList != item.IndexMachin)
            //{
            //    //���� ����� ���� ��� , �� �������� +9 i �������� ������� �������
            //}
            //for (int i = 0; i < AllGarageCarsThePlayer.AllCarState.Count; i++)
            //{
            //    AllGarageCarsThePlayer.AllCarState[i].
            //}
        }
    }
    public void GetIndexMachin(EventPushList evt)
    {
        this.IndexCar = evt.indexCarMachin;
    }
}
