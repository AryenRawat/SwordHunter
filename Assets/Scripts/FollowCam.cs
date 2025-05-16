using UnityEngine;

public class FollowCam : MonoBehaviour
{
    private float camSpeed=2f;
    public GameObject player;
    private Vector3 offset=new Vector3(0f,2.5f,-10f);
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = player.transform.position+offset;
        transform.position = Vector3.Lerp(transform.position, targetPos,camSpeed);
        
    }
}
