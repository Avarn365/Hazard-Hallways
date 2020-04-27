using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HardLevelSelectA2 : MonoBehaviour
{
    public void DodgeEmButton()
    {
        SceneManager.LoadScene("Dodge 'Em!");
    }

    public void SpinnyThingsButton()
    {
        SceneManager.LoadScene("Spinny Things");
    }
}
