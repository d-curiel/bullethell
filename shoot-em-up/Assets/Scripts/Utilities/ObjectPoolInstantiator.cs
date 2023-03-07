using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolInstantiator : MonoBehaviour
{
    [Header("Configuration")]
    [SerializeField]
    private GameObject _objectToPool;
    [SerializeField]
    private int _poolSize;

    private GameObject _parent;
    private Queue<GameObject> _objectPool;

    private void Awake()
    {
        _objectPool = new Queue<GameObject>();
        _parent = new GameObject("ObjectPool_" + _objectToPool.name);
    }

    private void OnDestroy()
    {
        foreach(GameObject go in _objectPool)
        {
            Destroy(go);
        }
    }

    public GameObject CreateGameObject()
    {
        GameObject spawnedObject;
        if (_objectPool.Count < _poolSize)
        {
            spawnedObject = Instantiate(_objectToPool, transform.position, Quaternion.identity);
            spawnedObject.transform.parent = _parent.transform;
            spawnedObject.name = _parent.name + "_" + _objectPool.Count;
        } else
        {
            spawnedObject = _objectPool.Dequeue();
            spawnedObject.transform.position = transform.position;
            spawnedObject.transform.rotation = transform.rotation;
            spawnedObject.SetActive(true);
        }
        _objectPool.Enqueue(spawnedObject);
        return spawnedObject;
    }

}
