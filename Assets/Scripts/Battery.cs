using UnityEngine;

public class Battery : MonoBehaviour
{
    public bool isCollected = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        isCollected = true;
        Debug.Log("Collected");
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
