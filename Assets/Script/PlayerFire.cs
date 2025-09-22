using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletFactory;
    public GameObject firepositon;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            // 씬에서 새로운 게임 오브젝트를 동적으로 생성하는 기능을 제공, 게임 중에 오브젝트를 생성하고, 위치, 회전 등 설정하는데 사용, 특정 Object를 clone하여 특정 위치에 특정 회전된 상태로 생성, 프리팹 또는 기존 게임 오브젝트를 복제하여 사용.
            GameObject bullet = Instantiate(bulletFactory); // Instantiate(복제할 오브젝트, 위치, 회전)
            bullet.transform.position = firepositon.transform.position;
        }
    }
}
