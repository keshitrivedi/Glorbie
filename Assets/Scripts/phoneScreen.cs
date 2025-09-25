using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class phoneScreen : MonoBehaviour
{
    private RawImage phoneImg;
    public GameObject PhoneObj;
    private phonwa PhoneObjScript;
    public TextMeshProUGUI promptText;

    // Guy
    // public Image guyImg;
    // public Sprite[] guyFrames = new Sprite[2];

    // phonetex
    public Texture2D phoneHomeTex;
    public Texture2D phonePhotoTex;
    public Texture2D phoneDeadTex;

    public BoxCollider RastaCollider;

    private bool openPhoto = false;

    // colours
    private Color fullOpacity = new Color(255, 255, 255, 255);
    private Color noOpacity = new Color(255, 255, 255, 0);

    // toggle anim

    // private int index = 0;
    // private float timer = 0;
    // public float duration;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // StartCoroutine(phoneScreenNav());
        PhoneObjScript = PhoneObj.GetComponent<phonwa>();
        phoneImg = gameObject.GetComponent<RawImage>();

    }

    private IEnumerator phoneScreenNav()
    {
        
        PhoneObj.SetActive(false);
        Debug.Log("Accessible Hello");
        phoneImg.color = fullOpacity;
        phoneImg.texture = phoneHomeTex;
        yield return new WaitForSeconds(2);

        promptText.text = "Press P to access photos";

        yield return new WaitUntil(() => openPhoto);
        if (openPhoto)
        {
            // guyImg.color = noOpacity;
            phoneImg.texture = phonePhotoTex;

            yield return new WaitForSeconds(3);
            phoneImg.texture = phoneDeadTex;


            yield return new WaitForSeconds(2);
            promptText.text = "Ah shit...";

            yield return new WaitForSeconds(1);
            // guyImg.color = noOpacity;
            promptText.text = "...";

            // wait for a few seconds before sending john to the void

            openPhoto = false;
            gameObject.SetActive(false);

            RastaCollider.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (PhoneObjScript.IsPhoneCollected() && phoneImg.texture == null)
        {
            StartCoroutine(phoneScreenNav());
        }

        if (Input.GetKeyDown(KeyCode.P) && PhoneObjScript.IsPhoneCollected())
        {
            Debug.Log("P pressed");
            openPhoto = true;
        }

        // if ((timer += Time.deltaTime) >= (duration / guyFrames.Length))
        // {
        //     timer = 0;
        //     guyImg.sprite = guyFrames[index];
        //     index = (index + 1) % guyFrames.Length;
        // }
    }

}
