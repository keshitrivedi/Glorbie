using UnityEngine;

public class Glass : MonoBehaviour
{
    private bool isGlassActive;
    public GameObject[] Shards = new GameObject[2];
    public GameObject BlurPane;
    public Transform Orientation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isGlassActive = true;
        BlurPane.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        // Shards.transform.rotation = Orientation.rotation;
        if (Input.GetKeyDown(KeyCode.G))
        {
            isGlassActive = !isGlassActive;
            for (int i = 0; i < Shards.Length; i++)
            {
                Shards[i].SetActive(isGlassActive);
            }
            // Shards.SetActive(isGlassActive);
            BlurPane.SetActive(!isGlassActive);
        }
    }
}
