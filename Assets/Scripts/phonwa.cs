using TMPro;
using UnityEngine;

public class phonwa : MonoBehaviour
{
    public TextMeshProUGUI promptText;
    private bool isPhoneCollected = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Phone ayy");
            isPhoneCollected = true;
            promptText.text = "Here it is...";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
