using UnityEngine;
using System.Collections;

public class Sequencer : MonoBehaviour
{
    public Transform[] kickReceptacles; 
    public Transform[] snareReceptacles; 
    public Transform[] hatsReceptacles; 


    
    public Transform[] bassReceptacles; 



    public float bpm = 100f;  // DONT WORK IDK WHT
    
    
    private float interval;

    public Material activeMaterial; 


    private Material originalMaterial; 

    private void Start()
    {
        interval = 60f / bpm; 
        StartCoroutine(PlaySequence());
    }

private IEnumerator PlaySequence()
{
    while (true)
    {
        interval = 60f / bpm; 
        for (int i = 0; i < 8; i++)
        {
            PlayReceptacleSounds(kickReceptacles[i]);

            PlayReceptacleSounds(snareReceptacles[i]);
            PlayReceptacleSounds(hatsReceptacles[i]);

            PlayReceptacleSounds(bassReceptacles[i]);

            yield return new WaitForSeconds(interval); 
        }
    }
}

    private void PlayReceptacleSounds(Transform receptacle)
    {
        ReceptacleManager manager = receptacle.GetComponent<ReceptacleManager>();
        if (manager != null && manager.hasInput)
        {



            manager.audioSource.Play(); 

            StartCoroutine(ChangeMaterialTemporarily(receptacle));
        }
    }

    private IEnumerator ChangeMaterialTemporarily(Transform receptacle)
    {
        Renderer rend = receptacle.GetComponent<Renderer>();
        if (rend != null)
        {
            originalMaterial = rend.material;
            rend.material = activeMaterial; 




            yield return new WaitForSeconds(interval / 2); 

            rend.material = originalMaterial;
        }
    }
}