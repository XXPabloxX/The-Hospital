using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawnPoint : MonoBehaviour {

    [SerializeField]
    GameObject _spawnPoint;

    [SerializeField]
    int sceneToUnload;
    [SerializeField]
    int sceneToload;


    public void CrossDoor(UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter character)
        {
            Vector3 posicionDestino = _spawnPoint.transform.position;
            Vector3 rotacionDestino = _spawnPoint.transform.eulerAngles;

            character.transform.position = posicionDestino;
            character.transform.eulerAngles = rotacionDestino;

        SceneManager.UnloadSceneAsync(sceneToUnload);
        SceneManager.LoadScene(sceneToload, LoadSceneMode.Additive);

    }


}
