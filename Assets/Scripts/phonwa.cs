using TMPro;
using UnityEngine;

public class phonwa : MonoBehaviour
{
    public TextMeshProUGUI promptText;
    private bool isPhoneCollected = false;

    public bool IsPhoneCollected()
    {
        return isPhoneCollected;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Phone ayy");
            promptText.text = "Here it is...";
            isPhoneCollected = true;
            // gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
