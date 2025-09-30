using UnityEngine;

public class DestroyZone : MonoBehaviour
{

    private void OnTriggerEnter(Collider other) //각 영역 안에 들어왔을 때
    {
        if (other.gameObject.layer != LayerMask.NameToLayer("DestroyZone"))
        {
            Destroy(other.gameObject);
        }
        //Destroy(other.gameObject);
    }
}
