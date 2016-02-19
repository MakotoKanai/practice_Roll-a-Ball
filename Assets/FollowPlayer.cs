using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    void Start ()
    {
        // 自分自身と target との相対距離を求める
        offset = GetComponent<Transform>().position - target.position;
    }

    void Update ()
    {
        // 自分の座標に target の座標を代入する
        GetComponent<Transform>().position = target.position + offset;
	}
}
