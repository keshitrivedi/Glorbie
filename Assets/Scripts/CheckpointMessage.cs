using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class CheckpointMessage : MonoBehaviour
{
    public TextMeshProUGUI promptText;
    public String message;
    private bool inRegion = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(customMessage());
    }

    private IEnumerator customMessage()
    {
        if (inRegion)
        {
            promptText.text = message;
            yield return new WaitForSeconds(2);
            yield return new WaitUntil(() => !inRegion);
            promptText.text = "...";
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Recorded");
        // promptText.text = message;
        inRegion = true;
    }

    void OnTriggerExit(Collider other)
    {
        inRegion = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
