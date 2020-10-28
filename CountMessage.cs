using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountMessage : MonoBehaviour
{

    public Text message;
    public int CountdownTime;

    // Start is called before the first frame update
    void Start()
    {
        message.text = "You have ten seconds to get all the flowers. Do your job!";

        StartCoroutine(Countdown());
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    IEnumerator Countdown()
    {

       
        while (CountdownTime > 0)
        {

            message.text = CountdownTime.ToString();

            yield return new WaitForSeconds(1f);

            CountdownTime--;

        }
        message.gameObject.SetActive(false);
        

   
    }
}
