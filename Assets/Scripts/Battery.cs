using UnityEngine;

public class Battery : MonoBehaviour
{
    public bool isCollected = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // public void OnTriggerEnter(Collider other)
    // {
    //     if (other.gameObject.tag == "Player")
    //     {
    //         isCollected = true;
    //         Debug.Log("Collected");   
    //     }
    // }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isCollected = true;
            Debug.Log("Collected");  
        }
    }
    // public void OnTriggerExit(Collider other)
    // {
    //     isCollected = true;
    // }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(isCollected);
    }
}
