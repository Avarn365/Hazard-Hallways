using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HardLevelSelectAA2 : MonoBehaviour
{
    public void HowLowCanYouGoButton()
    {
        SceneManager.LoadScene("How Low Can You Go");
    }

    public void DarkAsTheNightButton()
    {
        SceneManager.LoadScene("Dark As The Night");
    }
}
