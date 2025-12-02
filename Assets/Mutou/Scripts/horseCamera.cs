using UnityEngine;

public class horseCamera : MonoBehaviour
{
    public Transform target; // プレイヤーのTransform
    public float smoothSpeed = 0.125f; // カメラ移動の滑らかさ
    public Vector3 offset; // カメラとプレイヤー間の距離

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target); // プレイヤーを常に注視
    }
}
