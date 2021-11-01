using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PlyerController : UnitController
{

    private VirtualButtonBehaviour virtualButton;
    

   
    void Start()
    {
        virtualButton = gameObject.transform.parent.GetComponentInChildren<VirtualButtonBehaviour>();
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (!isDead && UnitManager.enemy !=null)
        {
            combat.Attak(UnitManager.enemy.health);
        }
    }

    public void OnButtonRealesed(VirtualButtonBehaviour vb)
    {

    }

    protected override void Dead()
    {
        base.Dead();
        UnitManager.player = null;
    }

}
