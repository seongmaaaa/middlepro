using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D myrigid;//점프 구현
    [SerializeField]
    private float power;
    // Start is called before the first frame update
    private void Start()
    {
        myrigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myrigid.velocity = Vector2.up * power;
        }
    }
    private void FixedUpdate()
    {
        float hor = Input.GetAxis("Horizontal");
        myrigid.velocity = new Vector2(hor * 3, myrigid.velocity.y);
    }
}
