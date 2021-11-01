using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : UnitController
{
    protected override void Update()
    {
        base.Update();
        if (!isDead && UnitManager.player.health)
        {
            combat.Attak(UnitManager.player.health);
        }
    }
    protected override void Dead()
    {
        base.Dead();
        UnitManager.enemy = null;
    }

}
