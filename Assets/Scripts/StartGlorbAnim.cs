using UnityEngine;
using UnityEngine.UI;

public class StartGlorbAnim : MonoBehaviour
{

    // public Sprite Frame0;
    // public Sprite Frame1;
    // public Sprite Frame2;
    // public Sprite Frame3;

    public Sprite[] glorbFrames = new Sprite[4];
    private Image currImg;
    private int index = 0;
    private float timer = 0;

    public float duration;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currImg = gameObject.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((timer += Time.deltaTime) >= (duration / glorbFrames.Length))
        {
            timer = 0;
            // How tf do I change the source image mffff
            currImg.sprite = glorbFrames[index];
            index = (index + 1) % glorbFrames.Length;
        }
    }
}
