using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win_Scene_Script : MonoBehaviour
{
    public void RestartGame() {
        SceneManager.LoadScene(2);
    }
}
