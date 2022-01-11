using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float speed = 5f;
    public static PlayerMovement instnce;
    [SerializeField] bool RotCar;
    [SerializeField]  GameObject Point;

    [HideInInspector] public RotateType type;

    int rotating;
    bool canMoving;
    private void Start()
    {
        canMoving = false;
        rotating = 0;
        instnce = this;
    }
    void Update() //test ����������
    {
        var ray = new Ray(transform.position, transform.position.normalized);
        Debug.DrawRay(Point.transform.position, ray.direction * 1000);

        float moveSide = Input.GetAxis("Horizontal");
        if (canMoving)
        {
            if(RotCar == false)
            {
                transform.position += transform.forward * Time.deltaTime * speed;
                if (moveSide > 0)
                {
                    transform.position += (new Vector3(1, 0, 0) * Time.deltaTime * 2);
                }
                if (moveSide < 0)
                {
                    transform.position += (new Vector3(-1, 0, 0) * Time.deltaTime * 2);
                }
            }
            else
            {
                transform.position += transform.forward * Time.deltaTime * speed;
                if (moveSide > 0)
                {
                    transform.position += (new Vector3(0, 0, 1) * Time.deltaTime * 2);
                }
                if (moveSide < 0)
                {
                    transform.position += (new Vector3(0, 0, -1) * Time.deltaTime * 2);
                }
            }
          
        }
    }

    public void RotateDirection()
    {
        if (type == RotateType.Left)
        {
            if (rotating != 90)
            {
                var toAngle = Quaternion.Euler(transform.eulerAngles + Vector3.up * -1f);
                rotating++;
                transform.rotation = toAngle; 
                RotCar = true;
            }
            else
            {
                RotatorController.instance.gameObject.SetActive(false);
                rotating = 0;
            }
        }
        if (type == RotateType.Right)
        {
            if (rotating != 90)
            {
                var toAngle = Quaternion.Euler(transform.eulerAngles + Vector3.up * 1f);
                rotating++;
                transform.rotation = toAngle;
              
            }
            else
            {
                RotatorController.instance.gameObject.SetActive(false);
                rotating = 0;
            }
        }
    }

    public void StartMovement()
    {
        canMoving = true;
    }

    public void StopMovement()
    {
        canMoving = false;
    }
}