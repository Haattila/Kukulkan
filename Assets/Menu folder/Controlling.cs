using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Controlling : MonoBehaviour {

    public Transform Menu, optionMenu;
    public void LoadScen(string name) {

        SceneManager.LoadScene(name);

    }
    public void Exit()
    {
        Application.Quit();
    }


    public void options(bool click)
    {
        if (click)
        {
            optionMenu.gameObject.SetActive(click);
            Menu.gameObject.SetActive(!click);
        }
        else
        {
            optionMenu.gameObject.SetActive(click);
            Menu.gameObject.SetActive(!click);
        }
    }
}
