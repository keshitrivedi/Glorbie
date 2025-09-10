using UnityEngine;

public class Glass : MonoBehaviour
{
    private bool isGlassActive;
    public GameObject Shards;
    public GameObject BlurPane;
    public Transform Orientation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isGlassActive = true;

    }

    // Update is called once per frame
    void Update()
    {
        // Shards.transform.rotation = Orientation.rotation;
        if (Input.GetKeyDown(KeyCode.G))
        {
            isGlassActive = !isGlassActive;
            Shards.SetActive(isGlassActive);
            BlurPane.SetActive(!isGlassActive);
        }
    }
}
