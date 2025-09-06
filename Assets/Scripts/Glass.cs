using UnityEngine;

public class Glass : MonoBehaviour
{
    private bool isActive;
    public GameObject Shards;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            isActive = !isActive;
            Shards.SetActive(isActive);
        }
    }
}
