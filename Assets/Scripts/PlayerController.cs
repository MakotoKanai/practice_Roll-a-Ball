using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    // プレイヤにかかる力の倍率
    public float speed = 10;

    void FixedUpdate ()
    {
        // 入力に x と y を代入
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // 同一の GameObject が持つ Rigidbody コンポーネントを取得
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        // rigidbody の x 軸（横）と z 軸（奥）に力を入れる
        rigidbody.AddForce(x * speed, 0, z * speed);
    }
}
