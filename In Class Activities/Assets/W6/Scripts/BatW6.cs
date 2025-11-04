using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform playerTransform;

    

    public void EnableChase(Transform Player)
    {
        enabled = true;
        playerTransform = Player;
    }
    
    public void DisableChase()
    {
        enabled = false;
    }

    public void Start()
    {
        DisableChase();
    }

    public void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerTransform.position, speed * Time.deltaTime);
    }
}
