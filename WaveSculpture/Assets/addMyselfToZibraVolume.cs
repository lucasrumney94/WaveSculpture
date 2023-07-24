using System;
using System.Collections;
using System.Collections.Generic;
using com.zibra.liquid.Manipulators;
using com.zibra.liquid.Solver;
using UnityEngine;

public class addMyselfToZibraVolume : MonoBehaviour
{
    public ZibraLiquid zibraLiquidVolume;

    public ZibraLiquidCollider myLiquidCollider;
    void Start()
    {
        zibraLiquidVolume = FindObjectOfType<ZibraLiquid>();
        if (!zibraLiquidVolume.HasCollider(myLiquidCollider))
        {
            zibraLiquidVolume.AddCollider(myLiquidCollider);
        }
    }

    private void OnDestroy()
    {
//        zibraLiquidVolume.RemoveCollider(myLiquidCollider);
    }
}
