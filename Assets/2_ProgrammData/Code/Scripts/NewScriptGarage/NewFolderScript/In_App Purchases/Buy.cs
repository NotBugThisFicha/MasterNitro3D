using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class BuyStateToList: MonoBehaviour//�������������
{
    public List<Buy> ListBuy;

    //public override string ToString()
    //{
    //    string result = "";
    //    CubeOptionsList.ForEach(o =>
    //    {
    //        result += o.ToString();
    //    });
    //    return result;
    //}
}
[System.Serializable]
public class Buy : MonoBehaviour
{
    public int IndexKey;
    public int NameOffer;
    public int CountCurrency;
    public int LevelBust;
    public int PersentBust;
}