using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerScript : MonoBehaviour
{
    public PlayableDirector timeline;
    public GameObject[] obj;

    void Start()
    {
        foreach (GameObject enemy in obj)
        {
            enemy.SetActive(false);
        }
    }

    public bool OneTimeTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            foreach (GameObject enemy in obj)
            {
                enemy.SetActive(true);
            }

            timeline.Play();

            if (OneTimeTrigger == true && this.gameObject != null)
            {
                Destroy(this.gameObject);
            }

            timeline.stopped += OnPlayableDirectorStopped;

        }
    }

    void OnPlayableDirectorStopped(PlayableDirector aDirector)
    {
        foreach (GameObject enemy in obj)
        {
            enemy.SetActive(false);
        }
    }



}
