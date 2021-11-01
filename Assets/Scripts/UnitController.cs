using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitController : MonoBehaviour
{
    [SerializeField] protected Combat combat;
    public Health health;
    protected bool isDead = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
     protected virtual void Update()
    {
        if (isDead)
        {
            if (health.curHealth == 0) Dead();
            {

            }
        }
    }

    protected virtual void Dead()
    {
        isDead = true;
    }
}
