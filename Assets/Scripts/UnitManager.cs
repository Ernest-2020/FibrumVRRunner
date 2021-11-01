using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitManager : MonoBehaviour
{
    public static UnitController player, enemy;

    public void SetTargetPlayer(UnitController unit)
    {
        player = unit;
    }

    public void SetTargetEnenmy(UnitController unit)
    {
        enemy = unit;
    }

    public void SetNullTarget()
    {
        player = null;
    }
    public void SetNullEnemy()
    {
        enemy = null;
    }
}
