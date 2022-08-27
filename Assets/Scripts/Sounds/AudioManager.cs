using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioManager instance;
    public AudioSource fxSource;
    public AudioSource fx3dSource;
    public AudioClip clickSound;
    public AudioClip doorSound;
    public AudioClip fireSound;
    public AudioClip crystalBallSound;
    public AudioClip hurtSound;
    public AudioClip checkpointSound;
    public AudioClip footstepsSound;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlaySoundButton()
    {
        fxSource.PlayOneShot(clickSound);
    }

    public void PlaySoundDoor()
    {
        fxSource.PlayOneShot(doorSound);
    }

    public void PlaySoundCrystalBall()
    {
        fxSource.PlayOneShot(crystalBallSound);
    }

    public void PlaySoundFire()
    {
        fx3dSource.PlayOneShot(fireSound);
    }

    public void PlaySoundHurt()
    {
        fxSource.PlayOneShot(hurtSound);
    }

    public void PlaySoundCheckpoint()
    {
        fxSource.PlayOneShot(checkpointSound);
    }

    public void PlaySoundFootsteps()
    {
        fxSource.PlayOneShot(footstepsSound);
    }


}
