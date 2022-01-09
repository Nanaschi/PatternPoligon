using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class CompositionRoot : UnityEngine.MonoBehaviour
    {
        private UnitModel _unitModel;
        [SerializeField] private UnitSpawnView _unitSpawnView;
        private UnitSpawnPresenter _unitSpawnPresenter;

        private void Awake()
        {
            _unitSpawnPresenter = new UnitSpawnPresenter(_unitModel, _unitSpawnView);
        }

        private void Start()
        {
            _unitSpawnPresenter.Start();
        }
    }
}