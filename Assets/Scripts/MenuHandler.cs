using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuHandler : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void QuitGame()
    {
        //quit game
        Application.Quit();
    }

    public void loadlevel(int scene)
    {
        //load scene
        SceneManager.LoadScene(scene);
    }


}
