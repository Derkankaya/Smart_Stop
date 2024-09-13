using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MahalleOyun : MonoBehaviour
{


    public bool isPausedGame = false;

    public GameObject BtnIstanbul;
    public GameObject BtnBursa;
    public GameObject BtnIzmir;
    public GameObject settingsPanel;

    public AudioSource theme;

    private void Start()
    {

    }

    //İzmir Button
    public void IzmirButton()
    {
        SceneManager.LoadScene("IzmirScene");
    }
    //Ankara Button
    public void IstanbulButton()
    {
        SceneManager.LoadScene("IstanbulScene");
    }
    //Bursa Button
    public void BursaButton()
    {
        SceneManager.LoadScene("BursaScene");
    }


}


