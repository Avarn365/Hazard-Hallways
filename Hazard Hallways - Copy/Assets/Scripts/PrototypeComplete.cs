using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrototypeComplete : MonoBehaviour
{
    public void Start()
    {
        Cursor.visible = !Cursor.visible;
        Cursor.lockState = CursorLockMode.None;
    }

    public void MenuButton()
    {
        SceneManager.LoadScene("Title Screen");
    }
}
