using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class WallController : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        PlayerController player = collision.collider.GetComponent<PlayerController>();

        if (player != null && player.CanMove)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            GameManager.Instance.GameOver();
        }
    }
}
