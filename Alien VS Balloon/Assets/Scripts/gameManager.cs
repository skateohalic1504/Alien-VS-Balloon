 using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class gameManager : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public Vector3 moveVector;


    public void EndGame()
    {
        Debug.Log("Game OVer");
    }
}
