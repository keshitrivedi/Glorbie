using UnityEngine;
using System.Threading.Tasks;
using TMPro;
using UnityEngine.UI;
using System.Collections;

public class gameUIText : MonoBehaviour
{
    private TextMeshProUGUI promptText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("I exist");
        promptText = gameObject.GetComponent<TextMeshProUGUI>();
        StartCoroutine(textDisplay());
    }

    private IEnumerator textDisplay()
    {
        promptText.text = "Oh god...";
        yield return new WaitForSeconds(2);

        promptText.text = "I think I got jumped...";
        yield return new WaitForSeconds(2);

        promptText.text = "Wait...";
        yield return new WaitForSeconds(1);

        promptText.text = "Where is Glorb.";
        yield return new WaitForSeconds(2);

        promptText.text = "Ah shit";
        yield return new WaitForSeconds(2);
        
        promptText.text = "...";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
