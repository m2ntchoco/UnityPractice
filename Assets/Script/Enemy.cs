using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //P = P0 + vt 
        Vector3 dir = Vector3.down;
        transform.position += dir * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision other) // Collsion other enemy와 충돌 
    {
        Destroy(other.gameObject); // 총알 개체의 게임 오브젝트 파괴 함수
        Destroy(gameObject); // enemy 개체의 게임 오브젝트 파괴 함수
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
    
    }
}
