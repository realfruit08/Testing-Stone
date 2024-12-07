using System;
using UnityEngine;

public class SpaceshipMovement : MonoBehaviour
{

   public float thrustForce = 0.005f;
   public float rotationSpeed = 0.5f;
   public GameObject bulletPrefab;
   public Transform bulletSpawnPoint;

   void Start()
   {
   }

   void Update()
   {
    if (Input.GetKey(KeyCode.W))
    { transform.position += Vector3.up * thrustForce;
    }
    if (Input.GetKey(KeyCode.S))
    { transform.position += Vector3.down * thrustForce;
    }
    if (Input.GetKey(KeyCode.A))
     { transform.position += Vector3.left * thrustForce;
     }
     if (Input.GetKey(KeyCode.D))
     { transform.position += Vector3.right * thrustForce;
     }
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(horizontal, vertical, 0);
        transform.position += move * Time.deltaTime;
        if (move.sqrMagnitude > 0.01f)
        { transform.up = move.normalized;
        }
        HandleShooting();
   }

    private void HandleShooting()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { Debug.Log("Pew Pew");
            if (bulletPrefab != null && bulletSpawnPoint != null)
            { Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            }
          }
        }
    }
