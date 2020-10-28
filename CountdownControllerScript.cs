using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownControllerScript : MonoBehaviour
{

    public int CountdownTime;
    public Text display;
    public PlantinhaGameManager manager;
    public GameObject camTPP;
    public AudioSource SfxTpp;



    private void Start()
    {
        
        StartCoroutine(Countdown());

    }

    IEnumerator Countdown() {

        //yield return new WaitForSeconds(0.8f);
        SfxTpp.Play();
        yield return new WaitForSeconds(5f);
        camTPP.SetActive(true);
        while (CountdownTime > 0) {

            display.text = CountdownTime.ToString();

            yield return new WaitForSeconds(1f);

            CountdownTime--;

        }
        display.text = "GO!TAKE IT HOME";

        yield return new WaitForSeconds(1f);

        display.gameObject.SetActive(false);
        manager.GameStart();
    }
}
