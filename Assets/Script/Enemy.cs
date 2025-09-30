using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5f;
    public GameObject explosionFactory;
    Vector3 dir;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Vector3 dir; 지역변수 하면 오류 발생 가능성 있음 -> 전역변수로 변경
        int randValue = UnityEngine.Random.Range(0, 10);

        if (randValue < 3)
        {
            GameObject target = GameObject.Find("Player");
            if (target == null)
            {
                Debug.Log("Player 오브젝트를 찾을 수 없습니다.");
                return;
            }
            
            dir = target.transform.position - transform.position; // 타겟의 위치 - 자신의 위치 = 타겟을 향한 방향 벡터
            dir.Normalize(); //정규화 적용 -> Vector의 크기 : 1로 만듦
        }
        else
        {
            dir = Vector3.down; // 정규화 되어있는 것. (0, -1, 0)
        }
    }

    // Update is called once per frame
    void Update()
    {
        //P = P0 + vt 
        //Vector3 dir = Vector3.down;
        transform.position += dir * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision other) // Collsion other enemy와 충돌 //OnTriggerStay 영역 안에 들어와 있을 때 OnTriggerExit
    {
        GameObject explosion = Instantiate(explosionFactory);
        explosion.transform.position = transform.position;

        Destroy(other.gameObject); // 총알 개체의 게임 오브젝트 파괴 함수
        Destroy(gameObject); // enemy 개체의 게임 오브젝트 파괴 함수
    }
}
// Vector
    //Unity에서 제공하는 구조체로, x,y,z 3개의 실수 값을 가지는 벡터
    // 보통 위치, 방향,속도, 힘 등을 표현할 때 사용
    //선언만 하고 초기화는 하지 않은 상태 -> 명시적으로 초기화 권장.

