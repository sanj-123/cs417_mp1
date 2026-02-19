using UnityEngine;
using UnityEngine.SceneManagement;

public class game_manager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int solved = 0;
    public void addSolved() {
        solved++;
        if (solved == 3) {
            SceneManager.LoadScene("WinScene");
        }
    }
}
