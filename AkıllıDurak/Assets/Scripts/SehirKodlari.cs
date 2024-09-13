using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SehirKodlari : MonoBehaviour
{
    
    public AudioSource audioSource;
    public AudioClip ClipCami;
    public AudioClip ClipPark;
    public AudioClip ClipMekan;
    public AudioClip ClipMahalle;



    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        //InvokeRepeating("PlayPanel0Sound", 0f, 2f);
        if (ClipMahalle != null)
        {

            audioSource.PlayOneShot(ClipMahalle, ClipMahalle.length);
        }
    }

        public void BtnCamiSound()
        {

         audioSource.Stop();
         audioSource.PlayOneShot(ClipCami, ClipCami.length);
        }
        public void BtnParkSound()
        {
         audioSource.Stop();
         audioSource.PlayOneShot(ClipPark, ClipPark.length);
        }
        public void BtnMekanSound()
        {
         audioSource.Stop();
         audioSource.PlayOneShot(ClipMekan, ClipMekan.length);
        }

       
    public void ReturnToMainMenu()
          
        {
             SceneManager.LoadScene("SampleScene");
        }
    




}


    


