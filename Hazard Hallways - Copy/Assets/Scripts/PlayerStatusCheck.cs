using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerStatusCheck : MonoBehaviour
{
    private int deaths;
    public Text deathText;
    public Transform startPoint;

    void Start()
    {
        deaths = 0;
        SetDeathsText();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pit"))
        {
            deaths += 1;
            SetDeathsText();
            Respawn();
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hazard"))
        {
            deaths += 1;
            SetDeathsText();
            Respawn();
        }
    }

    void SetDeathsText()
    {
        if (deaths <= 10)
        {
            deathText.text = "Deaths: " + deaths.ToString() + "/10";
        }

        else if (deaths <= 25)
        {
            deathText.text = "Deaths: " + deaths.ToString() + "/25";
        }

        else if (deaths <= 50)
        {
            deathText.text = "Deaths: " + deaths.ToString() + "/50";
        }

        else
        {
            deathText.text = "Deaths: " + deaths.ToString() + "/>:(";
        }
    }

    void Respawn()
    {
        transform.position = startPoint.position;
    }
}
