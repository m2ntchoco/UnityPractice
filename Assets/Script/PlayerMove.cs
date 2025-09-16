using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 moveInput;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        
        Vector3 dir = /*new Vector3(h, v, 0)*/ Vector3.right * h + Vector3.up * v;
        //P = P0 + vt 공식으로 변경
        transform.position += dir * speed * Time.deltaTime;
    }
}
