using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10000000000000f;
    void Update()
    {
        Vector3 dir = Vector3.up;
        transform.position += dir * speed * Time.deltaTime;
    }
}
