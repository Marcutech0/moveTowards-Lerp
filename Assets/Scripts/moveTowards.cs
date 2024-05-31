using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTowards : MonoBehaviour
{
    public Transform targetPos;
    public float speed;

    void Start()
    {

    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos.position, speed * Time.deltaTime);
        float currentDistance = Vector3.Distance(transform.position, targetPos.position);
        Debug.Log("Speed:" + speed);
        Debug.Log("Current Distance to Target Pos via Move Towards:" + currentDistance);
    }
}
