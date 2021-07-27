using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;


/// <summary>
/// This class contains the function to call when play button is pressed
/// </summary>
public class StartGame : MonoBehaviour
{
	[SerializeField]
	private GameSceneSO _locationsToLoad;
	[SerializeField]
	private bool _showLoadScreen = default;
	//[SerializeField]
	//private SaveSystem _saveSystem = default;
	private bool _hasSaveData;
	[Header("Broadcasting on ")]
	[SerializeField]
	private LoadEventChannelSO _startGameEvent = default;
	[Header("Listening to")]
	[SerializeField]
	private VoidEventChannelSO _startNewGameEvent = default;


	private void Start()
	{
		_startNewGameEvent.OnEventRaised += StartNewGame;
	}
	private void OnDestroy()
	{
		_startNewGameEvent.OnEventRaised -= StartNewGame;
	}
	void StartNewGame()
	{
		_startGameEvent.RaiseEvent(_locationsToLoad, _showLoadScreen);
	}
}
