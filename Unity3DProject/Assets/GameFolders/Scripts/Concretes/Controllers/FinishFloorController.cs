using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishFloorController : MonoBehaviour
{
    [SerializeField] GameObject finishFireWorks;
    [SerializeField] GameObject finishLights;

    private void OnCollisionEnter(Collision collision)
    {
        PlayerController player = collision.collider.GetComponent<PlayerController>();

        if (player == null || !player.CanMove) return;

        if (collision.GetContact(0).normal.y == -1)  // ustten asagiya dogru mu degdi ??
        {
            finishFireWorks.gameObject.SetActive(true);
            finishLights.gameObject.SetActive(true);

            GameManager.Instance.MissionSucced();

        } else
        {
            // gameover 
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            GameManager.Instance.GameOver();
        }
    }


}
