using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int maxValue = 10;
    private int value;
    public int curHealth { get { return value; } }
    // Start is called before the first frame update
    void Start()
    {
        value = maxValue;
    }

    public void TakeDamage(int damage)
    {
        if (value>0)
        {
            value = -damage;
            if (value < 0) value = 0; 
        }
    }
}
