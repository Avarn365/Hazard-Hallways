using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HardLevelSelectAB2 : MonoBehaviour
{
    public void DarkAsTheNightButton()
    {
        SceneManager.LoadScene("Dark As The Night");
    }

    public void JumpingForJoyButton()
    {
        SceneManager.LoadScene("Jumping For Joy");
    }
}
