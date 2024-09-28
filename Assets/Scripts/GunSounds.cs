using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSounds : MonoBehaviour
{
    public float ClipLength = 1f;
    public GameObject AudioClip;

    void Start()
    {
        AudioClip.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(PlaySound());
        }

    }
    IEnumerator PlaySound()
    {
        AudioClip.SetActive(true);
        yield return new WaitForSeconds(ClipLength);
        AudioClip.SetActive(false);
    }
}
