using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoading : MonoBehaviour
{
    // Start is called before the first frame update
    public int SceneToLoad;

    private void OnTriggerEnter(Collider other)
    {
        Cursor.visible = true;
        LoadLevel();
    }
    public void LoadLevel()
    {
        Cursor.visible = false;
        SceneManager.LoadScene(SceneToLoad);
    }
}
