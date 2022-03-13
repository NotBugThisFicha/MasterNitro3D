using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public enum DataName
{
    BuyState, CarState
}
public class UrlSheetLoading : MonoBehaviour 
{
    [SerializeField] private Text text;
    private bool _debug = true;
    private const string url = "https://docs.google.com/spreadsheets/d/*/export?format=csv"; // &gid=2056821665 ����� �����
    public static event Action<bool> NotConnectToServer;


    public void DownloadTable(string sheetId, string addLastString, Action<string, int> onSheetLoadedAction, DataName CurrentProcessedClass)
    {
        string actualUrl = url.Replace("*", sheetId);
        if (addLastString != null)
            actualUrl = actualUrl + addLastString;
        StartCoroutine(DownloadRawCvsTable(actualUrl, onSheetLoadedAction, CurrentProcessedClass));
    }

    private IEnumerator DownloadRawCvsTable(string actualUrl, Action<string, int> callback, DataName CurrentProcessedClass)
    {
        using (UnityWebRequest request = UnityWebRequest.Get(actualUrl))
        {
            yield return request.SendWebRequest();
            if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError ||
                request.result == UnityWebRequest.Result.DataProcessingError)
            {
                Debug.LogError(request.error);
                NotConnectToServer?.Invoke(false);
            }
            else
            {
                if (_debug)
                {
                    Debug.Log(request.downloadHandler.text);
                    text.text = request.downloadHandler.text;
                }
                NotConnectToServer.Invoke(true);
                callback(request.downloadHandler.text,(int)DataName.BuyState);
            }
        }
        yield return null;
    }
}
