using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HardLevelSelectBeginning1 : MonoBehaviour
{
    // Start is called before the first frame update
    public void NextButton()
    {
        SceneManager.LoadScene("Hard Level Select Beginning 2");
    }
}
