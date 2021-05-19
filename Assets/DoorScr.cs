using UnityEngine;

public class DoorScr : MonoBehaviour
{
    public GameObject info;
    bool check = false;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (check == false)
            {
                info.SetActive(true);
                Invoke("wait",5f);
            }
        }
    }

    void wait()
    {
        info.SetActive(false);
    }
}
