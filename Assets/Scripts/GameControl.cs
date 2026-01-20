using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    [SerializeField] private GameObject _coinPrefab;
    [SerializeField] private float _spawnSpeed = 0.3f;
    [SerializeField] private TMP_Text _points;
    private float _spawnTimer = 0f;
    private float _Timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        _spawnTimer = _Timer;
    }

    // Update is called once per frame
    void Update()
    {
        
        _spawnTimer -= Time.deltaTime;
        if (_spawnTimer <= 0)
        {
            int randomTimer = Random.Range(1, 10);
            Instantiate(_coinPrefab, new Vector3(15, 15, 0), Quaternion.identity);
            _Timer = randomTimer* _spawnSpeed;
            _spawnTimer = _Timer;
        }
    }
    public void Updatepoint(int pointnumber)
    {
        _points.text = pointnumber.ToString();
    }
    
}


