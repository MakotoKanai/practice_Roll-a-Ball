using UnityEngine;
using System.Collections;

public class DangerWall : MonoBehaviour
{
    // オブジェクトと接触した時に呼ばれるコールバック
    void OnCollisionEnter(Collision hit)
    {
        // 接触したオブジェクトのタグが"Player"の場合
        if (hit.gameObject.CompareTag("Player"))
        {
            // 現在のシーンを再読込する
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}