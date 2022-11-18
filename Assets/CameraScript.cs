using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CameraScript : MonoBehaviour
{
    public AudioSource lobbyMusic;
    public AudioSource mainMusic;
    public GameObject cameraPrefab;
    public AudioListener lobbyCamAudioListener;
    bool gameStarted = false;
    public Transform player;
    public Vector3 spawnPos;
    public Quaternion spawnRot;
    public TMP_Text lobbyText;
    public Camera mainCam;

    void Update()
    {
        if (Input.GetKey("space") && !gameStarted)
        {
            gameStarted = true;
            lobbyMusic.enabled = false;
            mainMusic.Play();
            GameObject cameraObject = Instantiate(cameraPrefab, spawnPos, spawnRot) as GameObject;
            lobbyCamAudioListener.enabled = false;
            lobbyText.enabled = false;
        }
    }
}
