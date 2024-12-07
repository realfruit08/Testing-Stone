using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Lives : MonoBehaviour
{
    public int totalLives = 3;
    public TextMeshProUGUI gameOverText;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Asteroid"))
        { totalLives--;

            if (totalLives <= 0)
            { Debug.Log("Game Over");
                if (gameOverText != null)
                {
                    gameOverText.gameObject.SetActive(true);
                }
            }
            else
            { Debug.Log("Lives left: " + totalLives);
            }
        }
    }
}
