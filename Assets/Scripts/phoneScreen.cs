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


    public Texture2D phoneHomeTex;
    public Texture2D phonePhotoTex;
    public Texture2D phoneDeadTex;

    private bool openPhoto = false;
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
        phoneImg.color = new Color32(255, 255, 255, 255);
        phoneImg.texture = phoneHomeTex;
        yield return new WaitForSeconds(2);

        promptText.text = "Press P to access photos";

        yield return new WaitUntil(() => openPhoto);
        if (openPhoto)
        {
            phoneImg.texture = phonePhotoTex;

            yield return new WaitForSeconds(3);
            phoneImg.texture = phoneDeadTex;


            yield return new WaitForSeconds(2);
            promptText.text = "Ah shit...";

            openPhoto = false;
            gameObject.SetActive(false);
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
    }

}
