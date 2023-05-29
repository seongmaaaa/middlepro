using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;  // 최대 체력
    private int currentHealth;   // 현재 체력

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // 플레이어가 사망한 경우의 동작을 구현합니다.
        // 예를 들면 게임 오버 화면을 표시하거나 재시작 등의 동작을 수행할 수 있습니다.
    }
}