using UnityEngine;
using UnityEngine.UI;

public class guyAnim : MonoBehaviour
{
    private Image currImage;
    private int index = 0;
    private float timer = 0;
    public float duration;
    public Sprite[] guyFrames = new Sprite[2];
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currImage = gameObject.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((timer += Time.deltaTime) >= (duration / guyFrames.Length))
        {
            timer = 0;
            currImage.sprite = guyFrames[index];
            index = (index + 1) % guyFrames.Length;
        }
    }
}
