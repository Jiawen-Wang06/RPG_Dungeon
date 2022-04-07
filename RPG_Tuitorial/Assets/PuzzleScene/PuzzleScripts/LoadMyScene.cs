using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMyScene : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject[] pics;
    [SerializeField]
     AudioSource  questComp;
     [SerializeField]
     AudioSource  bk;
    bool[] pieceFinish = { false, false, false, false };
    int counter = 0;
    bool complete = false;
    void Start()
    {
       bk.Play();

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(LoadNewScene());
        for (int i = 0; i < 4; i++)
        {

            string pieceStat = pics[i].GetComponent<PuzzlePic>().pieceStatus;
            if (pieceStat == "locked" && pieceFinish[i] == false)
            {

                pieceFinish[i] = true;
                counter++;
                Debug.Log(counter);
            }
        }



    }
    IEnumerator LoadNewScene()
    {
        if (counter == 4 && !complete)
        {
            complete = true;
            bk.Stop();
            yield return new WaitForSeconds(1);
            questComp.Play();
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene("myScene");
            


        }

    }

}
