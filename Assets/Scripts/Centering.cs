using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Centering : MonoBehaviour
{
    [SerializeField] Transform pivot;
    [SerializeField] CapsuleCollider myCol;

    private Vector3 vec;

    private void OnValidate()
    {
        myCol = GetComponent<CapsuleCollider>();
    }
    private void Start()
    {
        FindTeleportPivotandTarget();
        vec.y = myCol.center.y;
    }

    private void Update()
    {
        vec.x = pivot.localPosition.x;
        vec.x = pivot.localPosition.z;
    }

    private void FindTeleportPivotandTarget()
    {
        foreach (var cam in Camera.allCameras)
        {
            if (!cam.enabled) { continue; }
            if (cam.stereoTargetEye != StereoTargetEyeMask.Both) { continue; }
            pivot = cam.transform;

        }
    }
}
