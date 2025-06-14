using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    
    // Audio Proximity Logic
    public AudioSource[] audioSources;
    public float audioProximity = 5.0f;

    public GameObject player;
    public Text pickupText;

    //Pickup and Level Completion
    public int currentPickups = 0;
    public int maxPickups = 5;
    public bool levelComplete = false;


    //Update is called once per frame
    private void Update()
    {
        LevelCompleteCheck();
        UpdateGUI();
        PlayAudioSamples();
    }

    private void LevelCompleteCheck()
    {
        if (currentPickups >= maxPickups) { 
            levelComplete = true;
        }
        else
        {
            levelComplete = false;
        }


    }

    private void UpdateGUI()
    {
        pickupText.text = "Pickups: " + currentPickups + "/" + maxPickups;

    }

    private void PlayAudioSamples()
    {
        for (int i = 0; i < audioSources.Length; i++)
        {
            if(audioSources[i]!= null)
            {
                if (Vector3.Distance(player.transform.position, audioSources[i].transform.position) <= audioProximity)
                {
                    if (!audioSources[i].isPlaying)
                    {
                        audioSources[i].Play();
                    }
                }
            
            }
        }
    }

}


