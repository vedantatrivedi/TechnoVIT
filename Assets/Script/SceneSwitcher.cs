using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void GotoGameplay()
    {
        SceneManager.LoadScene("SampleScene");
    }

//     public void GotoLeaderboard()
//     {
//         SceneManager.LoadScene("leaderBoardScene");
//     }
//  void OnCollisionEnter(Collision col)
//     {
//              Destroy(col.gameObject);
//            SceneManager.LoadScene("leaderBoardScene");
//     }
}