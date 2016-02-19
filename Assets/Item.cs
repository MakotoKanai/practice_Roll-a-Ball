using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour
{
    // トリガーとの接触時に呼ばれるコールバック
    void OnTriggerEnter (Collider Hit)
    {
	    // 接触対象は Player タグ？
        if (Hit.CompareTag("Player"))
        {
            // このコンポーネントを持つ GameObject を破棄する
            Destroy(gameObject);
        }
	}
}
