using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{

    public void StartQuitting(){
        StartCoroutine(QuitAfterTime());
    }

    IEnumerator QuitAfterTime(){
        // THIS CODE IS GAME JAM CODE, DISTGUTING ONLY BECAUSE DEADLINE CLOSE
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3.5f);
        Application.Quit();
    }
}
