using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDamage : MonoBehaviour
{
    public int damageAmount = 10;  // 입힐 데미지 양
    public float moveSpeed = 2f;   // 불의 이동 속도
    public float maxHeight = 5f;   // 불이 올라갈 최대 높이
    public float minHeight = 0f;   // 불이 내려올 최소 높이

    private bool isGoingUp = true;  // 불이 올라가는 상태 여부

    private void Update()
    {
        MoveFire();
    }

    private void MoveFire()
    {
        float step = moveSpeed * Time.deltaTime;

        if (isGoingUp)
        {
            transform.Translate(Vector2.up * step);

            if (transform.position.y >= maxHeight)
            {
                isGoingUp = false;
            }
        }
        else
        {
            transform.Translate(Vector2.down * step);

            if (transform.position.y <= minHeight)
            {
                isGoingUp = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // 플레이어 태그를 가진 객체와 충돌한 경우
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();

            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damageAmount);
            }
        }
    }
}

