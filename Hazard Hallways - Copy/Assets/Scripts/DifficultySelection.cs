using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultySelection : MonoBehaviour
{
    // Start is called before the first frame update
    public void HardButton()
    {
        SceneManager.LoadScene("Hard Level Select Beginning 1");
    }
    public void HarderButton()
    {
        SceneManager.LoadScene("Harder Level 1");
    }
    public void HardestButton()
    {
        SceneManager.LoadScene("Hardest Level 1");
    }
    public void BackButton()
    {
        SceneManager.LoadScene("Title Screen");
    }
}
