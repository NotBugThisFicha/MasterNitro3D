using System;
using UnityEngine;

[RequireComponent(typeof(UrlSheetLoading))]
public class DataTransferUsingGoogleSheet : MonoBehaviour // ���������� ������������ ControllerGoogleSheet 
{
    public static event Action<BuyStateToList, int[]> EventData;

    public static event Action<CarStateToList, int[]> OnProcessData;
    public static event Action LoadingCar;

    [SerializeField] private  string _sheetIdBuyStateToList;
    [SerializeField] private  string _sheetIdCarStateToList;
    [SerializeField] private  string _sheetIdGift;

    public BuyStateToList _dataBuy;
    public CarStateToList _dataCar;

    private int[] IndexProduct;
    private UrlSheetLoading _urlSheetLoading; // ���� ��������� �������� ���������� ����� � �������
    private ReadingGoogleSheet _readingGoogleSheet = new ReadingGoogleSheet(); // ���� ��������� ����������� 


    private void Start()
    {
        _urlSheetLoading = GetComponent<UrlSheetLoading>();
        DownloadTable(DataName.BuyState, _sheetIdBuyStateToList);
        DownloadTable(DataName.CarState, _sheetIdCarStateToList);
        // DownloadTable(DataName.CarState, _sheetIdGift, _sheetIdGift);

    }

    private void DownloadTable(DataName dataName, string sheetID, string Listid = null)
    {
        _urlSheetLoading.DownloadTable(sheetID, Listid, OnRawCVSLoaded, dataName);
    }

    private void OnRawCVSLoaded(string rawCVSText, int CurrentProcessedClass)
    {
       
        if (CurrentProcessedClass == (int)DataName.BuyState)
        {
            (_dataBuy, IndexProduct) = (_readingGoogleSheet.ProcessDataOffers(rawCVSText));
            EventData?.Invoke(_dataBuy, IndexProduct); //������ ��������������� ������ � ��������� 
        }
        else if (CurrentProcessedClass == (int)DataName.CarState)
        {
            (_dataCar, IndexProduct) = _readingGoogleSheet.ProcessDataCar(rawCVSText);
            OnProcessData?.Invoke(_dataCar, IndexProduct); //������ ��������������� ������ �� ������� �����
            LoadingCar?.Invoke();
        }
        else
        {
            Debug.LogError("������ ������!!! ������������� � �������� � �������");
        }
    }
}
