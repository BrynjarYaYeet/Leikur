using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class vPickupItem : MonoBehaviour
{
    //allar breyturnar
    private int cnt;
    public Text countText;
    public Text completeText;
    public GameObject blabla;




    void Start()
    {

        //finnur gameobject með taggið "hurd" og setur inní breytu
        blabla = GameObject.FindWithTag("hurd");
        cnt = 0;
        completeText.text = "";





    }

    private void Update()
    {
        //ef player'in nær 7 kubbum opnast hurðinn
        if (cnt == 7)
        {
            blabla.SetActive(false);
        }
    }


    void OnTriggerEnter(Collider other)
    {
        //Ef player'in collidar við gameobject sem er með taggið "Pick Up" collectar hann það
        if(other.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            cnt++;
            CountText();

        }


    }


    void CountText()
    {
        //update'ar textan eftir breytunni cnt
        countText.text = "Count:" + cnt.ToString() + "/8";
        if (cnt == 8)
        {
            completeText.text = "Completed!!";
        }

    }



}