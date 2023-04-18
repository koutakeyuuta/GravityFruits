using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMInfomation : MonoBehaviour
{
    private static float VolumeParameter = 0.5f;

    public static void VolumeSetting(float changedValue)
    {
        if(changedValue < 0) throw new System.Exception("正しい値を設定してください");
        if(changedValue > 1) throw new System.Exception("正しい値を設定してください");

        VolumeParameter = changedValue;
    }

    public static float VolumeCheck()
    {
        return VolumeParameter;
    }
}