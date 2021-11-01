using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Combat : MonoBehaviour
{
    [SerializeField] int damage = 1;
    [SerializeField] float cooldown = 1f;

    float cooldownTimer;
    public UnityEvent OnAttak;
   
    void Update()
    {
        if (cooldown > 0)
            cooldownTimer -= Time.deltaTime;
    }

    public void Attak(Health health)
    {
        if (cooldownTimer<=0)
        {
            OnAttak.Invoke();
            health.TakeDamage(damage);
            cooldownTimer = cooldown;
        }
    }
}
