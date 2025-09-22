using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    float currentTime;
    public float createTime = 1f;
    public GameObject enemyFactory;
    float minTime = 1f;
    float maxTime = 5f;
    void Start()
    {
        createTime = Random.Range(minTime, maxTime); // 일정시간을 랜덤으로 변경
    }

    void Update()
    {
        currentTime += Time.deltaTime; // 시간 누적;
        if (currentTime > createTime)
        {
            GameObject enemy = Instantiate(enemyFactory); // 게임 오브젝트나 컴포넌트, 프리팹을 런타임 중에 복제(생성)하는 함수
            enemy.transform.position = transform.position;
            currentTime = 0;
        } // Enemy가 서로 부딪혀 계속 파괴되는 현상 방지 --> 현재시간 > 일정시간 경우 현재 시간을 0으로 설정.
        createTime = Random.Range(minTime, maxTime); // 일정시간을 랜덤으로 변경
    }
}
