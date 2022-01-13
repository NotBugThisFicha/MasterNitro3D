using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChecPosChunk : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag + " ���");
        if (other.tag == "ChunkTag")
        {
            Debug.Log(other.tag + " ���");
            if (gameObject.GetComponent<MeshRenderer>() != false)
            {
                Debug.Log("���� " + name);
                gameObject.GetComponent<MeshRenderer>().enabled = false;
                if(GetComponent<BoxCollider>() != null)
                {
                    gameObject.GetComponent<BoxCollider>().enabled = false;
                }
                else
                {
                    gameObject.GetComponent<MeshCollider>().enabled = false;
                 
                }
            } 
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log(" �����" + other.tag);
        if(gameObject.GetComponent<MeshRenderer>().enabled == false)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = true;
        }
        Debug.Log("������ ��������� " + gameObject);
    }
   
}
