using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerScript : MonoBehaviour
{
    public PlayableDirector timeline;
    public GameObject obj;

    void Start()
    {
        obj.SetActive(false);
    }

    public bool OneTimeTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            obj.SetActive(true);

            timeline.Play();

            if (OneTimeTrigger == true)
            {
                Destroy(this.gameObject);
            }

            timeline.stopped += OnPlayableDirectorStopped;

        }
    }

    void OnPlayableDirectorStopped(PlayableDirector aDirector)
    {
        obj.SetActive(false);
    }



}
