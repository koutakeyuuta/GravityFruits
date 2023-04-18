using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 接地判定
/// </summary>
public class GroundCheck : MonoBehaviour
{
    private bool isGround;

    //判定結果を返す
    public bool IsGround()
    {
        return isGround;
    }

    //接地判定
    private void OnTriggerEnter2D(Collider2D collision)
    {
            isGround = true;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
            isGround = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
            isGround = false;
    }
}
