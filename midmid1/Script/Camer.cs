using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camer : MonoBehaviour //카메라 플레이어 이동 움직임
{
    public Transform target;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime*speed);//카메라 이동
        transform.position = new Vector3(transform.position.x, transform.position.y, -10f); //z값 -10 고정

    }
}
