using System.Collections;
using UnityEngine;

public class DrumElement : MonoBehaviour
{
    public AudioSource audioSource;

    private Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        if (audioSource == null)
        {
            Debug.LogWarning("DrumElement: AudioSource non assigné sur " + gameObject.name);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision on" + gameObject.name);

        if (collision.gameObject.CompareTag("Stick"))
        {
            Debug.Log("Bâton frappé sur " + gameObject.name);
            PlaySound();
            PlayVisualEffect();
        }
    }

    private void PlaySound()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }

    private void PlayVisualEffect()
    {
        if (rend != null)
        {
            StartCoroutine(Flash());
        }
    }

    private IEnumerator Flash() 
    {
        Color originalColor = rend.material.color;
        rend.material.color = Color.yellow; 
        yield return new WaitForSeconds(0.1f);


        
        rend.material.color = originalColor; 
    }
}