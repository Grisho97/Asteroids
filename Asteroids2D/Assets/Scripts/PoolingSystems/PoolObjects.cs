using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PoolObjects : MonoBehaviour
{
    [SerializeField] private GameObject pollingPrefab;
    [SerializeField] private int amountOfStartClones = 20;
    private List<GameObject> _listOfClones;

    protected virtual void OnEnable()
    {
        GameController.OnStart += CreateListOfClones;
    }
    
    protected virtual void OnDisable()
    {
        GameController.OnStart -= CreateListOfClones;
    }

    protected virtual void CreateListOfClones()
    {
        _listOfClones = new List<GameObject>();
        _listOfClones = GenerateClones(amountOfStartClones);
    }

    List<GameObject> GenerateClones(int amountOfClones)
    {
        for (int i = 0; i < amountOfClones; i++)
        {
            GameObject clone = Instantiate(pollingPrefab, this.transform, true);
            clone.SetActive(false);
            _listOfClones.Add(clone);
        }
        
        return _listOfClones;
    }

    protected virtual GameObject RequestObject()
    {
        foreach (var clone in _listOfClones)
        {
            if (clone.activeInHierarchy == false)
            {
                clone.SetActive(true);
                return clone;
            }
        }
        GameObject newClone = Instantiate(pollingPrefab, this.transform, true);
        _listOfClones.Add(newClone);
        return newClone;
    }
}
